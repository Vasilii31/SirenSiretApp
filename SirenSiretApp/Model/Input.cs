using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirenSiretApp.Model
{
    public class Input
    { 
        public string userInputstr { get; set; }
        public long parseNumber;


        public Input()
        {

        }

        public Input(string s)
        {
            this.userInputstr = s;
        }
        #region Input_Verification_Methods
        public bool CheckInputLength(string parseToString)
        {
            if (parseToString.Length == 9 || parseToString.Length == 14)
            {
                return true;
            }
            return false;
        }

        public bool CheckParsing()
        {

            try
            {
                parseNumber = long.Parse(userInputstr);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0}: Bad Format", userInputstr);
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0}: Overflow", userInputstr);
                return false;
            }
            if (parseNumber <= 0)
            {
                Console.WriteLine("{0}: Negative Outcome", userInputstr);
                return false;
            }
            return true;
        }

        public bool CheckGlobalCorrect()
        {
            if (CheckParsing() == true && CheckInputLength(parseNumber.ToString()) == true)
                return true;
            return false;
        }
        #endregion

        #region Siren_Siret_Verification_Methods
        public bool KeyLhunAlgorithm()
        {
            int result = LhunSum(userInputstr);
            if (result % 10 == 0)
                return true;
            return false;
        }

        public int LhunSum(string inputStr)
        {
            int result = 0;
            int iter = 1;
            for (int i = inputStr.Length - 1; i >= 0; i--)
            {
                if (iter % 2 == 0)
                {

                    int temp = Convert.ToInt32(inputStr[i].ToString()) * 2;
                    if (temp >= 10)
                    {
                        result += temp / 10;
                        result += temp % 10;
                    }
                    else
                    {
                        result += temp;
                    }
                }
                else
                {
                    result += Convert.ToInt32(inputStr[i].ToString());
                }
                iter++;
            }
            return result;
        }
        #endregion
    }
}
