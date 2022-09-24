using System;

namespace Open_Lab_03._11
{
    public class Checker
    {
        public bool IsPalindrome(string str)

        {
            char[]chr  = str.ToCharArray();
            Array.Reverse(chr);

            rev = new string(chr);

            if (str == rev)
                return true;
            else
                return false;
        }

    }
}
