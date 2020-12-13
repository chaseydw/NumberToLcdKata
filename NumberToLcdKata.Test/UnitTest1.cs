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

    }
}