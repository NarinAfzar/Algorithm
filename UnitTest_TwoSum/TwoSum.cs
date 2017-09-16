using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codes;

namespace UnitTest_TwoSum
{
    [TestClass]
    public class TwoSum_Test
    {
        [TestMethod]
        public void Test_FindTwoSum_Valid()
        {
            //Arrenge
            TwoSum twoSum = new TwoSum();
            var result=twoSum.FindTwoSum(new int[]{4,5,2,44,78,999},1001);

            //Actual
            int[] actual = new int[] { 2, 5 };

            //Assert
            Assert.AreEqual(actual[0], result[0]);
            Assert.AreEqual(actual[1], result[1]);
        }

      
       



    }
}
