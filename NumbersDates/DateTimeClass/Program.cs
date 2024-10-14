// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for working with Dates and Times

// TODO: Use DateTime.Now property to get the current date and time
//DateTime now= DateTime.Now;
//Console.WriteLine(now);


// TODO: DateTime.Today gets just the current date with time set to 12:00:00 AM
//DateTime today= DateTime.Now;
//Console.WriteLine(today);


// TODO: DateOnly and TimeOnly represent just dates and times
//DateOnly dt=DateOnly.FromDateTime(DateTime.Now);
//TimeOnly tm= TimeOnly.FromDateTime(DateTime.Now);

//Console.WriteLine(dt); 
//Console.WriteLine(tm); 


// TODO: Dates have properties that can be inspected
//Console.WriteLine(today.DayOfWeek);
//Console.WriteLine(today.DayOfYear);


// TODO: Dates also have methods to change their values
// now= now.AddDays(6);
// now = now.AddHours(12); 
// now = now.AddMonths(1); 
// Console.WriteLine(now); 


// TODO: The TimeSpan class represents a duration of time
// DateTime AprilFools = new DateTime(now.Year, 4, 1); 
// DateTime NewYears = new DateTime(now.Year, 1, 1);
// TimeSpan interval = AprilFools - NewYears; 
// Console.WriteLine(interval); 

// TODO: Dates can be compared using regular operators

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
            Console.WriteLine("The date entered is the present.");
        }
    }
    else
    {
        Console.WriteLine("Invalid date entered. Please try again.");
    }
}





