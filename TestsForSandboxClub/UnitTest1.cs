using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Sandbox_Club;

namespace TestsForSandboxClub
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Check_Pass()
        {
            Form1 form = new Form1();
            string result = form.Pass.Text = "Pass1)";
            StringAssert.Matches(result, new System.Text.RegularExpressions.Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=])[0-9a-zA-z!@#$%^&*()_+=]{6,}$"));
        }
        [TestMethod]
        public void Check_Fail_Pass()
        {
            Form1 form = new Form1();
            string result = form.Pass.Text = "oen8$c";
            StringAssert.DoesNotMatch(result, new System.Text.RegularExpressions.Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+=])[0-9a-zA-z!@#$%^&*()_+=]{6,}$"));
        }
        [TestMethod]
        public void Test_Pass()
        {
            Form1 form = new Form1();
            string pas = form.Pass.Text = "Pass1)";
            string result = form.Pass2.Text = "Pass1)";
            Assert.AreEqual(result, pas);
        }
        [TestMethod]
        public void Test_Not_Free_Name()
        {
            Form1 form1 = new Form1();
            form1.NameText.Text = "Маша";
            Assert.IsNotNull(form1.NameText);
        }
        [TestMethod]
        public void q()
        {
            
        }
    }
}
