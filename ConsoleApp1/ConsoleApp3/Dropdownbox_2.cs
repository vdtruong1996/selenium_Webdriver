using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp3
{
    class Dropdownbox_2
    {
        [Test]
        public void Test()
        {
            // Create a new instance of the Firefox driver
            IWebDriver driver = new ChromeDriver("D:\\auto\\chromedriver");

            // Put an Implicit wait, this means that any search for elements on the page could take the time the implicit wait is set for before throwing exception
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // Launch the URL
            driver.Url = "http://demo.guru99.com/test/newtours/register.php";

            // Step 3: Select 'Selenium Commands' Multiple select box ( Use Name locator to identify the element )
            IWebElement drop_1 = driver.FindElement(By.Name("country"));
            SelectElement oSelection = new SelectElement(drop_1);
            //SelectElement oSelection = new SelectElement(driver.FindElement(By.Name("country")));

            // Step 4: Select option 'Browser Commands'  and then deselect it (Use selectByIndex and deselectByIndex)
            //oSelection.SelectByIndex(0);
            //Thread.Sleep(2000);
            //oSelection.DeselectByIndex(0);

            // Step 5: Select option 'Navigation Commands'  and then deselect it (Use selectByVisibleText and deselectByVisibleText)
            oSelection.SelectByText("ALGERIA");
            Thread.Sleep(2000);

            oSelection.DeselectByText("ALGERIA");

            // Step 6: Print and select all the options for the selected Multiple selection list.
            IList<IWebElement> oSize = oSelection.Options;
            int iListSize = oSize.Count;

            // Setting up the loop to print all the options
            for (int i = 0; i < iListSize; i++)
            {
                // Storing the value of the option 
                String sValue = oSelection.Options.ElementAt(i).Text;
                // Printing the stored value
                Console.WriteLine("Value of the Item is :" + sValue);
                // Selecting all the elements one by one
                oSelection.SelectByIndex(i);
 
                Thread.Sleep(5);
            }

            // Step 7: Deselect all
            //oSelection.DeselectAll();
            Thread.Sleep(2000);

            

            Console.WriteLine("cssDeme");

            Program program = new Program();
            program.Testing_2();
            // Kill the browser
            driver.Close();
        }
    }
}