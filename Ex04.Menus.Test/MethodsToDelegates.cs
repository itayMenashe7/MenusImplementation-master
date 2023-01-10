namespace Ex04.Menus.Test
{
    using System;

    public class MethodsToDelegates
    {
        public static void CountHowManyCapitalLetter()
        {
            Console.WriteLine("Please enter your sentence:");
            string userInput = Console.ReadLine();
            int howManyCapitalLetter = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (char.IsUpper(userInput[i]))
                {
                    howManyCapitalLetter++;
                }
            }

            Console.WriteLine("There is {0} upper case letters.", howManyCapitalLetter);
        }

        public static void GetVersion()
        {
            Console.WriteLine("Number version: 20.2.4.30620");
        }

        public static void GetTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }
    }
}
