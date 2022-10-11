/*
Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"(x+y)*z = {(x+y)*z}, x*y + y*z = {x*y + y*z}") ;
    }
}
