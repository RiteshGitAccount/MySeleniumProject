using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumEndToEnd.BaseClass
{
   public class BaseTest
    {
        public IWebDriver driver;

        [SetUp]
        public void Open()
        {
            //Chrome driver will get called Bash File Updated 7 July 2021
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }

    }
}
