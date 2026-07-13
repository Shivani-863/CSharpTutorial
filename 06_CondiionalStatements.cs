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

    public void movieTicketElligibility()
    {
        Console.WriteLine("Enter your name:");
        string name=Console.ReadLine();
        Console.WriteLine("Enter your age:");
        string input=Console.ReadLine();
        bool isValidAge=int.TryParse(input, out int age);
        if(isValidAge)
        {
            if (age>=18)
            {
                Console.WriteLine($"Hello {name}, you can watch an adult movie.");
            }
            else
            {
                Console.WriteLine($"Hello {name}, you can only watch U/A or U rated movies.");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid age.");
        }
    }
}