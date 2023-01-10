namespace Ex04.Menus.Interfaces
{
    using System;

    internal class VersionItem : IMenuItem
    {
        public VersionItem()
        {
            this.Name = "Show Version";
        }

        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine("Version:23.1.4.8859\n\n");
        }
    }
}
