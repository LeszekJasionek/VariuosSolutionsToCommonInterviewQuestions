namespace GenericsInCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer.printArray(new string[6]) ;
        }
    }

    public static class Printer
    {
          public static void printArray<T>(T[] arr)
          {
            foreach(T t in arr)
            {
                Console.WriteLine(t);
            }
          }
    }
}