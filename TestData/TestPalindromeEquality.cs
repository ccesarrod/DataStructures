using Algorithms;
using NUnit.Framework;
using System;


namespace TestData
{
    [TestFixture]
    public class TestPalindromeEquality
    {

        [Test]
        public void test_is_valid_word()
        {
            var result = PalidromeEquality.IsPalindrome("level");
            Assert.IsTrue(result);
        }


        [Test]
        public void test_null_word()
        {

            Assert.Throws<NullReferenceException>(MethodThatThrows);
        }
        [Test]
        public void test_empty_word()
        {

            var result = PalidromeEquality.IsPalindrome(string.Empty);
            Assert.IsTrue(result);
        }

        [Test]
        public void test_numbers()
        {

            var result = PalidromeEquality.IsPalindrome("1221");
            Assert.IsTrue(result);
        }
        void MethodThatThrows()
        {
            PalidromeEquality.IsPalindrome(null);
        }
    }
}
