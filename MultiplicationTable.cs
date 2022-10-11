/* 
Write a C# Sharp program that takes a number as input and print its multiplication table.
*/

using System;

public class Exercise1
{
    public static void Main( )
    {
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(num * i);
            }
    }
}
