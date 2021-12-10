using System;
class MainProgram : BaseProgram
{
    static string[] mainMenuOptions = { "Cek Status", "Lihat History Status", "Reset" };
    static void Main()
    {
        int indexMainMenu;

        Console.SetWindowSize(81, Console.WindowHeight);
        Console.BufferWidth = 81;
        Console.ResetColor();
        Console.Clear();
        WriteTitle();
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
            default: break;
        }
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