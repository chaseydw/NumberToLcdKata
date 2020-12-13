using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToLcdKata
{
    public class NumberConverter
    {
        public string ConvertToLcd(string origNumber)
        {
            if (String.IsNullOrEmpty(origNumber))
            {
                return origNumber;
            }
            string upperOne = "  ";
            string middleOne = " |";
            string lowerOne = " |";

            string upperTwo = "  _";
            string middleTwo = "  _|";
            string lowerTwo = " |_";

            string upperThree = "  _";
            string middleThree = " _|";
            string lowerThree = "  _|";

            string upperFour = "  ";
            string middleFour = " |_|";
            string lowerFour = "   |";

            int numOfNumbers = origNumber.Length;
            string upperLine = string.Empty;
            string middleLine = string.Empty;
            string lowerLine = string.Empty;

            
            char[] arrayOfNumbers = origNumber.ToCharArray();

            foreach (char num in arrayOfNumbers)
            {
                if(num == '1')
                {
                    upperLine+=upperOne;
                    middleLine+= middleOne;
                    lowerLine+=lowerOne;
                }
                else if (num == '2')
                {
                    upperLine += upperTwo;
                    middleLine += middleTwo;
                    lowerLine += lowerTwo;
                }
                else if (num == '3')
                {
                    upperLine += upperThree;
                    middleLine += middleThree;
                    lowerLine += lowerThree;
                }
                else if (num == '4')
                {
                    upperLine += upperFour;
                    middleLine += middleFour;
                    lowerLine += lowerFour;
                }
            }
      
            string returnNumbers = upperLine  + "\n" + middleLine  + "\n"+ lowerLine ;
            return returnNumbers;
                     
        }
    }
}
