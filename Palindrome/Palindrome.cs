/*
* Program to determine if a string is a palindromic sequence.
* Ignores case, punctuation, and whitespace in the string.
*/
public class Palidnrome {

    public static bool IsPalindrome(string str) {
        str = str.ToLower();      // set everything to lowercase to ignore case
        int i = 0;                      // first index
        int j = str.Length - 1;      // last index

        while (i < j) {
            if (char.IsWhiteSpace(str[i]) || char.IsPunctuation(str[i])) {
                i++;
                continue;   // Skip whitespace/punctuation
            }
            else if (char.IsWhiteSpace(str[j]) || char.IsPunctuation(str[j])) {
                j--;
                continue;   // Skip whitespace/punctuation
            }
            else if (char.Equals(str[i], str[j])) {
                i++;
                j--;
                continue;   // Palindromic so continue
            }
            else {
                return false;   // Not palindromic
            }
        }
        return true;
    }
    public static void Main(string[] args) {
        string[] testStrings = {"Hello World!", "Race car!", "Rotor", "More cowbell!", "Madam, I'm Adam."};
        foreach (string str in testStrings) {
            bool result = Palidnrome.IsPalindrome(str);
            if (result)
                Console.WriteLine($"'{str}' is a palindromic sequence.");
        }
    }
}
