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
    class Multiple_Window
    {
        IWebDriver driver;
        //public object arguments;

        [Test]
        public void Window()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver\\New folder");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("https://demoqa.com/browser-windows");

            //IWebElement elet = ("https://demoqa.com/browser-windows");

            //IWebElement ele = driver.FindElement(By.XPath("//*[@id='promtButton']"));
            string WindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("window is handle: " + WindowHandle);

            IWebElement ele = driver.FindElement(By.Id("windowButton"));

            //IWebElement clickElement = driver.FindElement(By.Id("button1"));

            // Multiple click to open multiple window
            for (var i = 0; i < 3; i++)
            {
                ele.Click();
                Thread.Sleep(3000);
            }

            List<string> lstWindow = driver.WindowHandles.ToList();
            foreach (var handle in lstWindow)
            {
                Console.WriteLine("Switching to window - > " + handle);
                Console.WriteLine("Navigating to google.com");
                Thread.Sleep(2000);

                driver.SwitchTo().Window(handle);
                Thread.Sleep(2000);
                driver.Navigate().GoToUrl("https://google.com");
                Thread.Sleep(2000);
            }

            //IWebElement ele1 = driver.FindElement(By.Id("messageWindowButton")); ele1.Click();
            //IAlert abc = driver.SwitchTo().Alert();
            //string al = abc.Text;
            //Console.WriteLine("text is a:" + al);

            //abc.Dismiss();

            driver.Quit();

        }
    }
}
