namespace BalancedParantheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int IsBalancedParentheses(string A)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in A)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            if(stack.Count == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}