/* 
Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
*/

using System;

public class Exercise1
{
    public static void Main( )
    {
            int num1, num2, num3;
    
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());

            Console.Write(num1 * num2 * num3);
            Console.Read();
    }
}
