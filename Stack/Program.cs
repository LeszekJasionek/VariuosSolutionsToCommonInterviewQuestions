using System.Net;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare a stack of integer type

            Stack<int> stackOfIntegers = new Stack<int>();

            // Push the first 5 even numbers in the stack

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    stackOfIntegers.Push(i);
                }
            }

            // Push the first 5 odd numbers in the stack

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    stackOfIntegers.Push(i);
                }
            }


            // Print the size of the stack

            Console.WriteLine(stackOfIntegers.Count);

            // Remove the top most element of the stack

            stackOfIntegers.Pop();

            // Print the elements of the stack from top to bottom
            // separated by space

            foreach (int elementOfStack in stackOfIntegers)
            {
                Console.Write(elementOfStack + " ");
            }


        }
    }
}