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

        //public void Testing()
        //{
        //    log4net.Config.BasicConfigurator.Configure();
        //    log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        //    try
        //    {
        //        string str = String.Empty;
        //        string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error Message: " + ex.Message.ToString(), ex);
        //    }
        //}

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

            //Click_on_image click_On_Image = new Click_on_image();
            //click_On_Image.Testing_1();

            Console.WriteLine("cssDeme");

            Program program = new Program();
            program.Testing_2();



            //driver.navigate().back();
            //m_driver.Navigate().Refresh();

            //m_driver.Close();
            //log.Debug();


        }

    }
}
