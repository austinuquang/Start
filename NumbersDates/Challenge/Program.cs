using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a date, or type 'exit' if you wish to leave the program:");
            string input = Console.ReadLine(); 

            if (input.ToLower() == "exit") 
            {
                break;
            }

            if (DateTime.TryParse(input, out DateTime dateentered)) 
            {
                DateTime todaysdate = DateTime.Now;

                if (dateentered.Date < todaysdate.Date)
                {
                    Console.WriteLine("The date is in the past.");
                }
                else if (dateentered.Date > todaysdate.Date)
                {
                    Console.WriteLine("The date entered is in the future.");
                }
                else
                {
                    Console.WriteLine("The date entered is today.");
                }
            }
            else
            {
                Console.WriteLine("Invalid date entered. Please try again.");
            }
        }
    }
}
