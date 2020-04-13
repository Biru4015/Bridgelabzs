using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using System;
using System.Text.RegularExpressions;

namespace UserRegistrationTest
{
    /// <summary>
    /// This class cantains the code of testing for user registrations 
    /// </summary>
    public class FirstNameTest
    {
        //--------------------------Test for first name------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void FirstNmaeTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest first = new UserDetailsTest();
            Assert.IsFalse(first.FirstNameMethod("biru"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void FirstNameTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest first = new UserDetailsTest();
            Assert.IsTrue(first.FirstNameMethod("Biru"));
        }

        //--------------------------Test for last name------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void LastNmaeTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest first = new UserDetailsTest();
            Assert.IsFalse(first.FirstNameMethod("singh"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void LastNameTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest first = new UserDetailsTest();
            Assert.IsTrue(first.FirstNameMethod("Singh"));
        }

    }
}