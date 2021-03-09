using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace automation_test
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
        
            driver = new ChromeDriver();
        }
        [Test]

        public void OpenAppTest()
        {
            driver.Url = "https://www.demoqa.com";
        }
        [TearDown]

        public void EnTest()
        {
            driver.Close();
        }
    }

}
