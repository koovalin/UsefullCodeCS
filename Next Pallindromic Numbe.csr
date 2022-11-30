// Слудющий ближайший паллиндром после числа.

using System.Linq;

public class Kata
{
  public static int NextPal(int val)
  {
    do
    {
      val++;
    }
    while(val.ToString() != string.Concat(val.ToString().Reverse()));
    
    return val;
  }
}
