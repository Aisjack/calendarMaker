Console.Write("Please provide a year: ");
string? yearProvided = Console.ReadLine();

int yearProvidedToInt = Int32.Parse(yearProvided);
int monthsInAYear = 12;
int daysInAWeek = 7;



for(int currentMonth = 1; currentMonth <= monthsInAYear; currentMonth++)
{
    switch(currentMonth)
    {
        case 1:
        Console.WriteLine("January");
        break;
        case 2:
        Console.WriteLine("February");
        break;
        case 3:
        Console.WriteLine("March");
        break;
        case 4:
        Console.WriteLine("April");
        break;
        case 5:
        Console.WriteLine("May");
        break;
        case 6:
        Console.WriteLine("June");
        break;
        case 7:
        Console.WriteLine("July");
        break;
        case 8:
        Console.WriteLine("August");
        break;
        case 9:
        Console.WriteLine("September");
        break;
        case 10:
        Console.WriteLine("October");
        break;
        case 11:
        Console.WriteLine("November");
        break;
        case 12:
        Console.WriteLine("December");
        break;
    }

    int numberOfDaysInCurrentMonth = DateTime.DaysInMonth(yearProvidedToInt, currentMonth);
    int i = 0;

    DateTime dt = new DateTime(yearProvidedToInt, currentMonth, 1);
    var dayOfWeek = dt.DayOfWeek.ToString("d");
    int dayOfWeekToInt = Int32.Parse(dayOfWeek);

    for(int currentDayInMonth = 1 - dayOfWeekToInt; currentDayInMonth <= numberOfDaysInCurrentMonth; currentDayInMonth++)
    {
        if(currentDayInMonth >= numberOfDaysInCurrentMonth)
        {
            i = 0;
        }
        else if(i == 0)
        {
           i++;
            Console.WriteLine(" S    M    T    W    TH   F   ST");
        }
        if(currentDayInMonth <= 0)
        {
            i++;
            Console.Write($"     ");
        }
        else if(i < daysInAWeek)
        {
            i++;
            if(currentDayInMonth >= numberOfDaysInCurrentMonth)
            {
                Console.WriteLine("");
                Console.WriteLine("");
            }
            else if(currentDayInMonth > 9)
            {
                Console.Write($"{currentDayInMonth}   ");
            }
            else
            {
                Console.Write($"{currentDayInMonth}    ");
            }
        }
        else
        {
            Console.WriteLine($"{currentDayInMonth}    ");
            i = 1;
        }
    }   
}

