// CS Program to find sum of digits
using System;

public class SumOfDigits
{
    public static void Main(string[] args)
    {
        int num, sum=0;
        Console.WriteLine("Enter a number : ");
        num = int.Parse(Console.ReadLine());
        while(num>0)
        {
            int select = num%10;
            sum+=select;
            num/=10;
        }
        
        Console.WriteLine("Sum is "+sum);
    }
}