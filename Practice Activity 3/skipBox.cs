using System;

public class CurrencyConverter
{
    public static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("Enter y: ");
        int skip = int.Parse(Console.ReadLine());
        
        for (int i = 1; i <=row; i++){
            for (int j = 1; j<=row; j++){
                if (i==skip){
                    break;
                }
                else{
                    Console.Write("*");
                }
            }
            Console.WriteLine("");
        }
    }
}