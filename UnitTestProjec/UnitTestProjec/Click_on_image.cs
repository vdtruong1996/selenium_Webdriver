using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;

namespace UnitTestProjec
{
    class Click_on_image
    {
        IWebDriver driver;

        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(InvalidProgramException));
            try
            {
                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        static void Main(string[] args)
        {
            Testing();
            Console.ReadLine();
        }



        [Test]
        public void BT2()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            Thread.Sleep(2000);

            driver.Url = "https://www.guru99.com/";
            Thread.Sleep(2000);
            //driver.Manage().Window.Maximize();
            //ILogs = driver.Manage().Logs.GetLog(LogType.Browser);

            //click on the "Guru99" logo on the upper left portion
            driver.FindElement(By.CssSelector("#logo-7552-particle > a > img")).Click();
            Thread.Sleep(2000);

            //verify that we are now back on Guru99's homepage
            if (driver.Url.Equals("https://www.guru99.com/"))
            {
                Console.WriteLine("We are back at Guru99's homepage");
            }
            else
            {
                Console.WriteLine("We are not in Guru99's homepage");
            }

            driver.Close();


        }
    }
}
