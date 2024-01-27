using System.Text.RegularExpressions;

namespace EditorHtml
{
  public class Viewer
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();

      Console.WriteLine("*** Modo de Visualização ***");
      Console.WriteLine("-------------------");
      Replace(text);
      Console.WriteLine("\n-------------------");
      Console.ReadKey();
      Menu.Show();
    }

    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);

      var index = 0;
      foreach (Match match in strong.Matches(text))
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(text.Substring(index, match.Index - index));

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(match.Groups[1].Value);

        index = match.Index + match.Length;
      }

      Console.ForegroundColor = ConsoleColor.Black;
      Console.Write(text.Substring(index));
    }

  }
}