namespace EditorHtml
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.DarkBlue;
      Console.ForegroundColor = ConsoleColor.Yellow;

      DrawScreen();
      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    public static void DrawScreen()
    {
      DrawColumns(30);
      DrawRows(10, 30);
      DrawColumns(30);
    }

    static void DrawColumns(int columns)
    {
      Console.Write("+");
      for (int i = 0; i <= columns; i++)
      {
        Console.Write("-");
      }
      Console.Write("+");
      Console.Write("\n");
    }

    static void DrawRows(int rows, int columns)
    {
      for (int lines = 0; lines <= rows; lines++)
      {
        Console.Write("|");

        for (int i = 0; i <= columns; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor HTML");

      Console.SetCursorPosition(3, 3);
      Console.WriteLine("=============");

      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Seleciona uma opção abaixo:");

      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo arquivo");

      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");

      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Abrir");

      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("View"); break;
        case 0:
          {
            Console.Clear();
            Environment.Exit(0);
            break;
          }
        default: Show(); break;
      }
    }
  }
}