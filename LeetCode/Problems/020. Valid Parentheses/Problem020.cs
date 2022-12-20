using System.Collections.Generic;

namespace Problems._020._Valid_Parentheses
{
    public class Problem020
    {
        private readonly Dictionary<char, char> _parenthesesLookUp = new Dictionary<char, char>()
        {
            {'[',']'},
            {'{','}'},
            {'(',')'},
        };

        public bool IsValid(string s)
        {
            var stack = new Stack<char>(0);
            
            foreach (var charWord in s)
            {
                if (stack.Count > 0 && GetAnotherParentheses(stack.Peek()) == charWord)
                {
                    var popWord = stack.Pop();
                }
                else
                {
                    stack.Push(charWord);
                }
            }

            return stack.Count <= 0;
        }

        private char GetAnotherParentheses(char key)
        {
            return _parenthesesLookUp.TryGetValue(key, out var value) ? value : new char();
        }
    }
}