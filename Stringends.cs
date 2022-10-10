/*
Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).
*/

public class Kata
{
  public static bool Solution(string str, string ending){
  if(str.Length < ending.Length){
    return false;
  }
  
  if(str.Substring( str.Length - ending.Length, ending.Length) == ending)
    {
      return true ;
        } else {
      return false;
    }
  }
}
