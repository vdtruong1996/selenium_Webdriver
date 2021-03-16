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
using OpenQA.Selenium.Interactions.Internal;

namespace ConsoleApp3
{
    class XPath_Example
    {
        IWebDriver driver;

        [Test]
        public void Mouse_Click()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(20);
            driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(20);

            // WebPage which contains a WebTable
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Using contains() to locate full name and enter data
            driver.FindElement(By.XPath("//input[contains(@id, 'userN')]")).SendKeys("User Name");
            Thread.Sleep(2000);

            //using placeholder
            driver.FindElement(By.XPath("//input[contains(@placeholder, 'example')]")).SendKeys("Using Placeholder");
           Thread.Sleep(2000);

            //using start-with() 
            driver.FindElement(By.XPath("//input[starts-with(@placeholder,'Fu')]")).SendKeys("Using start with");
            Thread.Sleep(2000);

            //using text() to get label
            String text = driver.FindElement(By.XPath("//label[text()='Email']")).Text;
            Thread.Sleep(2000);
            //System.out.println(text);
            Console.WriteLine("text is : " + text);

            //using AND operator to locate full name
            driver.FindElement(By.XPath("//input[@placeholder ='Full Name' and @type = 'text']")).SendKeys("AND operator");
            Thread.Sleep(2000);

            //using OR operator to locate full name
            driver.FindElement(By.XPath("//input[@placeholder ='Full Name' or @type = 'text']")).SendKeys("OR operator");
            Thread.Sleep(2000);

            //using ancestor to locate form tag
            Boolean bol = driver.FindElement(By.XPath("//label[text()='Full Name']/ancestor::form")).Displayed;
            Thread.Sleep(2000);
            //System.out.println("Form is displayed : " + bol);
            Console.WriteLine("Form is displayed : " + bol);

            //using child to locate full name textbox from form
            String label = driver.FindElement(By.XPath("//form[@id='userForm']/child::div[1]//label")).Text;
            Thread.Sleep(2000);
            //System.out.println("The label text is : " + label);
            Console.WriteLine("The label text is : " + label);


            //using decendent axis to locate yes radio
            driver.Navigate().GoToUrl("https://www.demoqa.com/radio-button");
            driver.FindElement(By.XPath("//div[@class= 'custom-control custom-radio custom-control-inline']/descendant::input/following-sibling::label")).Click();
            Thread.Sleep(2000);

            //using parent axis to locate yes radio
            Boolean bo = driver.FindElement(By.XPath("//input[@id='yesRadio']/parent::div")).Selected;
            Thread.Sleep(2000);
            //System.out.println("The Yes radio is selected : " + bo);
            Console.WriteLine("The Yes radio is selected : " + bo);


            //using following axis to locate current address
            driver.Navigate().GoToUrl("https://demoqa.com/text-box");
            driver.FindElement(By.XPath("//input[@id=\"userName\"]/following::textarea")).SendKeys("Text Area locate following");
            Thread.Sleep(2000);

            //using following-sibling to locate email 
            driver.FindElement(By.XPath("(//div[@class='col-md-3 col-sm-12']/following-sibling::div/input)[2]")).SendKeys("abc@xyz.com");
            Thread.Sleep(2000);

            //using preceding-axis to locate full name
            String preceding = driver.FindElement(By.XPath("//input[@id='userName']/preceding::label")).Text;
            Thread.Sleep(2000);
            //System.out.println("The value of preceding : " + preceding);
            Console.WriteLine("The value of preceding : " + preceding);


            driver.Close();

        }
    }
}
