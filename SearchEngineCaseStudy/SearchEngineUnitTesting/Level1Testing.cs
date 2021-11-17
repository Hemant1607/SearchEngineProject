using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SearchEngineCaseStudy;
using System.IO;

namespace SearchEngineUnitTesting
{
    [TestClass]
    public class Level1Testing
    {
        
        [TestMethod]
        public void SearchActiveInActiveDeives_Test_Return_True()
        {
            bool actual = Level1.SearchActiveInactiveDrives();
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void DisplayAllDrives_Return_True()
        {
            bool actual = Level1.DisplayAllDrives();
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SearchFile_return_true()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\heartidb");
            bool actual = Level2.SearchFile(dinfo, "dummy.txt");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SearchFile_return_false()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\training");
            bool actual = Level2.SearchFile(dinfo, "dummy.txt");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void SearchFile_repeat_return_true()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\");
            bool actual = Level2.SearchFile(dinfo, "dummy.txt");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SearchDirectory_return_true()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\");
            bool actual = Level2.SearchDirectory(dinfo, "dummy.txt");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SearchDirectory_return_flase()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\training\");
            bool actual = Level2.SearchDirectory(dinfo, "dummy.txt");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]

        public void Level3_SearchFile_return_true()
        {
            FileInfo filename = new FileInfo("Sample.txt");
            bool actual = Level3.SearchFile(filename, "Sample.txt");
            Assert.AreEqual(true, actual);
        }

        [TestMethod]

        public void Level3_SearchFile_return_false()
        {
            FileInfo filename = new FileInfo("abc.txt");
            bool actual = Level3.SearchFile(filename, "Sample.txt");
            Assert.AreEqual(false, actual);
        }

       

        [TestMethod]
        public void Level3_ParallelSearch_Return_true()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\");
            Level3.ParallelSearch(dinfo,"dummy.txt");
            int actual = Level3.found;
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void Level3_ParallelSearch_Return_false()
        {
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\");
            Level3.ParallelSearch(dinfo, "def.txt");
            int actual = Level3.found;
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Level4_CheckHistory_Check_1()
        {
             Level4.CheckHistory("sample.txt");
            int actual = Level4.check;
            Assert.AreEqual(1, actual);
             
        }

        [TestMethod]
        public void Level4_CheckHistory_Check_2()
        {
            Level4.CheckHistory("History.txt");
            int actual = Level4.check;
            Assert.AreEqual(2, actual);

        }

        [TestMethod]
        public void Level4_CheckHistory_Check_0()
        {
            Level4.CheckHistory("def.txt");
            int actual = Level4.check;
            Assert.AreEqual(0, actual);

        }

    }

   
}
