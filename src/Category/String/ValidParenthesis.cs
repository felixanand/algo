// 20 https://leetcode.com/problems/valid-parentheses/

//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.

using System;
using System.Collections.Generic;

	public class ValidParenthesis
	{
		public void Run()
		{
			var input = "){";
			Console.WriteLine(IsValid(input));
		}

		public bool IsValid(string s)
        {
			if (s.Length < 2) return false;

			var data = new Stack<char>();

			foreach(char c in s)
            {
				if (c == '{' || c == '[' || c == '(')
                {
					data.Push(c);
				}
				else if ((c == '}' || c == ']' || c == ')') && data.Count > 0)
                {

				var preD = data.Peek();

				if ((preD == '{' && c == '}') || (preD == '[' && c == ']') || (preD == '(' && c == ')'))
                    {
						data.Pop();
                    }
					else
                    {
						return false;
                    }
				}
				else
            {
				return false;
            }
			}

		if (data.Count == 0) return true;

			return false;
    }

}

