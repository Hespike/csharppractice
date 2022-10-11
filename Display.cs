/*
Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces),
and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
*/
using System;
public class Exercise12
{
    public static void Main()
    {
        int num; 
  
        Console.WriteLine("Enter a digit: ");
        num = Convert.ToInt32( Console.ReadLine() );
  
        Console.Write( num );
        Console.Write(" ");
        Console.Write( num );
        Console.Write(" ");
        Console.Write( num );
        Console.Write(" ");
        Console.Write( num );
        Console.WriteLine();
  
        Console.Write( num );
        Console.Write( num );
        Console.Write( num );
        Console.WriteLine( num );
        Console.WriteLine();
  
        Console.WriteLine("{0} {0} {0} {0}", num);
  
        Console.WriteLine("{0}{0}{0}{0}", num);
   }
}
