using System.Collections.Generic;
using System.Linq;

namespace CSharpPuzzles
{
    public class Solutions
    {
        public int[] SumZero(int n)
        {
            List<int> res = new List<int>();
            
            if(n % 2 == 1)
            {
                res.Add(0);
            }
            
            for(int i = 1; i < n ; i+=2)
            {
                res.Add(i);
                res.Add(-i);
            }
            
            return res.ToArray();
        }

        public string Shuffle(string s, int[] indices)
        {
            char[] CharArr = s.ToCharArray();
            var ans = new List<char>();
            foreach (var index in indices)
            {
                ans.Add(CharArr[index]);
            }
            var answer = string.Join("", ans);
            return answer;
        }

        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            int max = candies.Max();
            var ans = new List<bool>();
            foreach (var candy in candies)
            {
                if (candy + extraCandies >= max)
                {
                    ans.Add(true);
                }
                else
                {
                    ans.Add(false);
                }
            }
            return ans;
        }

        public void LargeGroupPositions(string s)
        {
            List<int> ans = new List<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length && s[i].Equals(s[i + 1]))
                {
                    ans.Add(i);
                }
            }
        }
    }
}