using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support;
using System.Threading;
using System.Text.RegularExpressions;


namespace ConsoleApp2
{
    class Prompt_Alerts
    {
        IWebDriver driver;
        //public object arguments;

        [Test]
         public void alert()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver\\New folder");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://toolsqa.com/handling-alerts-using-selenium-webdriver/");

            IWebElement ele = driver.FindElement(By.XPath("//*[@id='promtButton']"));

            //ele.Click();

            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", ele);

            IAlert prompt = driver.SwitchTo().Alert();

            string alertText = prompt.Text;
            Console.WriteLine("alert is text:" + alertText);

            prompt.SendKeys("ok");

            Thread.Sleep(2000);

            prompt.Accept();

            driver.Close();

        }


    }
}
