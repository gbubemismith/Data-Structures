using System.Text;

namespace DataStructures
{
    public class StringQuestions
    {
        public static int CountVowels(string str)
        {
            if (str == null)
                return 0;

            int count = 0;
            var vowels = "aeiou";

            foreach (var ch in str.ToLower().ToCharArray())
            {
                if (vowels.IndexOf(ch) != -1)
                    count++;
            }

            return count;
        }

        public static string ReverseString(string str)
        {

            var reversed = new StringBuilder();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str.ToCharArray()[i]);
            }

            return reversed.ToString();
        }

        public static string ReverseWords(string sentence)
        {
            var words = sentence.Split(" ");

            var reversedWords = new StringBuilder();

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedWords.Append(words[i] + " ");
            }


            return reversedWords.ToString().TrimEnd();
        }

        public static bool AreRotations(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;

            if (!(str1 + str2).Contains(str2))
                return false;

            return true;
        }


    }
}