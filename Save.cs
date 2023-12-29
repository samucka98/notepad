
namespace Notepad
{
  public class Save
  {
    public void SaveFile(string text)
    {
      Console.Clear();
      Console.WriteLine("Qual o nome do arquivo?");
      string nameFile = Console.ReadLine();
      var baseDir = Directory.GetCurrentDirectory();
      var filesDir = Path.Combine(baseDir, "files");
      var path = Path.Combine(filesDir, $"{nameFile}.txt");

      using (var file = new StreamWriter(path))
      {
        file.Write(text);
      }
    }

    public void ShowOptionsSave()
    {
      Console.WriteLine("[1] Sim");
      Console.WriteLine("[2] Nao");
      Console.WriteLine("-------");
    }

    public void HandleOptionSave(short option, string text)
    {
      switch (option)
      {
        case 1: SaveFile(text); break;
        case 2: new Menu().Show(); break;
        default: HandleOptionSave(option, text); break;
      }
    }
  }
}