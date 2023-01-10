namespace Ex04.Menus.Test
{
    using Ex04.Menus.Delegates;
    using Ex04.Menus.Interfaces;

    public class Program
    {
        public static void Main()
        {
            InterfacesMainMenu interfacesMenu = new InterfacesMainMenu();
            interfacesMenu.ShowMenu();

            DelegatesMainMenu delegatesMenu = CreateMenu.CreateMainMenuForDelegateMethod();
            delegatesMenu.StartShow();
        }
    }
}
