using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IIG.FileWorker;

namespace Lab2
{
    [TestClass]
    public class FileWorkerTest
    {
        [TestMethod]
        public void Test_GetFileName_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile1.txt";
            string expected = "testFile1.txt";

            string actual = BaseFileWorker.GetFileName(fullPath);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetFileName_Existing_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile1.txt";
            string expected = "testFile1.txt";

            string actual = BaseFileWorker.GetFileName(relativePath);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetFileName_NotExisting_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.GetFileName(fullPath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFileName_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.GetFileName(relativePath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFileName_NullPath()
        {
            string path = null;

            string actual = BaseFileWorker.GetFileName(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFileName_EmptyStringPath()
        {
            string path = "";

            string actual = BaseFileWorker.GetFileName(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFullPath_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile1.txt";

            string actual = BaseFileWorker.GetFullPath(fullPath);

            Assert.AreEqual(fullPath, actual);
        }

        [TestMethod]
        public void Test_GetFullPath_Existing_RelativePath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile1.txt";
            string relativePath = ".\\..\\..\\TestFiles\\testFile1.txt";

            string actual = BaseFileWorker.GetFullPath(relativePath);

            Assert.AreEqual(fullPath, actual);
        }

        [TestMethod]
        public void Test_GetFullPath_NotExisting_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.GetFullPath(fullPath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFullPath_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.GetFullPath(relativePath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFullPath_NullPath()
        {
            string path = null;

            string actual = BaseFileWorker.GetFullPath(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetFullPath_EmptyStringPath()
        {
            string path = "";

            string actual = BaseFileWorker.GetFullPath(path);

            Assert.IsNull(actual);
        }


        [TestMethod]
        public void Test_GetPath_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile1.txt";
            string expected = "D:\\Software-Engineering-Components\\Lab2\\TestFiles";

            string actual = BaseFileWorker.GetPath(fullPath);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetPath_Existing_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile1.txt";
            string expected = "D:\\Software-Engineering-Components\\Lab2\\TestFiles";

            string actual = BaseFileWorker.GetPath(relativePath);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_GetPath_NotExisting_FullPath()
        {
            string fullPath= "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.GetPath(fullPath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetPath_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.GetPath(relativePath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetPath_NullPath()
        {
            string path = null;

            string actual = BaseFileWorker.GetPath(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_GetPath_EmptyStringPath()
        {
            string path = "";

            string actual = BaseFileWorker.GetPath(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadAll_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile1.txt";
            string expected = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Integer massa urna, ultrices vitae ultricies vitae, venenatis quis sapien.\r\n" +
                "Pellentesque nulla sem, fringilla vel elementum eu, ullamcorper ac metus.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            string actual = BaseFileWorker.ReadAll(fullPath);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ReadAll_Existing_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile1.txt";
            string expected = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Integer massa urna, ultrices vitae ultricies vitae, venenatis quis sapien.\r\n" +
                "Pellentesque nulla sem, fringilla vel elementum eu, ullamcorper ac metus.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            string actual = BaseFileWorker.ReadAll(relativePath);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ReadAll_NotExisting_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.ReadAll(fullPath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadAll_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\jkrrtvrwereresftg.txt";

            string actual = BaseFileWorker.ReadAll(relativePath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadAll_NullPath()
        {
            string path = null;

            string actual = BaseFileWorker.ReadAll(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadAll_EmptyStringPath()
        {
            string path = "";

            string actual = BaseFileWorker.ReadAll(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadLines_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile1.txt";
            string firstString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            string lastString = "Nunc malesuada vitae ex et porttitor.";
            int expectedLength = 5;

            string[] actual = BaseFileWorker.ReadLines(fullPath);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedLength, actual.Length);
            Assert.AreEqual(firstString, actual[0]);
            Assert.AreEqual(lastString, actual[actual.Length - 1]);
        }

        [TestMethod]
        public void Test_ReadLines_Existing_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile1.txt";
            string firstString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            string lastString = "Nunc malesuada vitae ex et porttitor.";
            int expectedLength = 5;

            string[] actual = BaseFileWorker.ReadLines(relativePath);

            Assert.IsNotNull(actual);
            Assert.AreEqual(expectedLength, actual.Length);
            Assert.AreEqual(firstString, actual[0]);
            Assert.AreEqual(lastString, actual[actual.Length - 1]);
        }

        [TestMethod]
        public void Test_ReadLines_NotExisting_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\jkrrtvrwereresftg.txt";

            string[] actual = BaseFileWorker.ReadLines(fullPath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadLines_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\jkrrtvrwereresftg.txt";

            string[] actual = BaseFileWorker.ReadLines(relativePath);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadLines_NullPath()
        {
            string path = null;

            string[] actual = BaseFileWorker.ReadLines(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_ReadLines_EmptyStringPath()
        {
            string path = "";

            string[] actual = BaseFileWorker.ReadLines(path);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void Test_MkDir_FullPath() 
        {
            string newDirFullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\TestFolder1";

            string newDirPath = BaseFileWorker.MkDir(newDirFullPath);

            Assert.AreEqual(newDirFullPath, newDirPath);
        }

        [TestMethod]
        public void Test_MkDir_RelativePath()
        {
            string newDirRelativePath = ".\\..\\..\\TestFiles\\TestFolder2";
            string newDirFullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\TestFolder2";

            string newDirPath = BaseFileWorker.MkDir(newDirRelativePath);

            Assert.AreEqual(newDirFullPath, newDirPath);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_MkDir_NullPath()
        {
            string newDirPath = null;

            string actualNewDirPath = BaseFileWorker.MkDir(newDirPath);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_MkDir_EmptyStringPath()
        {
            string newDirPath = "";

            string actualNewDirPath = BaseFileWorker.MkDir(newDirPath);
        }

        [TestMethod]
        public void Test_Write_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile2.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            bool result = BaseFileWorker.Write(text, fullPath);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_Write_NotExisting_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles34\\testFile2.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            bool result = BaseFileWorker.Write(text, fullPath);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_Write_Existing_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile2.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            bool result = BaseFileWorker.Write(text, relativePath);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_Write_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles34\\testFile2.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            bool result = BaseFileWorker.Write(text, relativePath);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_Write_NullPath()
        {
            string path = null;
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            bool result = BaseFileWorker.Write(text, path);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_Write_EmptyStringPath()
        {
            string path = "";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\r\n" +
                "Maecenas venenatis mauris quis justo eleifend facilisis.\r\n" +
                "Nunc malesuada vitae ex et porttitor.";

            bool result = BaseFileWorker.Write(text, path);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryWrite_Existing_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles\\testFile3.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, fullPath);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryWrite_NotExisting_FullPath()
        {
            string fullPath = "D:\\Software-Engineering-Components\\Lab2\\TestFiles34\\testFile3.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, fullPath);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryWrite_Existing_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile3.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, relativePath);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryWrite_NotExisting_RelativePath()
        {
            string relativePath = ".\\..\\..\\TestFiles34\\testFile3.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, relativePath);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryWrite_NullPath()
        {
            string path = null;
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, path);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryWrite_EmptyStringPath()
        {
            string path = "";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, path);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryWrite_OutOfRangeTries_Case1()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile4.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int minTries = 1;
            int tries = minTries - 1;

            bool result = BaseFileWorker.TryWrite(text, relativePath, tries);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryWrite_DefaultValueOfTries()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile4.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";

            bool result = BaseFileWorker.TryWrite(text, relativePath);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryWrite_InRangeTries_Case2()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile4.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int minTries = 1;
            int tries = minTries + 1;

            bool result = BaseFileWorker.TryWrite(text, relativePath, tries);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryWrite_InRangeTries_Case3()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile4.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int tries = int.MaxValue - 1;

            bool result = BaseFileWorker.TryWrite(text, relativePath, tries);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryWrite_InRangeTries_Case4()
        {
            string relativePath = ".\\..\\..\\TestFiles\\testFile4.txt";
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
            int tries = int.MaxValue;

            bool result = BaseFileWorker.TryWrite(text, relativePath, tries);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryCopy_RewriteTrue_ExistingPaths()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;

            bool result = BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite);

            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.IO.IOException))]
        public void Test_TryCopy_RewriteFalse_ExistingPaths()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = false;

            BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite);
        }

        [TestMethod]
        public void Test_TryCopy_RewriteTrue_NullPath()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;
            string nullPath = null;

            Assert.IsFalse(BaseFileWorker.TryCopy(nullPath, pathTo, rewrite));
            Assert.IsFalse(BaseFileWorker.TryCopy(pathFrom, nullPath, rewrite));
            Assert.IsFalse(BaseFileWorker.TryCopy(nullPath, nullPath, rewrite));
        }

        [TestMethod]
        public void Test_TryCopy_RewriteFalse_NullPath()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = false;
            string nullPath = null;

            Assert.IsFalse(BaseFileWorker.TryCopy(nullPath, pathTo, rewrite));
            Assert.IsFalse(BaseFileWorker.TryCopy(pathFrom, nullPath, rewrite));
            Assert.IsFalse(BaseFileWorker.TryCopy(nullPath, nullPath, rewrite));
        }

        [TestMethod]
        public void Test_TryCopy_OutOfRangeTries_Case1()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;
            int minTries = 1;
            int tries = minTries - 1;

            bool result = BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite, tries);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_TryCopy_DefaultValueOfTries()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;

            bool result = BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryCopy_InRangeTries_Case2()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;
            int minTries = 1;
            int tries = minTries + 1;

            bool result = BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite, tries);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryCopy_InRangeTries_Case3()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;
            int tries = int.MaxValue - 1;

            bool result = BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite, tries);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Test_TryCopy_InRangeTries_Case4()
        {
            string pathFrom = ".\\..\\..\\TestFiles\\TryCopyTestFile1.txt";
            string pathTo = ".\\..\\..\\TestFiles\\TryCopyTestFile2.txt";
            bool rewrite = true;
            int tries = int.MaxValue;

            bool result = BaseFileWorker.TryCopy(pathFrom, pathTo, rewrite, tries);

            Assert.IsTrue(result);
        }
    }
}
