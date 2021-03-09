using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        IWebDriver driver;
        static void Main(string[] args)
        {
            string url = "http://testing.todorvachev.com/selectors/css-path/";
            string cssPath = "#search-2 > form > label > input";
            string xPath = "//*[@id=\"search-2\"]/form/label/input";

            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            IWebElement xPathElement = driver.FindElement(By.XPath(xPath));

            if (cssPathElement.Displayed)
            {
                Console.WriteLine("I can see the CSS path element");
            }
            else
            {
                Console.WriteLine("I can't see it");
            }



        }
    }
}
