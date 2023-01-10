namespace Ex04.Menus.Interfaces
{
    using System;

    internal class UppercaseCounterItem : IMenuItem
    {
        public UppercaseCounterItem()
        {
            this.Name = "Count Uppercase";
        }

        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine("Enter a string: ");
            string userInput = Console.ReadLine();
            int howManyCapitalLetter = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                {
                    howManyCapitalLetter++;
                }
            }

            Console.WriteLine($"There is {howManyCapitalLetter} upper case letters.");
        }
    }
}
