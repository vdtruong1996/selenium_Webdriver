using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Threading;
using OpenQA.Selenium.Support;

namespace UnitTestProjec
{
    class Checkbox_and_Radiobox
    {
        IWebDriver driver;

        [Test]
        public void BT1()
        {
            driver = new ChromeDriver("D:\\auto\\chromedriver");
            

            driver.Url = "http://demo.guru99.com/test/radio.html";
            //driver.Manage().Window.Maximize();

            IWebElement radio1 = driver.FindElement(By.Id("vfb-7-1"));
            IWebElement radio2 = driver.FindElement(By.Id("vfb-7-2"));

            //radio1 is selected
            radio1.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Radio Button Option 1 Selected");
            //radio2 is selected
            radio2.Click();
            Thread.Sleep(2000);
            Console.WriteLine("Radio Button Option 2 Selected");

            if (radio1.Selected)
            {
                Console.WriteLine("radio1 is Toggled On");
            }
            else
            {
                Console.WriteLine("radio1 is Toggled Off");
            }

            IWebElement option1 = driver.FindElement(By.Id("vfb-6-0"));
            //selecting checkBox
            option1.Click();
            Thread.Sleep(2000);

            IWebElement option_1 = driver.FindElement(By.Id("vfb-6-0")); option_1.Click();
            Thread.Sleep(2000);

            //check whether the check box is toggle on
            if (!option1.Selected)
            {
                Console.WriteLine("Checkbox1 is now Toggled off");
            }
            else
            {
                Console.WriteLine("Checkbox1 is now Toggled on");
            }

            IWebElement option2 = driver.FindElement(By.Id("vfb-6-1"));
            option2.Click();
            Thread.Sleep(2000);

            if (option2.Selected)
            {
                Console.WriteLine("Checkbox2 is Toggled On");
            }
            else
            {
                Console.WriteLine("Checkbox2 is Toggled Off");
            }


            driver.Close();


        }

    }
}
