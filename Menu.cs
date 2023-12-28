namespace Notepad
{
  public class Menu
  {
    public void Show()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.DarkGreen;

      DrawWindow();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandlerMenuOption(option);
    }

    protected void DrawLineTopBotton()
    {
      Console.Write("+");
      for (short i = 0; i < sizex; i++)
      {
        Console.Write(" ");
      }
      Console.Write("+");
      Console.Write("\n");
    }

    protected void DrawLineBody()
    {
      for (short i = 0; i < sizey - 2; i++)
      {
        for (short j = 0; j < sizex + 2; j++)
        {
          Console.Write(" ");
        }
        Console.Write("\n");
      }
    }

    protected const short sizex = 38;
    protected const short sizey = 14;

    protected void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Notepad");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("-------");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma das opcoes abaixo:");
      Console.SetCursorPosition(3, 5);
      Console.WriteLine("[1] Criar Novo Arquivo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("[2] Abrir arquivo existente");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("[0] Sair");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("Opcao: ");
      Console.SetCursorPosition(10, 9);
    }

    protected void HandlerMenuOption(short option)
    {
      switch (option)
      {
        case 1: Console.WriteLine("Editor.Show()"); break;
        case 2: Console.WriteLine("Viewer.Show()"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0); break;
          }
        default: Show(); break;
      }
    }

    public void DrawWindow()
    {
      DrawLineTopBotton();
      DrawLineBody();
      DrawLineTopBotton();
    }
  }
}