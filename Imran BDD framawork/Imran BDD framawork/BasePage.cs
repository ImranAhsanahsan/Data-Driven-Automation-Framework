using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA04imranexam
{
   

    public class BasePage
    {

        public static IWebDriver driver;


        public static void browserinitialization()
        {
            driver = new ChromeDriver();

            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            driver.Manage().Window.Maximize();

        }

        public void sendkeyy(By by, string data)
        {
          

            try
            {

                IWebElement element = WaitForElement(by);
                element.SendKeys(data);
                TakeScreenshot(Status.Pass, "PASS TEST");
            }

            catch
            {
                TakeScreenshot(Status.Fail, "FAIL TEST");

            }
        }



        public void simplesendkey(By by, string data)
        {
            driver.FindElement(by).SendKeys(data);

        }


        public void sendkeyyy(By by, string data, By imran)
        {
           

            try
            {

                IWebElement element = WaitForElement(by);
                element.SendKeys(data);
                IWebElement elementt = WaitForElement(imran);
                TakeScreenshot(Status.Pass, "PAss test");
            }

            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }



        public void click(By by)
        {
            // driver.FindElement(by).Click();
            try
            {
                IWebElement element = WaitForElement(by);
                element.Click();
                TakeScreenshot(Status.Pass, "PAss test");

            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }

        }




        public void cli(By by, By imran)
        {
            
            driver.FindElement(by).Click();
            IWebElement element = WaitForElement(imran);
        }

        public void cle(By by)
        {
            driver.FindElement(by).Click();

        }



        public void clickk(By imran, By hashmi)
        {
            // driver.FindElement(by).Click();
            try
            {
                driver.FindElement(imran).Click();
                IWebElement element = WaitForElement(hashmi);
                TakeScreenshot(Status.Pass, "PAss test");

            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }



        public void clear(By by)
        {
            // driver.FindElement(by).Clear();
            try
            {
                IWebElement element = WaitForElement(by);
                element.Clear();
                TakeScreenshot(Status.Pass, "PAss test");
            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");
            }
        }




        public static void TestClose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }




        public IWebElement WaitForElement(By by)
        {
            IWebElement element;

            try
            {
                element = driver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true);
                element = driver.FindElement(by);
            }

            return element;


        }


        private bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
        }

        private bool IsElementVisible(By by)
        {
            if (driver.FindElement(by).Enabled || driver.FindElement(by).Displayed == true)
                return true;

            else
                return false;
        }




        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\ImranAhsan\source\repos\SQA04imranexam\SQA04imranexam\bin\images\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }

















    }











}
















































































































    