using System;
namespace PalindromeExercise
{
	public class WordSmith
	{
		public static bool IsAPalindrome(string args)
		{
            
            string input = new string(Array.FindAll(args.ToLower().ToCharArray(), char.IsLetterOrDigit));

            
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }

            return true; 
        }
	}
}

