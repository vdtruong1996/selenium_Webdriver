using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        IWebDriver m_driver;

        [Test]
        public void cssDeme()
        {
            m_driver = new ChromeDriver("D:\\auto\\chromedriver");
            //driver.Url = "http://demo.guru99.com/test/selenium-xpath.html";
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            //m_driver.Manage().Window.Maximize();

            // Store locator values of email text box and sign up button		

            IWebElement emailTextBox = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            emailTextBox.SendKeys("abc@123gmail.com");

            IWebElement signUpButton = m_driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

            signUpButton.Click();

            //driver.navigate().back();
            //m_driver.Navigate().Refresh();

            //m_driver.Close();


        }

    }
}
