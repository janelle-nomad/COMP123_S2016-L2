using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_L3;


/**
 *  Author: Janelle Heron
 *  Date Created: May 17 2016
 *  Description: Advanced 
 */
namespace UnitTestProjectForLesson2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddXandYTestMethod()
        {
            //Arrange

            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act

            int result = Program.addXandY(x, y);


            //Assert
            Assert.AreEqual(expectedResult, result);

        }


      
            [TestMethod]
            public void AddYtoXTestMethod()
            {
                //Arrange

                int x = 40;
                int y = 50;
                int expectedResult = 90;

                //Act

                int result = Program.addYtoX(ref x, ref y);


                //Assert
                Assert.AreEqual(expectedResult, result);

            }
        }
}
