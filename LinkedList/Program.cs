namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a linked list of integer type

            LinkedList<int> l1 = new LinkedList<int>();

            // Add all numbers from 1 to 10 to the beginning

            l1.AddFirst(1);
            l1.AddFirst(2);
            l1.AddFirst(3);
            l1.AddFirst(4);
            l1.AddFirst(5);
            l1.AddFirst(6);
            l1.AddFirst(7);
            l1.AddFirst(8);
            l1.AddFirst(9);
            l1.AddFirst(10);

            // Remove 3 elements from the beginning

            l1.RemoveFirst();
            l1.RemoveFirst();
            l1.RemoveFirst();

            // Print the elements of the list separated by a space

            foreach (int singleListElement in l1)
            {
                Console.WriteLine(singleListElement + " ");
            }

            // Remove 3 elements from the end

            l1.RemoveLast();
            l1.RemoveLast();
            l1.RemoveLast();

            // Print the elements of the list separated by a space

            foreach (int singleListElement in l1)
            {
                Console.WriteLine(singleListElement + " ");
            }

            // Find how many multiples of 3 are present in the list

            int multiplesOfThree = 0;

            foreach (int singleListelement in l1)
            {
                if (singleListelement % 3 == 0) multiplesOfThree++;
            }

            // Find the length of the list

            int lengthOfList = l1.Count;


            // Print the last element in the list

            Console.WriteLine(l1.Last.Value);
        }
    }
}