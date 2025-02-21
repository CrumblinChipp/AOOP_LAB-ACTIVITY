using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter amount in USD: ");
        double firstAmount = double.Parse(Console.ReadLine());
        Console.Write("Enter Exchange rate from USd to EUR: ");
        double rateExchange = double.Parse(Console.ReadLine());
        double exchange = firstAmount*rateExchange;
        
        Console.WriteLine("Amount in EUR: {0:F2}", exchange);
    }
}