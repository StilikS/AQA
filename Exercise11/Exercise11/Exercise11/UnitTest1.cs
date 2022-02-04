using System;
using System.IO;
using System.Reflection;
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

        // Exception Assert
        [Test]
        public void ArgumentException()
        {
            TestDelegate test = new TestDelegate(logic.Generate);
            Assert.Throws(typeof(ArgumentException), test);
        }
        
        // DirectoryAssert
        [Test]
        public void TwoFolderAreEquals()
        {
            DirectoryInfo directory1 = new DirectoryInfo(Directory.GetCurrentDirectory());
            DirectoryInfo directory2 = new DirectoryInfo(Directory.GetCurrentDirectory());

            DirectoryAssert.AreEqual(directory1, directory2);
        }
        
        //FileAssert
        [TestCase("File1.txt", "File2.txt")]
        public void TwoFilesWithTheSameContentsAreEqual(string fileNamber1, string fileNamber2)
        {
            var basePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path1 = $"{basePath}{Path.DirectorySeparatorChar}{fileNamber1}";
            var path2 = $"{basePath}{Path.DirectorySeparatorChar}{fileNamber2}";
            
            FileInfo file1 = new FileInfo(path1);
            FileInfo file2= new FileInfo(path2);

            FileAssert.AreEqual(file1, file2);
        }
        
        // CollectionAssert
        [TestCase(new int[] {2, 4, 6, 8}, new int[] {4, 6, 8, 10})]
        [TestCase(new int[] {-2, 0, 2, 4}, new int[] {0, 2, 4, 6})]
        public void GetArrayCheck(int[] arr1, int[] arr2)
        {
            var actual = logic.GetArray(arr1);
            CollectionAssert.AreEqual(arr1, actual);
        }
        
    }
}