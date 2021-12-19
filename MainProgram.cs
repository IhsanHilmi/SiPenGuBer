using System;
class MainProgram : BaseProgram
{
    public static IDictionary<string, string> dataGunung = new Dictionary<string, string>();
    static string[] mainMenuOptions = { "Cek Status", "Lihat History Status", "Reset", "Exit" };
    static void Main()
    {
        int indexMainMenu;

        Console.SetWindowSize(81, Console.WindowHeight);
        Console.BufferWidth = 81;
        Console.ResetColor();
        Console.Clear();
        WriteTitle();
        do
        {
            ClearMenu();
            indexMainMenu = SelectingOption(mainMenuOptions);
            switch (indexMainMenu)
            {
                case 0:
                    new MenuCekStatus();
                    break;
                case 1:
                    new HistoryProgram();
                    break;
                case 2:
                    new MenuReset();
                    break;
                case 3:
                    return;
                default: break;
            }
        } while (true);

    }
    static void WriteTitle()
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("================================================================================");
        Console.WriteLine(" ███████ ██ ██████  ███████ ███    ██  ██████  ██    ██ ██████  ███████ ██████  ");
        Console.WriteLine(" ██      ██ ██   ██ ██      ████   ██ ██       ██    ██ ██   ██ ██      ██   ██ ");
        Console.WriteLine(" ███████ ██ ██████  █████   ██ ██  ██ ██   ███ ██    ██ ██████  █████   ██████  ");
        Console.WriteLine("      ██ ██ ██      ██      ██  ██ ██ ██    ██ ██    ██ ██   ██ ██      ██   ██ ");
        Console.WriteLine(" ███████ ██ ██      ███████ ██   ████  ██████   ██████  ██████  ███████ ██   ██ ");
        Console.WriteLine("================================================================================");
        Console.WriteLine();
        Console.ResetColor();
    }
}