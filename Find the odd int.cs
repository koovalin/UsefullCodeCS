// My Code
namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        int c = 0;
        for (int i = 0; i < seq.Length; i++){
            int temp = seq[i];
            int counter = 0;
            for (int j = 0; j < seq.Length; j++){
                if (seq[j] == temp)
                    counter++;
            }
            if (counter % 2 != 0)
            c = temp;
        }
      return c;
      }
       
    }
}


// Better code 1

using System.Linq;

namespace Solution
{
  class Kata
    {
      public static int find_it(int[] seq) 
      {
        return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
      }
    }
}


// Better code 2

namespace Solution
{
  class Kata
  {
        public static int find_it(int[] seq)
        {
            int found = 0;

            foreach (var num in seq)
            {
                found ^= num;
            }

            return found;
        }
  }
}

// Better code 3

using System;
using System.Linq;

namespace Solution
{
  class Kata
    {
		public static int find_it(int[] seq)
		{
        return seq.ToList()
                  .GroupBy(x => x) //Group by each element in the array
                  .Where(x => (x.Count() % 2) != 0) //Find grouped odd numbers
                  .Select(x => x.First())
                  .FirstOrDefault(); //since array will only contain 1 odd number, get first one
	    }
       
    }
}

// Better code 4
using System.Linq;


namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
        return  seq.First(x => seq.Count(s => s == x) % 2 == 1);
      }
       
    }
}
