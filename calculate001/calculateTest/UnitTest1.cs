using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.mariuszgromada.math.mxparser.regressiontesting;
using org.mariuszgromada.math.mxparser;

namespace calculateTest
{
    [TestClass]
    public class UnitTest1
    {

        #region Test Calculate
        /// <summary>
        /// Test Square Root
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //declare/initialize
            //RunTest.Start("syn", "api", "reg");
            var mathParser = new Expression();
            var input = "sqrt(16)";
            var output = 4d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        /// <summary>
        /// Test Exponent
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "9^8";
            var output = 43046721d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        /// <summary>
        /// Test Multiplicaiton
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "9*3";
            var output = 27d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        /// <summary>
        /// Test Division
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "27/3";
            var output = 9d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }


        /// <summary>
        /// Test Addition
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "50+68";
            var output = 118d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        /// <summary>
        /// Test Subtraction
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "118-68";
            var output = 50d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        #endregion

        #region Test Calculate Multiple Operators
        [TestMethod]
        public void MultiOperators1()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "2^2+3*6";
            var output = 22d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void MultiOperators2()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "2+4/sqrt(4)-4";
            var output = 0d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        [TestMethod]
        public void MultiOperators3()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "2+4/sqrt(4)-4+16^2";
            var output = 256d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreEqual(output, actual);
        }

        #endregion

        #region Test Fail Calculation
        [TestMethod]
        public void TestFail1()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "Test";
            var output = 0d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreNotEqual(output, actual);
        }

        [TestMethod]
        public void TestFail2()
        {
            //declare/initialize
            var mathParser = new Expression();
            var input = "a + 2";
            var output = 0d;
            mathParser.setExpressionString(input);

            //actual
            var actual = (double)mathParser.calculate();

            //assert
            Assert.AreNotEqual(output, actual);
        }


        #endregion
    }
}
