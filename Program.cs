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
            // sol.LargeGroupPositions("abbxxxxzzy");
            // int[] p = { 1, 2, 3 };
            // sol.MaximumWealth(new int[][] { p, p });
            // sol.StartsWith("samurai", "ai");
            // sol.ToCamelCase("the-stealth-warrior");
            sol.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0});
            sol.FakeBin("50001223567");
        }
    }
}
