namespace Ex04.Menus.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public delegate void UpdateLevelSubMenuHandler(int i_NewLevel);

    public class DelegatesMainMenu
    {
        private List<MenuItem> m_MenuItems = new List<MenuItem>();
        private int m_index = 0;
        private int m_CurrentLevel;
        private string m_Title;

        public event UpdateLevelSubMenuHandler BecameSubMenu;

        public DelegatesMainMenu(string i_Title)
        {
            this.m_Title = i_Title;
            this.m_CurrentLevel = 0;
            this.AddMenuItem("Exit", this.exit_Clicked);
        }

        public List<MenuItem> MenuItems
        {
            get { return this.m_MenuItems; }
        }

        public int Index
        {
            get { return this.m_index; }
            set { this.m_index = value; }
        }

        public string Title
        {
            get { return this.m_Title; }
            set { this.m_Title = value; }
        }

        public int CurrentLevel
        {
            get { return this.m_CurrentLevel; }
            set { this.m_CurrentLevel = value; }
        }

        public void AddMenuItem(string i_Title, ClickerHandler i_FunctionToAdd)
        {
            // add menu item to menu, to the next index.
            this.m_MenuItems.Add(new MenuItem(i_Title, this.Index++, i_FunctionToAdd));
        }

        public void AddMenuItem(DelegatesMainMenu io_SubMenu)
        {
            io_SubMenu.m_MenuItems[0].Title = "Back";
            io_SubMenu.m_MenuItems[0].IsMenu = true;
            io_SubMenu.m_MenuItems[0].Clicked += this.StartShow;
            io_SubMenu.m_MenuItems[0].Clicked -= io_SubMenu.exit_Clicked;

            this.AddMenuItem(io_SubMenu.Title, io_SubMenu.StartShow);
            this.MenuItems[this.MenuItems.Count - 1].IsMenu = true;
            io_SubMenu.OnBecameSubMenu(this.CurrentLevel + 1);
            this.BecameSubMenu += io_SubMenu.OnBecameSubMenu;
        }

        public void exit_Clicked()
        {
            Environment.Exit(-1);
        }

        public void StartShow()
        {
            bool quit = false;

            this.printMenu();

            while (!quit)
            {
                this.getInputFromTheUser(out int userChoice);

                Console.Clear();
                this.MenuItems[userChoice].OnCicked();

                if (this.MenuItems[userChoice].IsMenu)
                {
                    quit = true;
                }
                else
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    this.printMenu();
                }
            }
        }

        private void getInputFromTheUser(out int io_UserChoice)
        {
            io_UserChoice = -1;

            Console.WriteLine("Please choose one of the option, you can eneter 0 for exit/back.");

            while (!int.TryParse(Console.ReadLine(), out io_UserChoice) || io_UserChoice < 0 || io_UserChoice >= this.MenuItems.Count())
            {
                Console.WriteLine("You entered invallid value please try again.");
            }
        }

        private void printMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu level: {0} {1} Title: {2}", this.CurrentLevel, Environment.NewLine, this.Title);

            foreach (MenuItem item in this.m_MenuItems)
            {
                item.ShowItem();
            }
        }

        private void OnBecameSubMenu(int io_NewLevel)
        {
            this.CurrentLevel = io_NewLevel;

            if (this.BecameSubMenu != null)
            {
                this.BecameSubMenu.Invoke(io_NewLevel + 1);
            }
        }
    }
}
