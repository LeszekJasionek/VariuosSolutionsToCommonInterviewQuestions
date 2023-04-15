namespace MaxSumContiguousSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            List<int> A1 = new List<int>() { 1, 2, 3, 4, -10 };
            List<int> A2 = new List<int>() { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(sol.maxSubArray(A1));
            Console.WriteLine(sol.maxSubArray(A2));
        }


    }

    public class Solution
    {
        public int maxSubArray(List<int> A)
        {
            int n = A.Count;
            int maxSum = A[0];
            int currSum = A[0];

            // PL : Iteracja przez każdy element listy
            // ENG : Iterate through each element of the list
            // NL : Itereren door elk element van een lijst

            for (int i = 1; i < n; i++)
            {
                // PL : Wybieranie większej wartości spośród A[i] oraz sumy A[i] i aktualnej sumy
                // ENG: Selecting the greater value between A[i] and the sum of A[i] and the current sum
                // NL : Het selecteren van de grotere waarde tussen A[i] en de som van A[i] en de huidige som

                currSum = Math.Max(A[i], currSum + A[i]);

                // PL : Porównywanie maksymalnej sumy z aktualną sumą
                // ENG : Comparing the maximum sum with the current sum
                // NL : Het vergelijken van de maximale som met de huidige som
                maxSum = Math.Max(maxSum, currSum);
            }

            // PL : Zwracanie maksymalnej sumy
            // ENG: Returning the maximum sum
            // NL : Het retourneren van de maximale som
            return maxSum;
        }
    }


}