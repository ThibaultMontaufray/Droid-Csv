using Assistant;
using Droid_csv_files;
using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest
    {
        [Test]
        public void TestUTRuns()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void Test_interface_csv()
        {
            try
            {
                Interface_csv intcsv = new Interface_csv(new System.Collections.Generic.List<string>());
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        //[Test]
        //public void Test_display_conversion()
        //{
        //    try
        //    {
        //        Interface_csv intcsv = new Interface_csv(new System.Collections.Generic.List<string>());
        //        Conversion c = new Conversion(intcsv);
        //        Assert.IsTrue(true);
        //    }
        //    catch (System.Exception exp)
        //    {
        //        Assert.Fail(exp.Message);
        //    }
        //}
        [Test]
        public void Test_demo_form()
        {
            try
            {
                GUI g = new GUI();
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_panelGridView()
        {
            try
            {
                ToolStripMenuCSV tsm = new ToolStripMenuCSV(new System.Collections.Generic.List<string>());
                PanelGridView p = new PanelGridView(tsm, "a;z;e;r;t;y");
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
        [Test]
        public void Test_panelTextBox()
        {
            try
            {
                ToolStripMenuCSV tsm = new ToolStripMenuCSV(new System.Collections.Generic.List<string>());
                PanelTextBox p = new PanelTextBox(tsm, "a;z;e;r;t;y");
                Assert.IsTrue(true);
            }
            catch (System.Exception exp)
            {
                Assert.Fail(exp.Message);
            }
        }
    }
}
