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
            UserDetailsTest last = new UserDetailsTest();
            Assert.IsFalse(last.LastNameMethod("singh"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void LastNameTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest last= new UserDetailsTest();
            Assert.IsTrue(last.LastNameMethod("Singh"));
        }

        //-----------------------Test for emailid---------------------------------------
        /// <summary>
        /// This mthod is for wrong input testing
        /// </summary>
        [Test]
        public void EmailMethodTest_WorngInput_ReturnsFalse()
        {
            UserDetailsTest email= new UserDetailsTest();
            Assert.IsFalse(email.EmailMethod("abc12.xyz.co.in"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void EmailMethodTest_RightInput_ReturnsTrue()
        {
            UserDetailsTest email= new UserDetailsTest();
            Assert.IsTrue(email.EmailMethod("abc.xyz@bridgelabz.co.in"));
        }

        /// <summary>
        /// This method is checking for right input checking
        /// </summary>
        [Test]
        public void EmailMethodTest_RightInput1_ReturnsTrue()
        {
            UserDetailsTest email = new UserDetailsTest();
            Assert.IsTrue(email.EmailMethod("abc@yahoo.com"));
        }

    }
}