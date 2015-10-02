using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testePalindrome
{
    [TestClass]
    public class untTeste
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Palindrome.inversao.mudaLetra("arara"), "arara");
            
           
        }
    }
}
