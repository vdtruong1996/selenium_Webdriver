using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Class2
    {
        IWebDriver n_driver;

        [Test]
        public void cssDemo()
        {
            n_driver = new ChromeDriver("D:\\auto\\chromedriver");
            n_driver.Url = "http://demo.guru99.com/test/guru99home/";
            //n_driver.Manage().Window.Maximize();

            IWebElement course = n_driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new SelectElement(course);
            // Select a value from the dropdown				
            selectTest.SelectByValue("awlist3483297");
            System.Threading.Thread.Sleep(5000);

            //driver.navigate().back();
            //m_driver.Navigate().Refresh();

            n_driver.Close();


            //if (signUpButton != null)
            //{
            //    Console.WriteLine("Test Passed :) ");
            //}
            //else
            //{
            //    Console.WriteLine("Test Failed");
            //}

            //m_driver.Close();


        }

    }
}
