using System;

public class ExponentHandler
{
    public static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        
        if(integer>0){
            if(integer%2 == 0){
                double newInteger = Math.Pow(integer,2) + 10;
                Console.WriteLine("The number is even");
                Console.WriteLine($"{newInteger}");
            }
            else{
                double newInteger = Math.Pow(integer,3) + 10;
                Console.WriteLine("The number is odd");
                Console.WriteLine($"{newInteger}");
            }
        }
        else if (integer<0){
            Console.Write("Enter another integer: ");
            int anohterInteger = int.Parse(Console.ReadLine());
            double newInteger = Math.Pow(integer, anohterInteger)+ 10;
            Console.WriteLine($"{newInteger}");
        }
        else{
            Console.WriteLine("Nothing Happened.");
        }

    }
}
