using System.Text;

namespace Notepad
{
  public class Editor
  {
    public void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      Console.WriteLine("MODO EDITOR (ESC para sair)");
      Console.WriteLine("-------------------------------------------");
      Start();
    }

    protected void Start()
    {
      var file = new StringBuilder();

      do
      {
        file.Append(Console.ReadLine());
        file.Append(Environment.NewLine);
      } while (Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("-------------------------------------------");
      Console.WriteLine("Deseja salvar este arquivo?");
      // Chamar Visualizacao...
    }
  }
}