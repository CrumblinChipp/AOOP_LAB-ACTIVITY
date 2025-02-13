using System;
public class alternatingChars{
    public static void Main(){
        Console.Write("First Character: ");
        char first = char.Parse(Console.ReadLine());
        Console.Write("Second Character: ");
        char second = char.Parse(Console.ReadLine());
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 1; i<=size;i++){
            for(int j=1;j<i;j++){
                Console.Write("-");
            }
            if (i%2==1){
                Console.WriteLine($"{first}");
            }
            else{
                Console.WriteLine($"{second}");
            }
        }
    }
}