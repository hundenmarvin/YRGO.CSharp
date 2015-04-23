using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YRGO.CS._7
{
    static class Utility
    {
        public static string GetLastname(string fullName)
        {
            var indexOfSpace = fullName.IndexOf(' ');
            return fullName.Substring(indexOfSpace + 1);
        }

        public static string ToUpperFirst(this string str)
        {
            var firstChar = str[0].ToString().ToUpper();
            var restOfString = str.Substring(1);

            return firstChar + restOfString;
        }

        public static string ToUpperWord(this string str)
        {
            var output = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (i == 0 || str[i - 1] == ' ')
                    output += str[i].ToString().ToUpper();
                else
                    output += str[i].ToString();
            }

            return output;
        }

        public static int SumStringNumbers(string input)
        {
            string number = "";

            int sum = 0;
            bool add = true;

            for (int i = 0; i < input.Length; i++)
            {
                var c = input[i];

                // Är det en siffra?
                if (Char.IsNumber(c))
                    number += c;

                // Är det minus, plus eller sista tecknet i strängen?
                // i så fall summerar vi och sätter nästa räknetecken
                if (c == '-' || c == '+' || i == input.Length - 1)
                {
                    if (number != "")
                    {
                        if (add)
                            sum += Convert.ToInt32(number);
                        else
                            sum -= Convert.ToInt32(number);

                        number = "";
                    }

                    if (c == '+')
                        add = true;

                    if (c == '-')
                        add = false;
                }
            }

            return sum;
        }
    }
}
