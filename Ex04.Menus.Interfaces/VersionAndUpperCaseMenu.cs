namespace Ex04.Menus.Interfaces
{
    public class VersionAndUpperCaseMenu : IMenuItem
    {
        private readonly IMenu r_SubMenu;

        public VersionAndUpperCaseMenu()
        {
            this.Name = "Version and Uppercase";
            this.r_SubMenu = new SubMenu(this, this.Name);
            this.r_SubMenu.AddMenuItem(new VersionItem());
            this.r_SubMenu.AddMenuItem(new UppercaseCounterItem());
        }

        public string Name { get; set; }

        public void Execute()
        {
            this.r_SubMenu.ExecuteMenuOption(this.r_SubMenu.DisplayMenuAndChooseOption());
        }
    }
}
