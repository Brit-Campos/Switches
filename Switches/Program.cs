// switch = an efficient alternative to many else if statements

Console.WriteLine("What day is it today?");
String day = Console.ReadLine();

switch(day)
{
    case "Monday":
        Console.WriteLine("It's Monday!");
        break;
    case "Tuesday":
        Console.WriteLine("It's Monday!");
        break;
    case "Wednesday":
        Console.WriteLine("It's Monday!");
        break;
    case "Thursday":
        Console.WriteLine("It's Monday!");
        break;
    case "Friday":
        Console.WriteLine("It's Monday!");
        break;
    case "Saturday":
        Console.WriteLine("It's Monday!");
        break;
    case "Sunday":
        Console.WriteLine("It's Monday!");
        break;
    default:
        Console.WriteLine(day + "is not a day!");
        break;
}

Console.ReadKey();
