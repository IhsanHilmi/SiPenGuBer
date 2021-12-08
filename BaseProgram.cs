using System;
class BaseProgram
{
    public static IDictionary<string, string> dataGunung = new Dictionary<string, string>();
    public BaseProgram()
    {

    }
    public static void ClearMenu()
    {
        Console.ResetColor();
        int TitleLineCursor = 7;
        for (int i = Console.CursorTop; i > TitleLineCursor; i--)
        {
            Console.SetCursorPosition(0, i);
            Console.Write(new string(' ', Console.WindowWidth));
        }
    }

    public static int SelectingOption(string[] menuOptions)
    {
        int selectedIndex = 0;
        ConsoleKeyInfo pressedKey;
        do
        {
            Console.CursorVisible = false;
            WriteOptions(selectedIndex, menuOptions);
            pressedKey = Console.ReadKey(true);
            switch (pressedKey.Key)
            {
                case ConsoleKey.UpArrow:
                    selectedIndex--;
                    break;
                case ConsoleKey.DownArrow:
                    selectedIndex++;
                    break;
                default: break;
            }
            if (selectedIndex == -1)
            {
                selectedIndex = menuOptions.Length - 1;
            }
            else if (selectedIndex == menuOptions.Length)
            {
                selectedIndex = 0;
            }
            ClearMenu();
        } while (pressedKey.Key != ConsoleKey.Enter);
        return selectedIndex;
    }
    static void WriteOptions(int selectedIndex, string[] options)
    {
        string prefix;
        Console.WriteLine("Use Arrow (↑/↓)");
        for (int i = 0; i < options.Length; i++)
        {
            if (i == selectedIndex)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                prefix = ">>> ";
            }
            else
            {
                prefix = " ♦ ";
                Console.ResetColor();
            }
            Console.Write($"{prefix}{options[i]}");
            Console.WriteLine();
        }
    }


}