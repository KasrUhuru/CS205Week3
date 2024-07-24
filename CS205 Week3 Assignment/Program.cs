using System;

namespace CS205Week3
{
    public class Program
    {
        public static bool isAbecedarian(string word)
        {
            // Assume the word is abecedarian until proven false
            bool ABC = true;

            // Input @word is used to create a char[] array
            char[] charArray = word.ToCharArray();

            // Compare current character with previous character using Unicode values
            for (int i = 1; i < charArray.Length; i++)
            {
                if (charArray[i] < charArray[i - 1])
                {
                    ABC = false;
                    break;
                }
            }

            return ABC;
        }

        static void Main(string[] args)
        {
            /// Exercise 7.10
            // This program will determine if a word is abecedarian
            // The 6-letter word will be broken into a CHAR array
            // While array[n] is greater than or equal to array[n-1], the loop continues
            // BOOL variable @abecedarian will be initialized as TRUE and will be set to FALSE
            // if the condition is broken

            // word1 is abecedarian
            string word1 = "abdest";

            // word2 is not
            string word2 = "zealot";

            // Should return TRUE
            Console.WriteLine(isAbecedarian(word1));

            // Should return FALSE
            Console.WriteLine(isAbecedarian(word2));

            /// Exercise 5.7
            // This program will read a text file and output to another text file
            // Utilizes StreamWriter and StreamReader and Command-Line Arguments
            // Insert line numbers after each EOL in the output text file
            // Check if the correct number of arguments are passed

            /// Exercise 9.3
            // This program will be a class definition to create rational numbers
            // Problem 2
            Rational r1 = new Rational();
            // Problem 3
            r1.WriteRational();
            // Problem 4, Problem 6
            Rational @pi = new Rational(355, 133);
            @pi.WriteRational();
            // Problem 7
            @pi.Negate();
            @pi.WriteRational();
            // Problem 8
            @pi.Invert();
            @pi.WriteRational();
            // Problem 9
            Console.WriteLine(@pi.ToDouble());

            // Problem 10
            Rational reducedPi = @pi.Reduce();
            reducedPi.WriteRational();

            // Problem 11
            Rational r2 = new Rational(2, 3);
            Rational sum = @pi.Add(r2);
            sum.WriteRational();

            /// Exercise 13.4
            // 
            // Prompt 3a. Which is more concise (usually)?
            // A: The instance methods are much more concise as compared to static methods
            //
            // Prompt 3b. Which is a more natural way to express computation?
            // A: The instance syntax for computation feels more tactile and satisfying.
            // A: Something about using a .method() with empty parenthesis indicates to me a certain
            // A: level of elegance and flexibility. This is a very arbitrary observation, of course.
        }
    }
}
