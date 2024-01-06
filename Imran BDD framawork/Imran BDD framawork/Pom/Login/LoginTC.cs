using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA04imranexam
{

    [TestClass]
    public class LoginTC
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
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "logint", DataAccessMethod.Sequential)]

        public void logint()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");
          //  string company = TestContext.DataRow["company"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();


            LoginPage log = new LoginPage();

            log.userrr = username;
            log.passss = password;
            log.loginp();


        } 


    }










}


