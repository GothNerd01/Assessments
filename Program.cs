using System;
using System.Linq;

public class Assessment
{
    static public void Main()
    {
        string duplicateCheck(string usersText)
        {
            string duplicates = string.Empty;
            var removByOne = string.Empty;

            for (int i = 0; i < usersText.Length; i++)
            {
                removByOne = usersText.Remove(0, i + 1);
                if (removByOne.Contains(usersText[i]))
                    if (!duplicates.Contains(usersText[i]))
                        duplicates += usersText[i];
            }

            return  duplicates;
        }

        int countVowels(string usersText)
        {
            int count = 0;

            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            count = usersText.Count(c => vowels.Contains(c));

            return count;
        }

        string vowelsCheck(string usersText)
        {
            int countVowel, countConsonant = 0;
            string result;

            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

            countVowel = usersText.Count(c => vowels.Contains(c));
            countConsonant = usersText.Count(c => !vowels.Contains(c));

            if (countVowel > countConsonant)
                result = "greater";
            else if (countVowel < countConsonant)
                result = "less";
            else
                result = "equal";

            return result;
        }

        string finalResult = string.Empty;
        string userInput = string.Empty;
        string userText = string.Empty;
        int count = 0;

        Console.WriteLine("Enter text to be analysed:");
        userText = Console.ReadLine().ToLower();

        if (!string.IsNullOrEmpty(userText))
        {
            Console.WriteLine("Enter which operations to do on the supplied text:");
            Console.WriteLine("'1' for a duplicate character check");
            Console.WriteLine("'2' to count the number of vowels");
            Console.WriteLine("'3' to check if there are more vowels or non vowels");
            Console.WriteLine("Any combination of '1', '2' and '3' to perform multiple checks");
            userInput = Console.ReadLine().ToLower();

            if (!String.IsNullOrEmpty(userInput))
            {
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (userInput[i] == '1')
                    {
                        finalResult = duplicateCheck(userText);

                        if(!String.IsNullOrEmpty(finalResult))
                            Console.WriteLine("\nFound the following duplicates: " + finalResult);
                        else
                            Console.WriteLine("\nNo duplicate values were found");
                    }
                    else if (userInput[i] == '2')
                    {
                        count = countVowels(userText);

                        if (count > 0)
                            Console.WriteLine("\nThe number of vowels is " + count);
                        else
                            Console.WriteLine("\nNo vowels were found");
                        
                    }
                    else if (userInput[i] == '3')
                    {
                        finalResult = vowelsCheck(userText);
                        
                        if (finalResult == "greater")
                            Console.WriteLine("\nThe text has more vowels than non vowels");
                        else if(finalResult == "less")
                            Console.WriteLine("\nThe text has more non vowels than vowels");
                        else
                            Console.WriteLine("\nThe text has an equal amount of vowels and non vowels");
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter the correct option");
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid text entered.");
        }

    }
}