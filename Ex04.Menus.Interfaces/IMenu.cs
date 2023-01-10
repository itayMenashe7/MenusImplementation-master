namespace Ex04.Menus.Interfaces
{
    public interface IMenu
    {
        void AddMenuItem(IMenuItem menuItem);

        int DisplayMenuAndChooseOption();

        void ExecuteMenuOption(int choice);
    }
}
