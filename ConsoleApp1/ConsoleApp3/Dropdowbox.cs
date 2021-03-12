using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
//using System.Collections.Generic;

namespace ConsoleApp3
{
    class Dropdowbox
    {
        IWebDriver m_driver;

        [Test]
        public void cssDeme()
        {
            m_driver = new ChromeDriver("D:\\auto\\chromedriver");
            m_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //driver.Url = "http://demo.guru99.com/test/selenium-xpath.html";
            m_driver.Url = "http://demo.guru99.com/test/newtours/register.php";
            //m_driver.Manage().Window.Maximize();

            //IWebElement Drop_1 = m_driver.FindElement(By.Name("country")); Drop_1.Clear();
            Thread.Sleep(2000);

            IWebElement Drop = m_driver.FindElement(By.Name("country"));
            SelectElement oSelection = new SelectElement(Drop);

            oSelection.SelectByText("ALGERIA");

            // Using sleep command so that changes can be notice
            Thread.Sleep(2000);

            // Step 5: Select option 'Africa' now (Use selectByVisibleText)
            //oSelection.SelectByIndex(2);
            //Thread.Sleep(2000);

            // Step 6: Print all the options for the selected drop down and select one option of your choice
            // Get the size of the Select element
            IList<IWebElement> oSize = oSelection.Options;

            int iListSize = oSize.Count;
            // Setting up the loop to print all the options
            for (int i = 0; i < iListSize; i++)
            {
                // Storing the value of the option 
                String sValue = oSelection.Options.ElementAt(i).Text;
                // Printing the stored value
                Console.WriteLine("Value of the Select item is : " + sValue);

                // Putting a check on each option that if any of the option is equal to 'Africa" then select it 
                if (sValue.Equals("AUSTRALIA"))
                {
                    oSelection.SelectByIndex(i);
                    Thread.Sleep(2000);
                    break;
                }

            }

            Thread.Sleep(2000);

            m_driver.Close();

            Console.WriteLine("cssDeme");

            Program program = new Program();
            program.Testing_2();

        }

    }
}
