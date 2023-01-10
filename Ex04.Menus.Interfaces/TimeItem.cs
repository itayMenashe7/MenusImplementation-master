namespace Ex04.Menus.Interfaces
{
    using System;

    internal class TimeItem : IMenuItem
    {
        public TimeItem()
        {
            this.Name = "Show Time";
        }

        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine($"The time is: {DateTime.Now.ToShortTimeString()}");
        }
    }
}
