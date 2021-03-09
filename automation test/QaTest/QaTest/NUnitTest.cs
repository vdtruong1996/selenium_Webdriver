using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace QaTest
{
    class NUnitTest
    {
        IWebDriver driver;

        [SetUp]
        public void initialize()
        {
            driver = new ChromeDriver("D:\\auto\\automation test");
        }

        [Test]
        public void OpenTest()
        {
            driver.Url = "https://www.demoqa.com";
        }

        [Test]
        public void Refres()
        {
            driver.Navigate().Refresh();
        }

        //[TearDown]
        //public void Clos()
        //{
        //    driver.Close();
        //}

    }
}
