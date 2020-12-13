using System;

namespace NumberToLcdKata
{
    class Program
    {
        static void Main(string[] args)
        {
            string upperOne = "  ";
            string middleOne = " |";
            string lowerOne = " |";
             
            string upperTwo ="  _";
            string middleTwo = "  _|";
            string lowerTwo = " |_";

            string upperThree = "  _";
            string middleThree = " _|";
            string lowerThree = "  _|";

            string upperFour = "  ";
            string middleFour = " |_|";
            string lowerFour = "   |";

            string Two = "  __\n    |\n    |\n  __\n |\n |\n  __";

            string TwoLine = "|";



            Console.WriteLine("   ___  ___  ___  ___  ___  ___\n      |    |    |    |    |    |\n      |    |    |    |    |    |\n   ___  ___  ___  ___  ___  ___\n  |    |    |    |    |    |   \n  |    |    |    |    |    |   \n   ___  ___  ___  ___  ___  ___");
            /*Console.WriteLine(
                                upperOne + upperTwo + upperThree +  upperFour+ "\n" 
                              + middleOne + middleTwo + middleThree + middleFour + "\n" 
                              + lowerOne + lowerTwo + lowerThree + lowerFour);*/
        }
    }
}
