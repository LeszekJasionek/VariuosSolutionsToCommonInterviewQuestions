namespace DictionaryInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            for (int i = 0; i < 10; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());

            // Declare a dictionary of integer type
            Dictionary<int, int> dict = new Dictionary<int, int>();

            // Count the frequency of all the elements
            for (int i = 0; i < 10; i++)
            {
                if (dict.ContainsKey(A[i]))
                    dict[A[i]]++;
                else dict.Add(A[i], 1);
            }

            // Print the element with the largest frequency
            int ele = 0, max = 0;
            foreach (int x in dict.Keys)
            {
                if (dict[x] > max)
                {
                    max = dict[x];
                    ele = x;
                }
            }
            Console.WriteLine(ele);

            // Print the smallest element in the array
            int min = int.MaxValue;
            foreach (int x in dict.Keys)
            {
                if (x < min)
                {
                    min = x;
                }
            }
            Console.WriteLine(min);

            // Print the values present present in the dictionary separated by a space
            foreach (int x in dict.Values)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();
        }
    }
}