/*
Write a C# Sharp program that takes four numbers as input to calculate and print the average.
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());
        int num4 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine((num1 + num2 + num3 + num4) / 4);
    }
}
