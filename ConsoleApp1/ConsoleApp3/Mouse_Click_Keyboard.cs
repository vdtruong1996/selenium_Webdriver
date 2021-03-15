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
using OpenQA.Selenium.Interactions.Internal;

namespace ConsoleApp3
{
    class Mouse_Click_Keyboard
    {
        IWebDriver driver;

        [Test]
        public void Mouse_Click()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            //driver.Manage().Window.Maximize();

            // WebPage which contains a WebTable
            driver.Navigate().GoToUrl("http://demo.guru99.com/test/newtours/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            IWebElement link_home = driver.FindElement(By.LinkText("Home"));
            IWebElement td_home = driver.FindElement(By.XPath("/html/body/div[2]/table/tbody/tr/td[1]/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr[1]/td[2]/font/a"));

            //Action a = new Action(driver);



        }
    }
}
