namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a list of integer type

            List<int> list = new List<int>();

            // Add all numbers from 1 to 10 to the end

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            // Remove element from the beginning

            list.RemoveAt(0);

            // Remove 8 from the list

            list.Remove(8);

            // Insert 4 at the 1st index

            list.Insert(1, 4);

            // Print the elements of the list separated by a space

            foreach (int singleElementOfList in list)
            {
                Console.Write(singleElementOfList + " ");
            }
            Console.WriteLine();
            // Reverse the list

            list.Reverse();

            // Print the elements of the list separated by a space

            foreach (int singleElementOfList in list)
            {
                Console.Write(singleElementOfList + " ");
            }
            Console.WriteLine();

            // Sort the list

            list.Sort();

            // Print the elements of the list separated by a space

            foreach (int singleElementOfList in list)
            {
                Console.Write(singleElementOfList + " ");
            }
        }
    }
}