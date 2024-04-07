using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8aprel
{
    public static class Helper
    {
        public static bool IsOdd( int num)
        {
            return num % 2 != 0;
        }

        public static bool IsEven( int num)
        {
            return num % 2 == 0;
        }
        public static bool HasDigit(this string str)
        {
            return str.Any(char.IsDigit);
        }

        public static bool CheckPassword(this string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Length >= 8;
        }

        public static string Capitalize(this string str)
        {
            return str.Substring(0,1).ToUpper() + str.Substring(1).ToLower();
        }
    }
}
