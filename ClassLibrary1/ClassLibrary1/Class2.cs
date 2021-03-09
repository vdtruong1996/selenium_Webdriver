using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestProject1
{
    class Class1
    {
        IWebDriver driver;

        [SetUp]
        public void initial()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void OpenTest()
        {
            driver.Url = "https://www.google.com";
        }

        [TearDown]
        public void CLose()
        {
            driver.Close();
        }

    }
}