namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            List<int> A = new List<int>() { 2, 1, 2 };
            int majority = sol.majorityElement(A);
            Console.WriteLine(majority);
        }
    }


    public class Solution
    {
        public int majorityElement(List<int> A)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            int n = A.Count;

            // Zliczanie liczby wystąpień każdego elementu w tablicy
            foreach (int num in A)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            // Wyszukiwanie elementu większościowego
            foreach (KeyValuePair<int, int> kvp in counts)
            {
                if (kvp.Value > n / 2)
                {
                    return kvp.Key;
                }
            }

            // Zwracanie -1, gdy nie ma elementu większościowego
            return -1;
        }
    }

}