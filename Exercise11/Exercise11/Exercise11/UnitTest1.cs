using System;
using NUnit.Framework;

namespace Exercise11
{
    public class Tests
    {
        private Logic logic;
        [SetUp]
        public void Setup()
        {
            logic = new Logic();
        }
        // Condition Asserts
        [TestCase(4)]
        [TestCase(0)]
        public void ConditionAssertsTrue(int value)
        {
            var condition = logic.LessThen5(value);
            Assert.IsTrue(condition);
        }
        // Equality Assert
        [TestCase(4, 5, 9)]
        [TestCase(3, 4.2, 7)]
        public void SumOfElements(int value1, double value2, int result)
        {
            var actual = logic.Sum(value1, value2);
            Assert.AreEqual(result, actual);
        }

        // Exception Assert.
        [Test]
        public void ArgumentException()
        {
            TestDelegate test = new TestDelegate(logic.Generate);
            Assert.Throws(typeof(ArgumentException), test);
        }
    }
}