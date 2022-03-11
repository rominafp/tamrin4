using System;
int month;
System.Console.WriteLine("enter month");
month=Convert.ToInt32(Console.ReadLine());
//ماه را دریافت کن
 
switch(month)
{
    case 1:
    System.Console.WriteLine("jan");
    break;

    case 2:
    System.Console.WriteLine("feb");
    break;

    case 3:
    System.Console.WriteLine("mar");
    break;

    case 4:
    System.Console.WriteLine("apr");
    break;

    case 5:
    System.Console.WriteLine("may");
    break;

    case 6:
    System.Console.WriteLine("june");
    break;

    case 7:
    System.Console.WriteLine("july");
    break;

    case 8:
    System.Console.WriteLine("agu");
    break;

    case 9:
    System.Console.WriteLine("sep");
    break;

    case 10:
    System.Console.WriteLine("oct");
    break;

    case 11:
    System.Console.WriteLine("nov");
    break;

    case 12:
    System.Console.WriteLine("dec");
    break;

    default:System.Console.WriteLine("nadarim");
    break;
}

