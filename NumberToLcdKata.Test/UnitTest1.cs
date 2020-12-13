using NUnit.Framework;

namespace NumberToLcdKata.Test
{
    public class Tests
    {
        NumberConverter numberConverter;
        static string upperOne = "  ";
        static string middleOne = " |";
        static string lowerOne = " |";

        static string upperTwo = "  _";
        static string middleTwo = "  _|";
        static string lowerTwo = " |_";

        static string upperThree = "  _";
        static string middleThree = " _|";
        static string lowerThree = "  _|";

        string upperFour = "  ";
        string middleFour = " |_|";
        string lowerFour = "   |";

       

        [SetUp]
        public void Setup()
        {
            numberConverter = new NumberToLcdKata.NumberConverter();

        }

        [TearDown]
        public void TearDown()
        {
            numberConverter = null;

        }

        [Test]
        public void TestConvertEmptyString()
        {

            Assert.AreEqual("", numberConverter.ConvertToLcd(""));
        }

        [Test]
        public void TestConvertOne()
        {

            Assert.AreEqual(upperOne + "\n" + middleOne + "\n" + lowerOne, numberConverter.ConvertToLcd("1"));
        }

        [Test]
        public void TestConvertTwo()
        {

            Assert.AreEqual(upperTwo + "\n" + middleTwo + "\n" + lowerTwo, numberConverter.ConvertToLcd("2"));
        }

        [Test]
        public void TestConvertThree()
        {

            Assert.AreEqual(upperThree + "\n" + middleThree + "\n" + lowerThree, numberConverter.ConvertToLcd("3"));
        }

        [Test]
        public void TestConvertOneTwoThree()
        {
            string lcdVal = upperOne + upperTwo + upperThree + "\n" +
                            middleOne + middleTwo + middleThree + "\n" +
                            lowerOne + lowerTwo + lowerThree;

            Assert.AreEqual(lcdVal, numberConverter.ConvertToLcd("123"));
        }

        [Test]
        public void TestConvertOneTwoThreeFour()
        {
            string lcdVal = upperOne + upperTwo + upperThree + upperFour + "\n"
                              + middleOne + middleTwo + middleThree + middleFour + "\n"
                              + lowerOne + lowerTwo + lowerThree + lowerFour;

            Assert.AreEqual(lcdVal, numberConverter.ConvertToLcd("1234"));
        }

        [Test]
        public void TestConvertOneTwoOneThreeFour()
        {
            string lcdVal = upperOne + upperTwo + upperOne + upperThree + upperFour + "\n"
                              + middleOne + middleTwo + middleOne+ middleThree + middleFour + "\n"
                              + lowerOne + lowerTwo + lowerOne + lowerThree + lowerFour;

            Assert.AreEqual(lcdVal, numberConverter.ConvertToLcd("12134"));
        }

        [Test]
        public void TestConvertTwoWithhHeightOfTwoAndWidthOfThree()
        {
            string Two = "   ___\n      |\n      |\n   ___\n  |   \n  |   \n   ___";

            Assert.AreEqual(Two, numberConverter.ConvertToLcd("2", 2, 3));
        }

        [Test]
        public void TestConvertTwoTwosWithhHeightOfTwoAndWidthOfThree()
        {
            string Two = "   ___  ___  ___  ___  ___  ___\n      |    |    |    |    |    |\n      |    |    |    |    |    |\n   ___  ___  ___  ___  ___  ___\n  |    |    |    |    |    |   \n  |    |    |    |    |    |   \n   ___  ___  ___  ___  ___  ___";

            Assert.AreEqual(Two, numberConverter.ConvertToLcd("222222", 2, 3));
        }

        [Test]
        public void TestConvertTwoTwosWithhHeightOfFourAndWidthOfSix()
        {
            string Two = "   ______  ______\n         |       |\n         |       |\n         |       |\n         |       |\n   ______  ______\n  |       |      \n  |       |      \n  |       |      \n  |       |      \n   ______  ______";

            Assert.AreEqual(Two, numberConverter.ConvertToLcd("22", 4, 6));
        }

    }
}