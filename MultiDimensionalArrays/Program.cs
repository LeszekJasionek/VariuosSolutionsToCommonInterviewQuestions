namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            column_sum(new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 1, 3, 4 } });

            static void column_sum(int[,] arr)
            {

                int rows = arr.GetLength(0);
                int cols = arr.GetLength(1);

                for (int i = 0; i < cols; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < rows; j++)
                    {
                        sum += arr[j, i];
                    }
                    Console.Write(sum + " ");
                }
                Console.WriteLine();
            }
        }
    }
}