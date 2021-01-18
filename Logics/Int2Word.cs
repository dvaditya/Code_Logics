using System;
using System.Collections.Generic;
using System.Linq;

namespace Logics
{
    class Int2Word
    {
        public String ConvertToWord(string num)
        {
            if (num == "0")
            {
                Console.WriteLine("The number is Zero");
            }
            var word = string.Empty;
            var number = Convert.ToDouble(num);

            if(number > 0)
            {
                switch (num.Length)
                {
                    case 1: // 1-9
                        word = Ones(num);
                        break;
                    case 2: // 10 - 99
                        word = Tens(num);
                        break;
                    case 3: // 100 - 999
                        word = Ones(num.Substring(0, 1)) + " Hundred " + Tens(num.Substring(1));
                        break;
                    case 4: // 1000 - 9999
                        word = Ones(num.Substring(0, 1)) + " Thousand " + ConvertToWord(num.Substring(1));
                        break;
                    case 5: // 10,000 - 99,999
                        word = Tens(num.Substring(0, 2)) + " Thousand " + ConvertToWord(num.Substring(2));
                        break;
                    case 6: // 100,000 - 999,999
                        word = ConvertToWord(num.Substring(0,3)) + " Thousand " + ConvertToWord(num.Substring(3));
                        break;
                    default:
                        word = "Number out of range";
                        break;
                }
            }

            return word;
        }

        private static String Ones(string number)
        {
            int _num = Convert.ToInt32(number);
            string name = string.Empty;

            switch (_num)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }

            return name;
        }

        private static String Tens(string number)
        {
            int _num = Convert.ToInt32(number);
            string name = string.Empty;

            switch (_num)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if(_num > 0)
                    {
                        name = Tens(number.Substring(0, 1) + "0") + " " + Ones(number.Substring(1));
                    }
                    break;
            }
            return name;
        }
    }
}
