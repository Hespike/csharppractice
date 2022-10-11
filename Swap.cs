/* Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5
*/

using System;

public class Exercise1
{
    public static void Main( )
    {
    int num1, num2, temp;
    
    num1 = int.Parse(Console.ReadLine());
    num2 = int.Parse(Console.ReadLine());
    
    temp = num1;
    num1 = num2;
    num2 = temp;
    Console.Write($"{num1} and {num2}");
         
    Console.Read();
    }
}
