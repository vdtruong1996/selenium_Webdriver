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

namespace ConsoleApp2
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

            m_driver.SwitchTo().Alert().Dismiss();
            

            // Store locator values of email text box and sign up button		

            IWebElement emailTextBox = m_driver.FindElement(By.Name("cusid"));
            emailTextBox.SendKeys("test123@gmail.com");
            Thread.Sleep(2000);

            IWebElement signUpButton = m_driver.FindElement(By.Name("submit"));
            signUpButton.Click();
            Thread.Sleep(2000);

            m_driver.SwitchTo().Alert().Dismiss();

            m_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            IWebElement emailTextBox1 = m_driver.FindElement(By.Name("cusid"));
            emailTextBox1.SendKeys("test123@gmail.com");
            Thread.Sleep(2000);

            string alerMessage = m_driver.SwitchTo().Alert().Text;

            Console.WriteLine("tin nhan:" + alerMessage);
            Thread.Sleep(5000);

            m_driver.SwitchTo().Alert().Accept();






            //Click_on_image click_On_Image = new Click_on_image();
            //click_On_Image.Testing_1();

            //driver.navigate().back();
            //m_driver.Navigate().Refresh();

            m_driver.Close();





        }

    }
}
