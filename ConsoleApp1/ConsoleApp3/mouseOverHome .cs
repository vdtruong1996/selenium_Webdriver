using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using OpenQA.Selenium.Interactions;
using NUnit.Framework.Internal;
using OpenQA.Selenium.Support;
using BenchmarkDotNet.Toolchains.Roslyn;

namespace ConsoleApp3
{
    class mouseOverHome
    {
        IWebDriver driver;

        [Test]
        public void Mouse()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement link_Home = driver.FindElement(By.LinkText("Home"));

            IWebElement td_Home = driver
                        .FindElement(By
                        .XPath("//html/body/div"
                        + "/table/tbody/tr/td"
                        + "/table/tbody/tr/td"
                        + "/table/tbody/tr/td"
                        + "/table/tbody/tr"));

            Actions action = new Actions(driver);

            Action mouseOverHome = Builder.moveToElement(link_Home).build();







        }

    }
}
