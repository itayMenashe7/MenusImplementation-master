namespace Ex04.Menus.Interfaces
{
    public class InterfacesMainMenu
    {
        private IMenu m_MainMenu;

        public void ShowMenu()
        {
            this.InitMainMenu();
            this.m_MainMenu.ExecuteMenuOption(this.m_MainMenu.DisplayMenuAndChooseOption());
        }

        public void InitMainMenu()
        {
            this.m_MainMenu = new MenuItem("Interfaces Main Menu");
            this.m_MainMenu.AddMenuItem(new VersionAndUpperCaseMenu());
            this.m_MainMenu.AddMenuItem(new DateAndTimeMenu());
        }
    }
}
