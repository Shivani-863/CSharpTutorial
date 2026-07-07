using System;
public class ConditionalStatements
{
    public void IfElseExample()
    {
        int number=10;
        if (number>0)
        {
            Console.WriteLine($"{number} is a positive number.");
        }
        else if (number<0)
        {
            Console.WriteLine($"{number} is a negative number.");
        }
        else
        {
            Console.WriteLine($"{number} is zero.");
        }
    }

    public void SwitchCaseExample()
    {
        int day=3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }

    public void TernaryOperatorExample()
    {
        int age=18;
        string eligibility=age>=18?"Eligible to vote":"Not eligible to vote";
        Console.WriteLine(eligibility);
    }
}