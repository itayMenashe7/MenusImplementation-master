namespace Ex04.Menus.Test
{
    public class CreateMenu
    {
        public static Delegates.DelegatesMainMenu CreateMainMenuForDelegateMethod()
        {
            Delegates.DelegatesMainMenu menu = new Delegates.DelegatesMainMenu("Main Menu - Delegates");
            Delegates.DelegatesMainMenu subMenuVersionAndUpperCase = new Delegates.DelegatesMainMenu("Version and UpperCase");
            Delegates.DelegatesMainMenu rubMenuDateAndTime = new Delegates.DelegatesMainMenu("Show Date/Time");

            subMenuVersionAndUpperCase.AddMenuItem("Count Capitals", MethodsToDelegates.CountHowManyCapitalLetter);
            subMenuVersionAndUpperCase.AddMenuItem("Show Version", MethodsToDelegates.GetVersion);
            rubMenuDateAndTime.AddMenuItem("Show Time", MethodsToDelegates.GetTime);
            rubMenuDateAndTime.AddMenuItem("Show Date", MethodsToDelegates.ShowDate);
            menu.AddMenuItem(subMenuVersionAndUpperCase);
            menu.AddMenuItem(rubMenuDateAndTime);

            return menu;
        }
    }
}
