using System;

public class ReverseNumber
{
    public static void Main(string [] args)
    {
        int num, reverse=0;
        Console.WriteLine("Enter a number : ");
        num = int.Parse(Console.ReadLine());

        while(num>0)
        {
            int select = num%10;

            reverse = reverse * 10 + select;
            num/=10;

            Console.WriteLine(reverse);
        }

        Console.WriteLine("Reverse num : "+reverse);

        
    }
}