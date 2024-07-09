using System;

public class FirstNOdds
{
    public static void Main(string [] args)
    {
        int n, sum=0;

        Console.WriteLine("Enter n : ");
        n = int.Parse(Console.ReadLine());

        for(int i=1;i<=2*n;i+=2)
        {
            sum+=i;
        }

        Console.WriteLine("Sum of odds : "+sum);
        Console.ReadLine();
    }
}