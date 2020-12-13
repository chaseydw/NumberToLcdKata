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
                if (num == '1')
                {
                    upperLine += upperOne;
                    middleLine += middleOne;
                    lowerLine += lowerOne;
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

            string returnNumbers = upperLine + "\n" + middleLine + "\n" + lowerLine;
            return returnNumbers;

        }

        public string ConvertToLcd(string origNumber, int height, int width)
        {
            if (String.IsNullOrEmpty(origNumber))
            {
                return origNumber;
            }
            int numOfNumbers = origNumber.Length;
            string section1 = " ";
            string section2 = "  ";
            string section3 = " ";
            string section4 = " ";
            string section5 = " ";

            char[] arrayOfNumbers = origNumber.ToCharArray();
            foreach (char num in arrayOfNumbers)
            {
                //create a space between numbers
                section1 += "  ";
                section2 += " ";
                section3 += "  ";
                section4 += " ";
                section5 += "  ";

                if (num == '2')
                {
                    for (int i = 0; i < width; i++)
                    {
                        section1 += "_";
                    }
                   
                    for (int x = 1; x < width; x++)
                    {
                        section2 += " ";
                    }
                    section2 += " |";


                    for (int i = 0; i < width; i++)
                    {
                        section3 += "_";
                    }

                    section4 += "| ";
                    for (int x = 1; x < width; x++)
                    {
                        section4 += " ";
                    }

                    for (int i = 0; i < width; i++)
                    {
                        section5 += "_";
                    }

                }
            }
            
            for (int i = 0; i < height / 2; i++)
            {
                section2 += "\n" + section2;
                section4 += "\n" + section4;
            }

            string returnNumbers = section1 + "\n" + section2 + "\n" + section3 + "\n" + section4 + "\n" + section5;
            return returnNumbers;
        }
    }
}
