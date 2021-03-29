using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Uploadfile
    {
        IWebDriver driver;

        [Test]

        public void Upload()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver\\New folder");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Navigate().GoToUrl("http://demo.guru99.com/test/upload/");

            Boolean boo = driver.FindElement(By.Id("terms")).Displayed;
            Console.WriteLine("status audio box: " + boo);
            Thread.Sleep(2000);

            IWebElement upfile = driver.FindElement(By.Id("uploadfile_0"));
            upfile.SendKeys("D:\\auto\\log\\Log1.txt");
            Thread.Sleep(2000);

            //Boolean boo = driver.FindElement(By.Id("terms")).Displayed;
            //Console.WriteLine("status audio box: " + boo);
            //Thread.Sleep(2000);

            driver.FindElement(By.Id("terms")).Click();
            Thread.Sleep(2000);

            Boolean boo1 = driver.FindElement(By.Id("terms")).Displayed;
            Console.WriteLine("status audio box: " + boo1);

            IWebElement sub = driver.FindElement(By.Id("submitbutton")); sub.Click();
            Thread.Sleep(2000);

            //String text = "has been successfully uploaded.";
            String text = "1 file";
            string text1 = driver.FindElement(By.XPath("//*[@id='res']/center ")).Text;
            Console.WriteLine("The expected  :" + text1);

            if (text.Equals(text1))
            {
                Console.WriteLine("The expected heading is same as actual heading-- - :" + text1);
            }
            else
                Console.WriteLine("The expected heading doesn't match the actual heading --- :" + text1);
            //var t = Regex.Split(text.Text, "\r\n")[1];

            //if (text =='has been successfully uploaded.')
            //{
            //Console.WriteLine("case pass: " + text);
            //}
            //else Console.WriteLine("case failed: " + sub.Text);


            driver.Close();

        }

    }
}
