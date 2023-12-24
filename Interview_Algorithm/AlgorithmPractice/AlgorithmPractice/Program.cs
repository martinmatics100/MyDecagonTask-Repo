using System.ComponentModel;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Revering a string
            string reverse = "The boy is good";
            Console.WriteLine(ReverseString(reverse));

            //Palidrome
            string pal = "racecar";
            bool palidrone = isPalidrome(pal);

            if (palidrone)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }


            //Anagram
            string str1 = "listen";
            string str2 = "silent";

            bool areAnagrams = AreAnagrams(str1, str2);

            Console.WriteLine(areAnagrams
                ? $"{str1} and {str2} are anagrams."
                : $"{str1} and {str2} are not anagrams.");



            //Compressed string
            string input = "aabcccccaaa";
            string compressed = CompressString(input);
            Console.WriteLine("Original String: " + input);
            Console.WriteLine("Compressed String: " + compressed);


            //Return Unique values from an array

            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 4, 5, 6, 7, 8 };

            int[] uniqueValues = GetUniqueValues(arr1, arr2);

            Console.WriteLine("Unique Values: " + string.Join(", ", uniqueValues));


            //String Rotation:
            //Write a C# function that checks if one string is a
            //rotation of another string. For example, "waterbottle" is a rotation of "erbottlewat."

            string string1 = "waterbottle";
            string string2 = "erbottlewat";

            bool isRotation = IsRotation(string1, string2);

            if (isRotation)
            {
                Console.WriteLine($"{string2} is a rotation of {string1}.");
            }
            else
            {
                Console.WriteLine($"{string2} is not a rotation of {string1}.");
            }


            //        Count Words in a String:
            //Write a C# program that counts the number of words in a string.

            string inputString = "This is a sample string with seven words.";

            int wordCount = CountWords(inputString);

            Console.WriteLine("Number of words in the string: " + wordCount);


            //        Remove Duplicates:
            //Implement a C# function to remove duplicate characters from a string.
            string inputString1 = "programming";
            string stringWithoutDuplicates = RemoveDuplicates(inputString1);

            Console.WriteLine("Original String: " + inputString1);
            Console.WriteLine("String Without Duplicates: " + stringWithoutDuplicates);


            //        Find Substring:
            //Write a C# function that finds the index of the first occurrence of a substring in a larger string.
            string mainString = "This is a sample string for testing.";
            string substringToFind = "sample";

            int indexOfSubstring = FindSubstring(mainString, substringToFind);

            if (indexOfSubstring != -1)
            {
                Console.WriteLine($"The substring '{substringToFind}' is found at index {indexOfSubstring}.");
            }
            else
            {
                Console.WriteLine($"The substring '{substringToFind}' is not found in the main string.");
            }


            //String Reversal in Place:
            //Implement a C# function to reverse a string in place, without using additional memory.

            string originalString = "Hello, World! anthony";
            char[] charArray = originalString.ToCharArray();

            ReverseStringInPlace(charArray);

            string reversedString = new string(charArray);
            Console.WriteLine("Original String: " + originalString);
            Console.WriteLine("Reversed String: " + reversedString);


            //Longest Substring Without Repeating Characters:
            //Write a C# function that finds the length of the longest substring without repeating characters in a given string.
            string inputString2 = "abcabcbb";
            int longestLength = LengthOfLongestSubstring(inputString2);

            Console.WriteLine("Longest substring without repeating characters: " + longestLength);


            //String to Integer(atoi):
            //Implement a C# function that converts a string to an integer, handling various edge cases and validation.
            string[] testStrings = { "123", "-456", " 789", "abc", " 42 is the answer" };

            foreach (string str in testStrings)
            {
                int result = StringToInteger(str);
                Console.WriteLine($"String: \"{str}\", Integer: {result}");
            }


            //String Replace:
            //Create a C# function to replace all occurrences of a specific substring in a given string.


            string inputString3 = "This is a sample string. This is another sample.";
            string substringToReplace = "sample";
            string replacement = "example";

            string resultString = ReplaceSubstring(inputString3, substringToReplace, replacement);

            Console.WriteLine("Original String: " + inputString3);
            Console.WriteLine("String After Replacement: " + resultString);



            //Find Common Characters:
            //Write a C# program to find the common characters among multiple strings.

            string[] strings = { "abcdef", "bcde", "cdefg" };

            List<char> commonCharacters = FindCommonCharacters(strings);

            Console.WriteLine("Common Characters: " + string.Join(", ", commonCharacters));


            //Valid Parentheses:
            //Implement a C# function to check if a given string containing
            //parentheses is valid (i.e., all opening and closing brackets match).

            string inputString5 = "({[]})";
            bool isValid = IsValidParentheses(inputString5);

            if (isValid)
            {
                Console.WriteLine("The parentheses in the string are valid.");
            }
            else
            {
                Console.WriteLine("The parentheses in the string are not valid.");
            }


            //Longest Palindromic Substring:
            //Write a C# function that finds the longest palindromic substring in a given string.

            string inputString7 = "berarebad";
            string longestPalindrome = LongestPalindromicSubstring(inputString7);

            Console.WriteLine("Longest Palindromic Substring: " + longestPalindrome);

            //Implement strStr():
            //Implement the strStr() function in C# that finds the first occurrence of a substring in a larger string.

            string haystack = "hello";
            string needle = "ell";

            int index = StrStr(haystack, needle);

            if (index != -1)
            {
                Console.WriteLine("Substring found at index " + index);
            }
            else
            {
                Console.WriteLine("Substring not found.");
            }

            //Roman to Integer:
            //Create a C# function to convert a Roman numeral string to an integer.

            string romanNumeral = "XL";

            int integerValue = RomanToInteger(romanNumeral);

            Console.WriteLine("Roman Numeral: " + romanNumeral);
            Console.WriteLine("Integer Value: " + integerValue);


            //Integer to Roman:
            //Implement a C# function to convert an integer to its Roman numeral representation.

            int integerValue0 = 1994;

            string romanNumeral0 = IntegerToRoman(integerValue0);

            Console.WriteLine("Integer Value: " + integerValue0);
            Console.WriteLine("Roman Numeral: " + romanNumeral0);

            //Edit Distance:
            //Write a C# program to calculate the edit distance between
            //two strings (the minimum number of operations required to transform one string into the other).
            string word1 = "intention";
            string word2 = "execution";

            int editDistance = MinDistance(word1, word2);

            Console.WriteLine("Edit Distance: " + editDistance);



            //// CONVERT A NUMBER STRING TO A NUMBER

            string numericString = "123";
            int number = ConvertStringToInt(numericString);
            Console.WriteLine(number);


            // RETURN A UNIQUE VALUE FROM TWO ARRAYS

            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            int uniqueValue = CalculateUniqueValue(array1, array2);
            Console.WriteLine("Unique Value: " + uniqueValue);


            // C# Program to ReverseInteger

            Console.Write("Enter an integer to reverse: ");
            if (int.TryParse(Console.ReadLine(), out int inputs))
            {
                int reversed = ReverseInteger(inputs);
                Console.WriteLine("Reversed integer: " + reversed);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }


            // C# Program to ReverseSentence
            // Test the ReverseSentence method
            string sentence = "The boy is good";
            string reversedSentence = ReverseSentence(sentence);
            Console.WriteLine(reversedSentence);

        }






        public static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static bool isPalidrome(string input)
        {
            input = input.Replace(" ", "").ToLower();

            var left = 0;
            var right = input.Length - 1;

            while(left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }




        //public static bool AreAnagrams(string str1, string str2)
        //{
        //    // Remove spaces and convert to lowercase for a case-insensitive check
        //    str1 = str1.Replace(" ", "").ToLower();
        //    str2 = str2.Replace(" ", "").ToLower();

        //    // If the lengths of the two strings are different, they can't be anagrams
        //    if (str1.Length != str2.Length)
        //    {
        //        return false;
        //    }

        //    // Use dictionaries to count the frequency of each character in both strings
        //    Dictionary<char, int> charCount1 = new Dictionary<char, int>();
        //    Dictionary<char, int> charCount2 = new Dictionary<char, int>();

        //    foreach(char c in str1)
        //    {
        //        if (charCount1.ContainsKey(c))
        //        {
        //            charCount1[c]++;
        //        }
        //        else
        //        {
        //            charCount1[c] = 1;
        //        }
        //    }

        //    foreach(char c in str2)
        //    {
        //        if (charCount2.ContainsKey(c))
        //        {
        //            charCount2[c]++;
        //        }
        //        else
        //        {
        //            charCount2[c] = 1;
        //        }
        //    }


        //    // Compare the character counts in both dictionaries
        //    foreach (var kvp in charCount1)
        //    {
        //        if(!charCount2.ContainsKey(kvp.Key) || charCount2[kvp.Key] != kvp.Value)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        //Solving AreAnagram using Linq
        public static bool AreAnagrams(string str1, string str2)
        {
            str1 = new string(str1.Replace(" ", "").ToLower().ToCharArray().OrderBy(c => c).ToArray());
            str2 = new string(str2.Replace(" ", "").ToLower().ToCharArray().OrderBy(c => c).ToArray());

            return string.Equals(str1, str2);
        }

       

        //public static string CompressString(string input)
        //{
        //    if (string.IsNullOrEmpty(input))
        //    {
        //        return input; // No compression possible for empty or null string
        //    }

        //    StringBuilder compressedStringBuilder = new StringBuilder();

        //    char currentChar = input[0];
        //    int charCount = 1;

        //    for (int i = 1; i < input.Length; i++)
        //    {
        //        if (input[i] == currentChar)
        //        {
        //            charCount++;
        //        }
        //        else
        //        {
        //            compressedStringBuilder.Append(currentChar);
        //            compressedStringBuilder.Append(charCount);
        //            currentChar = input[i];
        //            charCount = 1;
        //        }
        //    }

        //    // Append the last character and its count
        //    compressedStringBuilder.Append(currentChar);
        //    compressedStringBuilder.Append(charCount);

        //    string compressedString = compressedStringBuilder.ToString();

        //    // Return the original string if the compressed string is not shorter
        //    return compressedString.Length < input.Length ? compressedString : input;
        //}

        // another approach
        public static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input)) return input; // Check if the input string is empty or null, and return it as is.

            char currentChar = input[0]; // Initialize the current character to the first character in the input string.
            int charCount = 1; // Initialize the character count to 1 since we've seen the first character once.
            string compressed = ""; // Initialize an empty string to store the compressed result.

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar) // If the current character matches the next character in the input string.
                    charCount++; // Increment the character count.
                else
                {
                    // Append the current character and its count to the compressed string using string interpolation.
                    compressed += $"{currentChar}{charCount}";
                    currentChar = input[i]; // Update the current character to the next character.
                    charCount = 1; // Reset the character count to 1 for the new character.
                }
            }

            // Append the last character and its count to the compressed string using string interpolation.
            compressed += $"{currentChar}{charCount}";

            // Return the compressed string if it's shorter than the original string; otherwise, return the original string.
            return compressed.Length < input.Length ? compressed : input;
        }


        // RETURN A UNIQUE VALUE FROM TWO ARRAYS

        public static int[] GetUniqueValues(int[] arr1, int[] arr2)
        {
            List<int> uniqueList = new List<int>();

            foreach(var element in arr1)
            {
                if (!uniqueList.Contains(element))
                {
                    uniqueList.Add(element);
                }
            }

            foreach(var element in arr2)
            {
                if (!uniqueList.Contains(element))
                {
                    uniqueList.Add(element);
                }
            }
            return uniqueList.ToArray();
        }


        //        String Rotation:
       //Write a C# function that checks if one string is a
       //rotation of another string. For example, "waterbottle" is a rotation of "erbottlewat."
        public static bool IsRotation(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            var combinedString = str1 + str2;
            return combinedString.Contains(str2);
        }

        //        Count Words in a String:
        //Write a C# program that counts the number of words in a string.

        public static int CountWords(string input)
        {
            string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }


        //        Remove Duplicates:
        //Implement a C# function to remove duplicate characters from a string.

        public static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            StringBuilder result = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();

            foreach(var c in input)
            {
                if (!seen.Contains(c))
                {
                    seen.Add(c);
                    result.Append(c);
                }
            }

            return result.ToString();
        }


        //        Find Substring:
        //Write a C# function that finds the index of the first occurrence of a substring in a larger string.

        public static int FindSubstring(string mainString, string subString)
        {
            // Use the IndexOf method to find the index of the first occurrence of the substring.
            return mainString.IndexOf(subString);
        }


        //        String Reversal in Place:
        //Implement a C# function to reverse a string in place, without using additional memory.

        public static void ReverseStringInPlace(char[] charArray)
        {
            int left = 0;
            int right = charArray.Length - 1;

            while (left < right)
            {
                // Swap the characters at the left and right positions
                char temp = charArray[left];
                charArray[left] = charArray[right];
                charArray[right] = temp;

                // Move the pointers toward the center
                left++;
                right--;
            }
        }

        //Longest Substring Without Repeating Characters:
        //Write a C# function that finds the length of the longest substring without repeating characters in a given string.

        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            int maxLength = 0;
            int left = 0;
            int right = 0;

            HashSet<char> uniqueChars = new HashSet<char>();

            while(right < n)
            {
                if (!uniqueChars.Contains(s[right]))
                {
                    uniqueChars.Add(s[right]);
                    maxLength = Math.Max(maxLength, right - left + 1);
                    right++;
                }
                else
                {
                    uniqueChars.Remove(s[left]);
                    left++;
                }
            }

            return maxLength;
        }

        //String to Integer(atoi) :
        //Implement a C# function that converts a string to an integer, handling various edge cases and validation.

        public static int StringToInteger(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            int index = 0;
            int sign = 1;
            int num = 0;

            //Remove leading white spaces
            while(index < str.Length && (str[index] == '-' || str[index] == '+'))
            {
                sign = (str[index] == '-') ? -1 : 1;
                index++;
            }

            //process digits and convert to integer
            while(index < str.Length && char.IsDigit(str[index]))
            {
                num = num * 10 + (str[index] - '0');

                // Check for integer overflow
                if (sign == 1 && num > int.MaxValue)
                    return int.MaxValue;
                if (sign == -1 && num > (long)int.MaxValue + 1)
                    return int.MinValue;

                index++;
            }
            return (int)(num * sign);
        }


        //String Replace:
        //Create a C# function to replace all occurrences of a specific substring in a given string.

        public static string ReplaceSubstring(string input, string target, string replacement)
        {
            // Use the Replace method to replace all occurrences of the target substring.
            return input.Replace(target, replacement);
        }


        //Find Common Characters:
        //Write a C# program to find the common characters among multiple strings.
        public static List<char> FindCommonCharacters(string[] strings)
        {
            if (strings == null || strings.Length == 0)
            {
                return new List<char>();
            }

            // Initialize commonChars with characters from the first string
            string firstString = strings[0];
            List<char> commonChars = firstString.ToCharArray().ToList();

            for (int i = 1; i < strings.Length; i++)
            {
                string currentString = strings[i];
                commonChars = commonChars.Intersect(currentString).ToList();

                if (commonChars.Count == 0)
                {
                    break; // If no common characters found, no need to check further
                }
            }

            return commonChars;
        }


        //Valid Parentheses:
        //Implement a C# function to check if a given string containing parentheses is valid (i.e., all opening and closing brackets match).

        public static bool IsValidParentheses(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch); // Push opening parentheses onto the stack.
                }
                else if (ch == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false; // Mismatched closing parentheses.
                }
                else if (ch == ']' && (stack.Count == 0 || stack.Pop() != '['))
                {
                    return false; // Mismatched closing brackets.
                }
                else if (ch == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false; // Mismatched closing braces.
                }
            }

            return stack.Count == 0; // The stack should be empty for a valid string.
        }



        //Longest Palindromic Substring:
        //Write a C# function that finds the longest palindromic substring in a given string.

        public static string LongestPalindromicSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            int length = s.Length;
            bool[,] isPalindrome = new bool[length, length];
            int start = 0;
            int maxLength = 1;

            // All substrings of length 1 are palindromes
            for (int i = 0; i < length; i++)
            {
                isPalindrome[i, i] = true;
            }

            // Check for palindromes of length 2
            for (int i = 0; i < length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    isPalindrome[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for palindromes of length 3 or more
            for (int k = 3; k <= length; k++)
            {
                for (int i = 0; i < length - k + 1; i++)
                {
                    int j = i + k - 1;

                    if (isPalindrome[i + 1, j - 1] && s[i] == s[j])
                    {
                        isPalindrome[i, j] = true;

                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }

            return s.Substring(start, maxLength);
        }


        //Implement strStr():
        //Implement the strStr() function in C# that finds the first occurrence of a substring in a larger string.

        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0; // An empty needle is found at the beginning.
            }

            int hayLen = haystack.Length;
            int needleLen = needle.Length;

            for (int i = 0; i <= hayLen - needleLen; i++)
            {
                int j;
                for (j = 0; j < needleLen; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }

                if (j == needleLen)
                {
                    return i; // Found a match at index i.
                }
            }

            return -1; // Substring not found.
        }


        //Roman to Integer:
        //Create a C# function to convert a Roman numeral string to an integer.

        public static int RomanToInteger(string s)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

            int result = 0;
            int prevValue = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                int currentValue = romanMap[s[i]];
                
                if (currentValue < prevValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }

                prevValue = currentValue;
            }

            return result;
        }


        //Integer to Roman:
        //Implement a C# function to convert an integer to its Roman numeral representation.
        public static string IntegerToRoman(int num)
        {
            if (num < 1 || num > 3999)
            {
                throw new ArgumentOutOfRangeException("Input value must be between 1 and 3999");
            }

            string[] thousands = { "", "M", "MM", "MMM" };
            string[] hundreds = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tens = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] ones = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            return thousands[num / 1000] + hundreds[(num % 1000) / 100] + tens[(num % 100) / 10] + ones[num % 10];
        }

        //Edit Distance:
        //Write a C# program to calculate the edit distance between
        //two strings (the minimum number of operations required to transform one string into the other).

        public static int MinDistance(string word1, string word2)
        {
            int m = word1.Length;
            int n = word2.Length;

            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0)
                    {
                        dp[i, j] = j;
                    }
                    else if (j == 0)
                    {
                        dp[i, j] = i;
                    }
                    else if (word1[i - 1] == word2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] = 1 + Math.Min(dp[i - 1, j - 1], Math.Min(dp[i, j - 1], dp[i - 1, j]));
                    }
                }
            }

            return dp[m, n];
        }


        // CONVERT A NUMBER STRING TO A NUMBER

        public static int ConvertStringToInt(string val)
        {
            var num = 0;
            var n = val.Length;

            for (int i = 0; i < n; i++)
            {
                num = num * 10 + ((int)val[i] - 48);
            }

            return num;
        }



        // RETURN A UNIQUE VALUE FROM TWO ARRAYS

        public static int CalculateUniqueValue(int[] arr1, int[] arr2)
        {
            int val = arr1.Sum();  // Sum of elements in arr1
            int val2 = arr2.Sum(); // Sum of elements in arr2

            return Math.Abs(val - val2); // Absolute difference
        }


        // C# Program to ReverseInteger

        public static int ReverseInteger(int value)
        {
            var res = 0; // Initialize the result variable to 0.

            while (value != 0)
            {
                var a = value % 10; // Get the last digit of 'value'.
                res = res * 10 + a; // Append the last digit to the result.
                value = value / 10; // Remove the last digit from 'value'.
            }

            return res; // 'res' now contains the reversed integer.
        }

        // C# Program to ReverseSentence
        public static string ReverseSentence(string str)
        {
            var output = "";
            var arr = str.Split(' ');
            foreach (var word in arr)
            {
                var temp = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    temp += word[i];
                }
                output += temp + " ";
            }
            return output.Trim(); // Trim to remove the trailing space
        }
    }
}