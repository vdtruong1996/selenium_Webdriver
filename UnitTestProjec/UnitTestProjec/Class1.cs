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

namespace UnitTestProjec
{

    class Class1
    {
        IWebDriver driver;

        [Test]
        public void Test()
        {
            IWebDriver driver = new ChromeDriver("D:\\auto\\chromedriver");

         

            //Launch the ToolsQA Website
            driver.Url = "http://demo.guru99.com/test/newtours/";
            driver.Manage().Window.Maximize();

            IWebElement link = driver.FindElement(By.XPath("./html/body/div[1]/div[2]/nav/div/div/ul/li[4]/a"));
            link.Click();
            Thread.Sleep(2000);

            IWebElement userTextBox = driver.FindElement(By.XPath("./html/body/form/table/tbody/tr[1]/td[2]/input"));
            userTextBox.SendKeys("1303");
            Thread.Sleep(2000);

            IWebElement Clear = driver.FindElement(By.Name("uid"));
            Clear.Clear();
            Thread.Sleep(2000);

            IWebElement userTextBox_1 = driver.FindElement(By.Name("uid"));
            userTextBox_1.SendKeys("1303");
            Thread.Sleep(2000);

            IWebElement element = driver.FindElement(By.XPath("./html/body/form/table/tbody/tr[1]/td[2]/input"));
            Boolean status = element.Displayed;
            Thread.Sleep(2000);

            IWebElement passWord = driver.FindElement(By.XPath("./html/body/form/table/tbody/tr[2]/td[2]/input"));
            passWord.SendKeys("Guru99");
            Thread.Sleep(2000);

            IWebElement element_1 = driver.FindElement(By.Name("password"));
            Boolean status_1 = element.Displayed;
            Thread.Sleep(2000);

            IWebElement Login = driver.FindElement(By.XPath("./html/body/form/table/tbody/tr[3]/td[2]/input[1]"));
            Login.Click();
            Thread.Sleep(2000);

            driver.Navigate().Back();
            Thread.Sleep(2000);

            driver.Navigate().Back();
            Thread.Sleep(2000);

            driver.Navigate().Refresh();

            driver.Close();
        }
    }
}