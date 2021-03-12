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

namespace ConsoleApp3
{
    class LinkTex_and_PartialLink
    {
        IWebDriver driver;

        [Test]
        public void linktext()
        {
            //get log
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                //string str = String.Empty;
                //string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty. 
                //Console.WriteLine("title of page: " + driver.Title + driver.Url);
                driver = new ChromeDriver("D:\\auto\\chromedriver");
                driver.Navigate().GoToUrl("http://demo.guru99.com/test/link.html");

                //driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                IWebElement link = driver.FindElement(By.LinkText("click here"));
                link.Click();
                Console.WriteLine("title of page: " + driver.Title );
                Console.WriteLine("title of page: " + driver.Url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message: " + ex.Message.ToString(), ex);
                //Console.WriteLine("title of page: " + driver.Title + driver.Url);
            }

            //driver = new ChromeDriver("D:\\auto\\chromedriver");
            //driver.Navigate().GoToUrl("http://demo.guru99.com/test/link.html");

            ////driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //IWebElement link = driver.FindElement(By.LinkText("click here"));
            //link.Click();
            Thread.Sleep(5000);

            //Console.WriteLine("title of page: " + driver.Title + driver.Url);

            driver.Close();
        }
    }
}
