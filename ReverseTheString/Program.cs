namespace ReverseTheString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SolutionReverseTheString sol = new SolutionReverseTheString();
            Console.WriteLine(sol.ReverseTheString("hallo world reversed"));
        }
    }


    public class SolutionReverseTheString
    {
        public string ReverseTheString(string randomString)
        {
            string[] words = randomString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            return string.Join(" ", words);
        }
    }


}