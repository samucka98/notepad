using System.Text.RegularExpressions;

namespace Notepad
{
  public class Viewer
  {
    public void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO VISUALIZAÇÃO");
      Console.WriteLine("----------------------------------------");
      Replace(text);
      Console.WriteLine("----------------------------------------");
      Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
      Console.ReadKey();

      var menu = new Menu();
      menu.Show();
    }

    public void Open()
    {
      Console.WriteLine("Qual o nome do arquivo?");
      string nameFile = Console.ReadLine();
      var baseDir = Directory.GetCurrentDirectory();
      var filesDir = Path.Combine(baseDir, "files");
      var path = Path.Combine(filesDir, $"{nameFile}.txt");

      using (var file = new StreamReader(path))
      {
        string text = file.ReadToEnd();
        Console.WriteLine(text);
        new Viewer().Show(text);
      }
    }

    protected void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');
      for (var i = 0; i < words.Length; i++)
      {
        if (strong.IsMatch(words[i]))
        {
          Console.ForegroundColor = ConsoleColor.Blue;
          Console.Write(words[i].Substring(words[i].IndexOf('>') + 1, ((words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>'))));
          Console.Write(" ");
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}