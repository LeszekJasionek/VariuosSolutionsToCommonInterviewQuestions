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
                // Wybieranie większej wartości spośród A[i] oraz sumy A[i] i aktualnej sumy
                currSum = Math.Max(A[i], currSum + A[i]);

                // Porównywanie maksymalnej sumy z aktualną sumą
                maxSum = Math.Max(maxSum, currSum);
            }

            // Zwracanie maksymalnej sumy
            return maxSum;
        }
    }


}