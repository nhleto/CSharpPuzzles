using System;

namespace CSharpPuzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            var sol = new Solutions();
            // sol.SumZero(5);
            // sol.Shuffle("aiohn", new int[]{3, 1, 4, 2, 0});
            // sol.KidsWithCandies(new int[]{2,3,5,1,3}, 3);
            sol.LargeGroupPositions("abbxxxxzzy");
        }
    }
}
