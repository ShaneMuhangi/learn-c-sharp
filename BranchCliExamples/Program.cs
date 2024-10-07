using System.ComponentModel;

namespace LearnCSharp;

/// <summary>
/// Question 1 <br/>
/// Write a program that requests a company’s Revenue and Expenditure for the year as input and displays a message indicating:<br/> 
/// - The loss and the amount of the loss if the expenditure exceeds the revenue <br/>
/// - The profit and the amount of the profit if the revenue exceeds the expenditure <br/>
/// - That the company has broken even otherwise<br/>
/// </summary>
internal class Program
{
    /// <summary>
    /// Main Method
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Enter the company's Revenue for the the year");
        int revenue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company's Expenditure for the year");
        int expenditure = int.Parse(Console.ReadLine());
        int profit = revenue - expenditure;

        if (revenue > expenditure)
            Console.WriteLine($"Company has a profit of {profit}");
        else if (revenue < expenditure)
            Console.WriteLine($"Company has a loss of {profit}");
        else
            Console.WriteLine($"Company has a break even of {profit}");


        Console.WriteLine("Please hit enter to exit");
        Console.ReadLine();
    }
}
