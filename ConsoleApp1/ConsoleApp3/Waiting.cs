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
using OpenQA.Selenium.Interactions;



namespace ConsoleApp3
{
    class Waiting
    {
        IWebDriver driver;

        [Test]
        public void Wait()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            driver.Manage().Timeouts().ImplicitWait =  TimeSpan.FromSeconds(10);

            //IWebElement WebElement;

            //By byLocator = By.Id("myElementId");
            //WebElement = driver.FindElement(byLocator);
            Actions action = new Actions(driver);
            //action.MoveToElement(WebElement).Click().Perform();

            // Enter the Full Name
            IWebElement fullName = driver.FindElement(By.Id("userName"));
            fullName.SendKeys("Mr.Peter Haynes");
            Thread.Sleep(2000);

            //Enter the Email
            IWebElement email = driver.FindElement(By.Id("userEmail"));
            email.SendKeys("PeterHaynes@toolsqa.com");
            Thread.Sleep(2000);


            // Enter the Current Address
            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));

            currentAddress.SendKeys("43 School Lane London EC71 9GO");
            Thread.Sleep(2000);


            // Select the Current Address using CTRL + A
            action.KeyDown(Keys.Control);
            action.SendKeys("a");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);

            // Copy the Current Address using CTRL + C
            action.KeyDown(Keys.Control);
            action.SendKeys("c");
            action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);

            //Press the TAB Key to Switch Focus to Permanent Address
            action.SendKeys(Keys.Tab);
            action.Build().Perform();
            Thread.Sleep(2000);

            //Paste the Address in the Permanent Address field using CTRL + V
            //IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
            action.KeyDown(Keys.Control);
            action.SendKeys("v");
            //action.KeyUp(Keys.Control);
            action.Build().Perform();
            Thread.Sleep(2000);

            ////Compare Text of current Address and Permanent Address
            IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
            permanentAddress.GetAttribute("value");
            assertEquals(currentAddress.GetAttribute("value"), permanentAddress.GetAttribute("value"));

            if(permanentAddress != null)
            {
                Console.Write("case failed: " );
            }
            else Console.Write("case passed: ");

            driver.Close();

            
            

        }

        //public void assertEquals(string v1, string v2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
