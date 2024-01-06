using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA04imranexam
{
    [TestClass]
    public class UpdateTC
    {


        //[ClassCleanup]

        //public static void TestClose()
        //{
        //}

        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }


        [AssemblyInitialize]
        public static void Assemblyinit(TestContext testContext)
        {
            ExtentReport.LogReport("Test Report");

        }

        [AssemblyCleanup]
        public static void Assemblyclean()
        {
            ExtentReport.extentReports.Flush();

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

        //[ClassInitialize] 
        ////public static void ClassInit(TestContext context) //(TestContext context)
        ////{


        ////}


        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"data.xml", "updatet", DataAccessMethod.Sequential)]

        public void updatet()
        {

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login");
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();
            LoginPage log = new LoginPage();
            log.userrr = username;
            log.passss = password;
            log.loginp();

            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("update report");
            string sea = TestContext.DataRow["sea"].ToString();
            UpdatePage upd = new UpdatePage();

            upd.del1 = sea;
                upd.updatep();




        }






    }




}












































//javascript for scroll
//IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
//js1.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");