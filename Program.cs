using System;

class program
{
    public static void Main(string[] args)
    {
        // Addition
        Console.WriteLine("Provide 1 number to perform the addition operation");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to add to " + num);
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Alright! That's easy " + num + " + " + num2 + " is " + (num + num2));

        // Subtration
        Console.WriteLine("Provide 1 number to perform the subtraction operation");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to subtract to " + num3);
        int num4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Alright! That's easy " + num3 + " - " + num4 + " is " + (num3 - num4));

        // Multiplication
        Console.WriteLine("Provide 1 number to perform the multiplication operation");
        int num5 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to subtract to " + num5);
        int num6 = int.Parse(Console.ReadLine());
        Console.WriteLine("Alright! That's easy " + num5 + " * " + num6 + " is " + (num5 * num6));
        
        // Integer Division
        Console.WriteLine("Provide 1 number to perform the Divition operation");
        int num7 = int.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to subtract to " + num7);
        int num8 = int.Parse(Console.ReadLine());
        Console.WriteLine("Alright! That's easy " + num7 + " / " + num8 + " is " + (num7 / num8));

        // Decimal
        Console.WriteLine("Provide 1 number to perform the Decimal operation");
        float num9 = float.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to subtract to " + num9);
        float num10 = float.Parse(Console.ReadLine());
        Console.WriteLine("Alright! That's easy " + num9 + " / " + num10 + " is " + (num9 / num10));

        // Modulus
        Console.WriteLine("Provide 1 number to perform the Modulus operation");
        float num11 = float.Parse(Console.ReadLine());
        Console.WriteLine("Provide a number to subtract to " + num11);
        float num12 = float.Parse(Console.ReadLine());
        Console.WriteLine("Alright! That's easy " + num11 + " % " + num12 + " is " + (num11 % num12));
    }
}