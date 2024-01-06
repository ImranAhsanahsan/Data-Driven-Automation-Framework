using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA04imranexam
{
    [TestClass]
    public class DeleteTC
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "delt", DataAccessMethod.Sequential)]

        public void delt()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            LoginPage log = new LoginPage();
            log.userrr = username;
            log.passss = password;
            log.loginp();


            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Delete report");

            string sea = TestContext.DataRow["sea"].ToString();

            DeletePage del = new DeletePage();
             del.del1 = sea;
            


            del.deletep();




        }









    }



}
