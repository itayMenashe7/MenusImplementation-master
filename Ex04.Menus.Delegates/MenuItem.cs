namespace Ex04.Menus.Delegates
{
    using System;

    public delegate void ClickerHandler();

    public class MenuItem
    {
        private string m_Title;
        private bool m_IsMenu = false;
        private int m_MyIndex;

        public event ClickerHandler Clicked;

        public MenuItem(string i_Title, int i_CurrentIndex, ClickerHandler i_Clicked)
        {
            this.m_Title = i_Title;
            this.m_MyIndex = i_CurrentIndex;
            this.Clicked += i_Clicked;
        }

        public string Title
        {
            get { return this.m_Title; }
            set { this.m_Title = value; }
        }

        public int CurrentIndex
        {
            get { return this.m_MyIndex; }
            set { this.m_MyIndex = value; }
        }

        public bool IsMenu
        {
            get { return this.m_IsMenu; }
            set { this.m_IsMenu = value; }
        }

        public void ShowItem()
        {
            Console.WriteLine("{0}. {1}", this.m_MyIndex, this.m_Title);
        }

        public void OnCicked()
        {
            if (this.Clicked != null)
            {
                this.Clicked.Invoke();
            }
        }
    }
}
