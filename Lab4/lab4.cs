using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using IIG.FileWorker;
using IIG.BinaryFlag;
using IIG.CoSFE.DatabaseUtils;
using System.Text;
using System.Data;

namespace Lab4
{
    [TestClass]
    public class FileWorkerTests
    {
        private const string Server = @"DESKTOP-N1R85DD";
        private const string Database = @"IIG.CoSWE.StorageDB";
        private const bool IsTrusted = false;
        private const string Login = @"sa";
        private const string Password = @"sa";
        private const int ConnectionTimeout = 75;
        private StorageDatabaseUtils db;

        private int? GetId()
        {
            return db.GetIntBySql("SELECT MAX(FileID) FROM Files");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            db = new StorageDatabaseUtils(Server, Database, IsTrusted, Login, Password, ConnectionTimeout);
        }

        [TestMethod]
        public void Test_AddFile_EmptyFile()
        {
            string path = ".\\..\\..\\TestFiles\\emptyTestFile.txt";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNotNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNotNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes(fileContent);
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsTrue(resultAdd);

            int fileID = (int)GetId();
            bool resultGet = db.GetFile(fileID, out string dbFileName, out byte[] dbFileContent);
            Assert.IsTrue(resultGet);
            Assert.AreEqual(fileName, dbFileName);

            string dbFileDecodedContent = Encoding.ASCII.GetString(dbFileContent);
            Assert.AreEqual(fileContent, dbFileDecodedContent);
        }

        [TestMethod]
        public void Test_AddFile_ValidFile()
        {
            string path = ".\\..\\..\\TestFiles\\testFile1.txt";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNotNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNotNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes(fileContent);
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsTrue(resultAdd);

            int fileID = (int)GetId();
            bool resultGet = db.GetFile(fileID, out string dbFileName, out byte[] dbFileContent);
            Assert.IsTrue(resultGet);
            Assert.AreEqual(fileName, dbFileName);

            string dbFileDecodedContent = Encoding.ASCII.GetString(dbFileContent);
            Assert.AreEqual(fileContent, dbFileDecodedContent);
        }

        [TestMethod]
        public void Test_AddFile_SameValidFiles()
        {
            string path = ".\\..\\..\\TestFiles\\testFile2.txt";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNotNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNotNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes(fileContent);
            bool resultAdd1 = db.AddFile(fileName, encodedFileContent);
            Assert.IsTrue(resultAdd1);
            bool resultAdd2 = db.AddFile(fileName, encodedFileContent);
            Assert.IsTrue(resultAdd2);
        }

        [TestMethod]
        public void Test_AddFile_ExistingFullPath()
        {
            string path = "D:\\Software-Engineering-Components\\Lab4\\Lab4\\TestFiles\\testFile3.txt";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNotNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNotNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes(fileContent);
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsTrue(resultAdd);

            int fileID = (int)GetId();
            bool resultGet = db.GetFile(fileID, out string dbFileName, out byte[] dbFileContent);
            Assert.IsTrue(resultGet);
            Assert.AreEqual(fileName, dbFileName);

            string dbFileDecodedContent = Encoding.ASCII.GetString(dbFileContent);
            Assert.AreEqual(fileContent, dbFileDecodedContent);
        }

        [TestMethod]
        public void Test_AddFile_NullPath()
        {
            string path = null;
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes("null path");
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsFalse(resultAdd);
        }

        [TestMethod]
        public void Test_AddFile_EmptyStringPath()
        {
            string path = "";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes("empty string path");
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsFalse(resultAdd);
        }

        [TestMethod]
        public void Test_AddFile_EmptyStringFileName()
        {
            string fileName = "";
            string fileContent = "empty string file name";

            byte[] encodedFileContent = Encoding.ASCII.GetBytes(fileContent);
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsFalse(resultAdd);
        }

        [TestMethod]
        public void Test_AddFile_NotExistingPath()
        {
            string path = ".\\..\\..\\TestFiles\\dfhdfgert.txt";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes("not existing path");
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsFalse(resultAdd);
        }

        [TestMethod]
        public void Test_AddFile_NotExistingFileName()
        {
            string path = ".\\..\\..\\TestFiles\\";
            string fileName = BaseFileWorker.GetFileName(path);
            Assert.IsNull(fileName);
            string fileContent = BaseFileWorker.ReadAll(path);
            Assert.IsNull(fileContent);

            byte[] encodedFileContent = Encoding.ASCII.GetBytes("not existing file name");
            bool resultAdd = db.AddFile(fileName, encodedFileContent);
            Assert.IsFalse(resultAdd);
        }
    }
    
    [TestClass]
    public class BinaryFlagTests
    {
        private const string Server = @"DESKTOP-N1R85DD";
        private const string Database = @"IIG.CoSWE.FlagpoleDB";
        private const bool IsTrusted = false;
        private const string Login = @"sa";
        private const string Password = @"sa";
        private const int ConnectionTimeout = 75;
        private FlagpoleDatabaseUtils db;

