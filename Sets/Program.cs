namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a sorted set of integer type

            SortedSet<int> sortedSet= new SortedSet<int>();

            // Add all even numbers from 1 to 15

            for(int i = 1; i <= 15; i++) 
            {
                if(i % 2 != 0 ) sortedSet.Add(i);
            }

            // Remove the largest element

            sortedSet.Remove(sortedSet.Max);

            // Remove the 2nd smallest element

            if (sortedSet.Count > 1) sortedSet.Remove(sortedSet.ElementAt(1));
            


            // Insert first 5 odd numbers

            for(int i = 1; i <= 9; i+=2)
            {
                sortedSet.Add(i);
            }

            // Print the elements of the set separated by a space

            foreach(int singleElementOfSortedList in sortedSet)
            {
                Console.WriteLine(singleElementOfSortedList + " ");
            }

            // Print the size of the set

            Console.WriteLine(sortedSet.Count);
        }
    }
}