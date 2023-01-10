namespace Ex04.Menus.Interfaces
{
    internal class DateAndTimeMenu : IMenuItem
    {
        private readonly IMenu r_SubMenu;

        public DateAndTimeMenu()
        {
            this.Name = "Date and Time";
            this.r_SubMenu = new SubMenu(this, this.Name);
            this.r_SubMenu.AddMenuItem(new DateItem());
            this.r_SubMenu.AddMenuItem(new TimeItem());
        }

        public string Name { get; set; }

        public void Execute()
        {
            this.r_SubMenu.ExecuteMenuOption(this.r_SubMenu.DisplayMenuAndChooseOption());
        }
    }
}