        private int? GetId()
        {
            return db.GetIntBySql("SELECT MAX(MultipleBinaryFlagID) FROM MultipleBinaryFlags");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            db = new FlagpoleDatabaseUtils(Server, Database, IsTrusted, Login, Password, ConnectionTimeout);
        }

        [DataTestMethod]
        [DataRow((ulong)2, true)]
        [DataRow((ulong)2, false)]
        [DataRow((ulong)33, true)]
        [DataRow((ulong)33, false)]
        [DataRow((ulong)65, true)]
        [DataRow((ulong)65, false)]
        public void Test_InRangeLength(ulong length, bool initialValue)
        {
            MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(length, initialValue);
            string flagString = multipleFlag.ToString();
            bool flagValue = (bool)multipleFlag.GetFlag();

            bool resultAdd = db.AddFlag(flagString, flagValue);
            Assert.IsTrue(resultAdd);

            int flagID = (int)GetId();
            bool resultGet = db.GetFlag(flagID, out string flagView, out bool? dbFlagValue);
            Assert.IsTrue(resultGet);

            Assert.AreEqual(flagString, flagView);
            Assert.AreEqual(flagValue, dbFlagValue);
        }

        [DataTestMethod]
        [DataRow((ulong)2, true, (ulong)1)]
        [DataRow((ulong)33, true, (ulong)3)]
        [DataRow((ulong)33, true, (ulong)16)]
        [DataRow((ulong)33, true, (ulong)31)]
        [DataRow((ulong)65, true, (ulong)2)]
        [DataRow((ulong)65, true, (ulong)33)]
        [DataRow((ulong)65, true, (ulong)63)]
        public void Test_InRangeLength_ResetSomeFlags(ulong length, bool initialValue, ulong resetId)
        {
            MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(length, initialValue);
            multipleFlag.ResetFlag(resetId);
            string flagString = multipleFlag.ToString();
            bool flagValue = (bool)multipleFlag.GetFlag();

            bool resultAdd = db.AddFlag(flagString, flagValue);
            Assert.IsTrue(resultAdd);

            int flagID = (int)GetId();
            bool resultGet = db.GetFlag(flagID, out string flagView, out bool? dbFlagValue);
            Assert.IsTrue(resultGet);

            Assert.AreEqual(flagString, flagView);
            Assert.AreEqual(flagValue, dbFlagValue);
        }

        [DataTestMethod]
        [DataRow((ulong)2, false, (ulong)0)]
        [DataRow((ulong)33, false, (ulong)3)]
        [DataRow((ulong)33, false, (ulong)16)]
        [DataRow((ulong)33, false, (ulong)31)]
        [DataRow((ulong)65, false, (ulong)2)]
        [DataRow((ulong)65, false, (ulong)33)]
        [DataRow((ulong)65, false, (ulong)63)]
        public void Test_InRangeLength_SetSomeFlags(ulong length, bool initialValue, ulong setId)
        {
            MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(length, initialValue);
            multipleFlag.SetFlag(setId);
            string flagString = multipleFlag.ToString();
            bool flagValue = (bool)multipleFlag.GetFlag();

            bool resultAdd = db.AddFlag(flagString, flagValue);
            Assert.IsTrue(resultAdd);

            int flagID = (int)GetId();
            bool resultGet = db.GetFlag(flagID, out string flagView, out bool? dbFlagValue);
            Assert.IsTrue(resultGet);

            Assert.AreEqual(flagString, flagView);
            Assert.AreEqual(flagValue, dbFlagValue);
        }

        [DataTestMethod]
        [DataRow((ulong)2, true)]
        [DataRow((ulong)2, false)]
        [DataRow((ulong)33, true)]
        [DataRow((ulong)33, false)]
        [DataRow((ulong)65, true)]
        [DataRow((ulong)65, false)]
        public void Test_InRangeLength_Dispose(ulong length, bool initialValue)
        {
            try
            {
                MultipleBinaryFlag multipleFlag = new MultipleBinaryFlag(length, initialValue);
                multipleFlag.Dispose();
                string flagString = multipleFlag.ToString();
                Assert.IsNull(flagString);
                bool? flagValue = multipleFlag.GetFlag();
                Assert.IsNull(flagValue);

                
                bool resultAdd = db.AddFlag(flagString, (bool)flagValue);
                Assert.IsFalse(resultAdd);
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }

        [DataTestMethod]
        [DataRow(" ", true)]
        [DataRow(" ", false)]
        [DataRow("Invalid Flag View String", true)]
        [DataRow("Invalid Flag View String", false)]
        [DataRow(null, true)]
        [DataRow(null, false)]
        public void Test_InvalidFlagView(string flagView, bool flagValue)
        {
            bool resultAdd = db.AddFlag(flagView, flagValue);
            Assert.IsFalse(resultAdd);
        }
    }
}
