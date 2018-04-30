using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication4;

namespace UnitTestProject1
{
    [TestClass]
    public class SharewareTest
    {
        [TestMethod]
        public void SharewareItIsAWorks()
        {
            // arrange
            
            Shareware shareware = new Shareware("WinRAR", "RARLAB", "24.04.2018", 50 , 500);
            bool expected = true;
            //act 
            bool actual = shareware.ItIsAWorks();

            //assert 
            Assert.AreEqual(expected, actual);
        }
    }
}
