namespace Ex04.Menus.Interfaces
{
    using System;

    internal class DateItem : IMenuItem
    {
        public DateItem()
        {
            this.Name = "Show Date";
        }

        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine($"The date is: {DateTime.Now.ToShortDateString()}");
        }
    }
}
