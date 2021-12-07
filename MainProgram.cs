using System;
class MainProgram : BaseProgram
{
    static string[] mainMenuOptions = { "Cek Status", "Lihat History Status", "Reset" };
    static void Main()
    {
        int indexMainMenu;

        ClearMenu();
        indexMainMenu = SelectingOption(mainMenuOptions);
        switch (indexMainMenu)
        {
            case 0:
                new MenuCekStatus();
                break;
            case 1:
                new MenuHistoryStatus();
                break;
            case 2:
                new MenuReset();
                break;
            default: break;
        }

    }
}