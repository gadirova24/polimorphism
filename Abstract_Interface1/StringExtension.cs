using System;
namespace Abstract_Interface1
{
    static class StringExtension
    {
        public static bool HasUpper(this string text)
        {
            foreach (var letter in text)
            {
                if (Char.IsUpper(letter))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

