/*
Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You look older than {age}.") ;
    }
}
