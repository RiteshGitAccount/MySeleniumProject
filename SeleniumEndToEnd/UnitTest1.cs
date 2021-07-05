using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumEndToEnd.BaseClass;
using System.Threading;

namespace SeleniumEndToEnd
{
    public class Tests : BaseTest
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test,Category("Regression")]
        public void Test1()
        {

            IWebElement emailtextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailtextField.SendKeys("Enter Email");
            Thread.Sleep(2000);
            driver.Close();

        }
        [Test, Category("Smoke")]
        public void Test2()
        {

            IWebElement emailtextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailtextField.SendKeys("Enter Email");
            Thread.Sleep(2000);
            driver.Close();

        }
        [Test, Category("E2E")]
        public void Test3()
        {

            IWebElement emailtextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailtextField.SendKeys("Enter Email");
            Thread.Sleep(2000);
            driver.Close();

        }

        //[Clean]
        //public void CleanTestRun()
        //{

        //}
        
      
    }
}