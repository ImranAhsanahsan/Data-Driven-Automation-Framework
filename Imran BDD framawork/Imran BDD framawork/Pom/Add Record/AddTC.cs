using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace SQA04imranexam
{

    [TestClass]
    public class AddTC
    {

        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [TestInitialize]
        public void TestInit()
        {
            BasePage.browserinitialization();
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            BasePage.driver.Quit();
        }


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "addt", DataAccessMethod.Sequential)]

        public void addt()
        {


            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            LoginPage log = new LoginPage();
            log.userrr = username;
            log.passss = password;
            log.loginp();


            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Add report");

            string f = TestContext.DataRow["f"].ToString();
            string m = TestContext.DataRow["m"].ToString();
            string l = TestContext.DataRow["l"].ToString();
           
            AddPage addpagee = new AddPage();
            addpagee.firstnamee = f;
            addpagee.midnamee = m;
            addpagee.lastnamee = l;

           

            addpagee.addp();














        }


    }
}
