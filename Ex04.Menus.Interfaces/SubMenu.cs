namespace Ex04.Menus.Interfaces
{
    using System.Collections.Generic;

    public class SubMenu : MenuItem
    {
        private readonly IMenuItem m_ParentMenuItem;
        private readonly List<IMenuItem> m_MenuItems;

        public SubMenu(IMenuItem i_ParentMenuItem, string i_Title)
            : base(i_Title)
        {
            this.m_ParentMenuItem = i_ParentMenuItem;
            this.m_MenuItems = new List<IMenuItem>();
        }

        public IMenuItem ParentItem
        {
            get { return this.m_ParentMenuItem; }
        }

        public List<IMenuItem> MenuItems
        {
            get { return this.m_MenuItems; }
        }
    }
}
