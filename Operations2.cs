/* 
Write a C# Sharp program to print on screen the output of adding, subtracting, 
multiplying and dividing of two numbers which will be entered by the user.
*/

using System;

public class Exercise1
{
    public static void Main( )
    {
        int num1, num2;
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
   
        Console.WriteLine($"Összeadás: {num1 + num2}");
        Console.WriteLine($"Kivonás: {num1 - num2}");
        Console.WriteLine($"Szorzás: {num1 * num2}");
        Console.WriteLine($"Osztás: {num1 / num2}");
        Console.WriteLine($"Maradék: {num1 % num2}");
    }
}
