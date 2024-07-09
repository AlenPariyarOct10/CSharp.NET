// C# Program to find factorial of any number

using System;

public class FindFactorial
{
    public static void Main(string[] args)
    {
        int num, factorial=1;
        Console.WriteLine("Enter a number : ");
        num = int.Parse(Console.ReadLine());
        
        int i =1;
        while(i<=num)
        {
            factorial *= i;
            i++;
        }
        
        Console.WriteLine(factorial);
    }
}