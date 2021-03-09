using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp2
{

    class Class3
    {
        [Test]
        public void Test()
        {


            // Setting chrome executable
            WebDriverManager.chromedriver().setup();
                // Launching browser
                WebDriver driver = new ChromeDriver();
                // Loading URL
                driver.get("http://makeseleniumeasy.com/");
                // Mentioning type of Log 
                LogEntries entry = driver.manage().logs().get(LogType.BROWSER);
                // Retrieving all log 
                List<LogEntry> logs = entry.getAll();
                // Print one by one
                for (LogEntry e: logs)
                {
                    System.out.println(e);
                }

                // Printing details separately 
                for (LogEntry e: logs)
                {
                    System.out.println("Message is: " + e.getMessage());
                    System.out.println("Level is: " + e.getLevel());
                }



            
        }
            
    }
}