using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using System.Runtime.Serialization;

namespace UnitTestProjec
{
    class Class3
    {
        IWebDriver driver;


        [Test]

        public void Parent()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            driver.Url = "https://www.demoqa.com/";
            Thread.Sleep(10000);
            driver.Manage().Window.Maximize();
            //var alert_win = driver.SwitchTo().Alert();

            IWebElement element = driver.FindElement(By.ClassName("card-up"));
            element.Click();
            Thread.Sleep(2000);

            IWebElement element_1 = driver.FindElement(By.Id("item-4"));
            element_1.Click();
            Thread.Sleep(2000);


            IWebElement Pa = driver.FindElement(By.ClassName("mt-4"));
            IWebElement sta = Pa.FindElement(By.ClassName("btn btn-primary")); sta.Click();
            bool status = sta.Displayed;

            Console.WriteLine(" Content is true:" + status);


            String tagName = driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div[2]/div[1]/div[3]")).TagName;
            Console.WriteLine(" Content is true:" + tagName);

            ////IWebElement Parent_element = driver.FindElement(By.ClassName("mt-4"));
            //IWebElement lement = driver.FindElement(By.XPath(".//p[@id='dynamicClickMessage']"));
            ////Chilrent_element.Click();
            //Thread.Sleep(2000);




 

            //driver.Close();

        }
    }



}

