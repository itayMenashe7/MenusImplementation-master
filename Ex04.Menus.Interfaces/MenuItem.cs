namespace Ex04.Menus.Interfaces
{
    using System;
    using System.Collections.Generic;

    public class MenuItem : IMenu
    {
        private readonly string m_Title;
        private readonly List<IMenuItem> r_MenuItems;

        public MenuItem(string i_Title)
        {
            this.m_Title = i_Title;
            this.r_MenuItems = new List<IMenuItem>();
        }

        public string Title
        {
            get { return this.m_Title; }
        }

        public void AddMenuItem(IMenuItem io_MenuItem)
        {
            this.r_MenuItems.Add(io_MenuItem);
        }

        public void PrintTitle()
        {
            Console.WriteLine($"**{this.Title}**");
            Console.WriteLine("-----------------------");
        }

        public int DisplayMenuAndChooseOption()
        {
            string userInput = null;
            this.PrintTitle();
            for (int i = 0; i < this.r_MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1} -> {this.r_MenuItems[i].Name}");
            }

            if (this is SubMenu)
            {
                Console.WriteLine("0 -> back");
            }
            else
            {
                Console.WriteLine("0 -> exit");
            }

            Console.WriteLine("Enter your request:");
            bool userEnterValidInput = false;
            while (!userEnterValidInput)
            {
                userInput = Console.ReadLine();
                if (this.IsInputIsValid(userInput))
                {
                    userEnterValidInput = true;
                }
                else
                {
                    Console.WriteLine($"Invalid Input! please enter number bitween 0 - {this.r_MenuItems.Count}");
                }
            }

            return Convert.ToInt32(userInput);
        }

        public bool IsInputIsValid(string i_UserInput)
        {
            bool isValid = false;
            if (int.TryParse(i_UserInput, out int result))
            {
                if (Convert.ToInt32(i_UserInput) <= this.r_MenuItems.Count)
                {
                    isValid = true;
                }
            }

            return isValid;
        }

        public void ExecuteMenuOption(int i_Choice)
        {
            if (i_Choice == 0)
            {
                return;
            }

            this.r_MenuItems[i_Choice - 1].Execute();
            this.ExecuteMenuOption(this.DisplayMenuAndChooseOption());
        }
    }
}
