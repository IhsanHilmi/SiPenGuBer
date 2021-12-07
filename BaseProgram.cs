using System;
class BaseProgram
{
    public static IDictionary<string, string> dataGunung = new Dictionary<string, string>();
    public BaseProgram()
    {

    }
    public static void ClearMenu()
    {
        Console.Clear();
        WriteTitle();
    }
    static void WriteTitle()
    {
        Console.WriteLine();
        Console.WriteLine("================================================================================");
        Console.WriteLine(" ███████ ██ ██████  ███████ ███    ██  ██████  ██    ██ ██████  ███████ ██████  ");
        Console.WriteLine(" ██      ██ ██   ██ ██      ████   ██ ██       ██    ██ ██   ██ ██      ██   ██ ");
        Console.WriteLine(" ███████ ██ ██████  █████   ██ ██  ██ ██   ███ ██    ██ ██████  █████   ██████  ");
        Console.WriteLine("      ██ ██ ██      ██      ██  ██ ██ ██    ██ ██    ██ ██   ██ ██      ██   ██ ");
        Console.WriteLine(" ███████ ██ ██      ███████ ██   ████  ██████   ██████  ██████  ███████ ██   ██ ");
        Console.WriteLine("================================================================================");
        Console.WriteLine();
    }
    public static int SelectingOption(string[] menuOptions)
    {
        int selectedIndex = 0;
        ConsoleKeyInfo pressedKey;
        do
        {
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
        for (int i = 0; i < options.Length; i++)
        {
            if (i == selectedIndex)
            {
                prefix = ">>";
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                prefix = "  ";
            }
            Console.Write($"{prefix}{options[i]}");
            Console.ResetColor();
            Console.WriteLine();
        }
    }


}