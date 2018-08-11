using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Balanced_Parenthesis
    {
        static bool IsMatching(char open, char close)
        {
            if (open == '(' && close == ')')
            {
                return true;
            }

            else if (open == '{' && close == '}')
            {
                return true;
            }

            else if (open == '<' && close == '>')
            {
                return true;
            }

            else if (open == '[' && close == ']')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AreParenthiesBalanced(char[] exp)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[' || exp[i] == '<')
                {
                    stack.Push(exp[i]);
                }
                if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']' || exp[i] == '>')
                {
                    if (stack.Count() == 0)
                    {
                        return false;
                    }

                    else if (!IsMatching(stack.Pop(), exp[i]))
                    {
                        return false;
                    }
                }
            }

            if (stack.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
