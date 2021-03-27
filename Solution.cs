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

        // public void LargeGroupPositions(string s)
        // {
        //     // List<int> ans = new List<int>();

        //     // for (int i = 0; i < s.Length; i++)
        //     // {
        //     //     if (i < s.Length && s[i].Equals(s[i + 1]))
        //     //     {
        //     //         ans.Add(i);
        //     //     }
        //     // }
        // }

        public bool StartsWith(string str, string ending)
        {
            if (str.EndsWith(ending))
            {
                return true;
            }
            return false;
        }

        public void ToCamelCase(string str)
        {
            List<char> list = new List<char>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '-')
                {
                    list.Add(char.ToUpper(str[i + 1]));
                }
                else if ((str[i]) != '-' && !char.IsUpper(str[0]))
                {
                    if (char.IsUpper(str[i - 1]))
                    {
                        continue;
                    }
                    else
                    {
                        list.Add(str[i]);
                    }
                }
            }
        }

        public string CreatePhoneNumber(int[] numbers)
        {
            var AreaCode = numbers.Skip(0).Take(3).ToString();
            var FirstThree = numbers.Skip(3).Take(6).ToString();
            var LastFour = numbers.Skip(6).Take(10).ToString();
            var q =  $"({AreaCode}) {FirstThree}-{LastFour}";
            return q;
        }

        public string FakeBin(string x)
        {
            var list = new List<int>();
            foreach (var i in x)
            {
                if (i < 5)
                {
                    list.Add(0);
                }
                else if (i >= 5)
                {
                    list.Add(5);
                }
            }
            return list.ToString();
        }
    }
}