using System;

public class GotoUse
{
    public static void Main(string [] args)
    {
        int n;
        Console.WriteLine("Enter number = ");
        n = int.Parse(Console.ReadLine());
        int sum = 0;
        int i=1;

        add:
            sum+=i;
            i++;
            if(i<=10)
            {
                goto add;
            }

        Console.WriteLine(sum);



    }
}