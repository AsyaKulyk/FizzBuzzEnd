/* method ReplacementToFizz replaces every third word in the LineText to Fizz
 * The function takes and returns after changes
 * string LineText 
 *
 * byte WordCounter - this variable counts spaces before which there are words;
 * int LetterCounter - this variable counts letters in words. After finding a new space, the previous account is reset to zero;
 * int i - this variable what is the index.
 
  
 * method ReplacementToBuzz replaces every fifth letter in the BLineText to Buzz:
 * The function takes and returns after changes
 * string BLineText 
 * 
 * byte LetterFCounter - this variable counts letters;
 * int i - this variable what is the index.
 

 * class FizzBuzzDetector contains method getOverlappings. 
 * 
 * Method getOverlappings takes
 * string param;
 * 
 * and returns the number of occurrences of the word Fizz
 * byte Counter.
 *
 *
 * int i - this variable what is the index.
 

 * Method InputValidation enters a string. It does not allow forbidden characters in the result. 
 * Doesn't let the user go until he has entered at least 7 characters, and limits the input to 100 characters
 * Method return variable
 * string result
 * 
 * ConsoleKeyInfo key;
 
 *Main program
 *string Line - this variable takes on the value that the user enters, and then accepts all changes to the functions
 *int number - this variable takes the result of the function getOverlappings
 *FizzBuzzDetector ob - This variable stores an object of the class. With which you can refer to the method getOverlappings
 */

using System;

namespace FizzBuzz
{
    public class FizzBuzzClass

    {
        public static string ReplacementToFizz(string LineText)     //replaces every third word in the LineText to Fizz
        {
            LineText = String.Concat(LineText + ' ');
            byte WordCounter = 0;
            int LetterCounter = 0;
            for (int i = 0; i < LineText.Length; i++)
            {
                if (LineText[i] != ' ')
                    LetterCounter++;
                else if (LetterCounter > 0)     //checking if a word is before a space
                {
                    if (WordCounter == 2)
                    {
                        LineText = LineText.Remove(i - LetterCounter, LetterCounter);
                        LineText = LineText.Insert(i - LetterCounter, "Fizz");
                        WordCounter = 0;
                        i = i - LetterCounter + 4;
                    }
                    else WordCounter++;
                    LetterCounter = 0;
                }
            }
            LineText = LineText.Remove(LineText.Length - 1, 1);
            return LineText;
        }

        public static string ReplacementToBuzz(string BLineText)     //replaces every fifth letter in the BLineText to Buzz
        {
            byte LetterFCounter = 0;
            for (int i = 0; i < BLineText.Length; i++)
            {
                if (BLineText[i] != ' ')    //find the letter
                {
                    LetterFCounter++;
                    if (LetterFCounter == 5)    //check the order of the letter
                    {
                        LetterFCounter = 0;
                        BLineText = BLineText.Remove(i, 1);
                        BLineText = BLineText.Insert(i, "Buzz");
                        i = i + 4;
                    }
                }
            }
            return BLineText;
        }

        public class FizzBuzzDetector       // returns the number of occurrences of the word Fizz
        {
            public int getOverlappings(string param)
            {
                byte Counter = 0;
                param = String.Concat(param, ' ');
                for (int i = 0; i < param.Length - 5; i++)
                {
                    if (String.Concat(param[i], param[i + 1], param[i + 2], param[i + 3], param[i + 4], param[i + 5]) == " Fizz ")
                    {
                        Counter++;
                    }
                }
                return Counter;
            }
        }

        public static string InputValidation()
        {
            string result = "";
            while (result.Length < 101)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Backspace:
                        if (result.Length > 0)
                        {
                            result = result.Remove(result.Length - 1, 1);
                            Console.Write(key.KeyChar + " " + key.KeyChar);
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (result.Length > 6)
                        {
                            Console.WriteLine();
                            return result;
                        }
                        break;
                    default:
                        if ((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar == ' '))
                        {
                            Console.Write(key.KeyChar);
                            result += key.KeyChar;
                        }
                        break;
                }
            }
            if (result.Length > 6)
            {
                InputValidation();
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Let's start the game.");
            Console.WriteLine("Write me a sentence with only lowercase letters a-z and spaces.");
            Console.WriteLine("More than 7 characters, but less than 100.");

            Console.WriteLine("You could accidentally press the wrong button.'");
            Console.WriteLine("Therefore, let me help. When you press the wrong button, I will not bring it to the screen.");

            string Line = InputValidation();
            Line = ReplacementToFizz(Line);
            Console.WriteLine(Line);
            Line = ReplacementToBuzz(Line);
            Console.WriteLine(Line);
            FizzBuzzDetector ob = new FizzBuzzDetector();
            int number = ob.getOverlappings(Line);
            Console.WriteLine(number);
        }
    }
}
