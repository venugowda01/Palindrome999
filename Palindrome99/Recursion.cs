using System;
public class F_Palindrome_R
{
    public static bool IsPalindrome(string text)
    {
        if (text.Length <= 1)
            return true;
        else
        {
            if (text[0] != text[text.Length - 1])
                return false;
            else
                return IsPalindrome(text.Substring(1, text.Length - 2));
        }
    }

    public static void Main()
    {
        Console.WriteLine(IsPalindrome("radar"));
        Console.WriteLine(IsPalindrome("pato"));
    }
}