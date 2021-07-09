using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestReplacementToFizz_enterS_returnedExpected()
        {
            //arrange
            string s = "sfgg ghhh  hhhhh hhhhh hhhhh hhhhh";
            string expected = "sfgg ghhh  Fizz hhhhh hhhhh Fizz";

            //act
            string assert = FizzBuzz.FizzBuzzClass.ReplacementToFizz(s);

            //assert
            Assert.AreEqual(expected, assert);
        }
        [TestMethod]
        public void TestReplacementToFizz_enterS_returnedS()
        {
            //arrange
            string s = "sfgg ghhh";
            string expected = s;

            //act
            string assert = FizzBuzz.FizzBuzzClass.ReplacementToFizz(s);

            //assert
            Assert.AreEqual(expected, assert);
        }
        [TestMethod]
        public void TestReplacementToBuzz_enterS_returnedExpected()
        {
            //arrange
            string s = "sfgg g";
            string expected = "sfgg Buzz";

            //act
            string assert = FizzBuzz.FizzBuzzClass.ReplacementToBuzz(s);

            //assert
            Assert.AreEqual(expected, assert);
        }

        [TestMethod]
        public void TestgetOverlappings_enterS_returned2()
        {
            //arrange
            string s = "sfgg ghhh  Fizz hhhhh hhhhh Fizz";
            int expected = 2;

            //act
            FizzBuzz.FizzBuzzClass.FizzBuzzDetector ob = new FizzBuzz.FizzBuzzClass.FizzBuzzDetector();
            int assert = ob.getOverlappings(s);
           
            //assert
            Assert.AreEqual(expected, assert);
        }

        [TestMethod]
        public void TestgetOverlappings_enterS_returned0()
        {
            //arrange
            string s = "sfgg ghhh hhhhh hhhhh Fiz";
            int expected = 0;

            //act
            FizzBuzz.FizzBuzzClass.FizzBuzzDetector ob = new FizzBuzz.FizzBuzzClass.FizzBuzzDetector();
            int assert = ob.getOverlappings(s);

            //assert
            Assert.AreEqual(expected, assert);
        }

    }
}
