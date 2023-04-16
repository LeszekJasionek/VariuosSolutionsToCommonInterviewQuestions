namespace Queque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a queue of integer type

            Queue<int> queueOfIntegers = new Queue<int>();

            // Push the first 5 even numbers in the queue

            for(int i = 1; i <= 10; i++)
            {
                if(i % 2 == 0) queueOfIntegers.Enqueue(i);
            }

            // Push the first 5 odd numbers in the queue

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0) queueOfIntegers.Enqueue(i);
            }

            // Print the size of the queue

            Console.WriteLine(queueOfIntegers.Count);

            // Remove the oldest element of the olders

            queueOfIntegers.Dequeue();

            // Print the elements of the queue from oldest to newest
            // separated by space

            foreach(int elementOfQueue in queueOfIntegers)
            {
                Console.Write(elementOfQueue + " ");
            }

        }
    }
}