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
    }
}