using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CSS
    {
        IWebDriver driver;

        [Test]
        public void cssDemo()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            //driver.Url = "http://demo.guru99.com/test/selenium-xpath.html";
            driver.Url = "https://www.google.com/";
            //driver.Manage().Window.Maximize();

            IWebElement emailTextBox = driver.FindElement(By.XPath("./html/body/div[1]/div[3]/form/div[2]/div[1]/div[1]/div/div[2]/input"));
            emailTextBox.SendKeys("manchester united");


            IWebElement signUpButton = driver.FindElement(By.XPath("./html/body/div[1]/div[3]/form/div[2]/div[1]/div[3]/center/input[1]"));
            signUpButton.Click();
            System.Threading.Thread.Sleep(1000);

            //IWebElement link = driver.FindElement(By.XPath("./html/body/div[2]/div[1]/div/h4[1]/b")); link.Click();

            driver.Navigate().Back();
            System.Threading.Thread.Sleep(1000);
            //driver.Navigate().Refresh();
            IWebElement links = driver.FindElement(By.XPath("./html/body/div[1]/div[3]/form/div[2]/div[1]/div[3]/center/input[2]")); 
            links.Click();
            System.Threading.Thread.Sleep(1000);

            driver.Navigate().Back();
            System.Threading.Thread.Sleep(1000);

            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(1000);

            driver.Close();


        }
        
    }
}
