namespace LearnCSharp;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the company's Revenue for the the year");
        int revenue = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company's Expenditure for the year");
        int expenditure = int.Parse(Console.ReadLine());
        int profit = revenue - expenditure;

        if (revenue > expenditure)
            Console.WriteLine("Company has a profit of " + profit);
        else if (revenue < expenditure)
            Console.WriteLine("Company has a loss of " + profit);
        else
            Console.WriteLine("Company has a break even of " + profit);


        Console.WriteLine("Please hit enter to exit");
        Console.ReadLine();
    }
}
