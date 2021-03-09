﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace automation_test
{
    class FirstTestCase
    {
      
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //IWebDriver driver = new ChromeDriver();
            //driver.Url = "https://www.demoqa.com";
            //driver.Close();

            IWebDriver driver = new ChromeDriver();

            //Launch the ToolsQA Website
            driver.Url = "https://www.facebook.com";

            // Storing Title name in String variable
            String Title = driver.Title;

            // Storing Title length in Int variable
            int TitleLength = driver.Title.Length;

            // Printing Title name on Console
            Console.WriteLine("Title of the page is : " + Title);

            // Printing Title length on console
            Console.WriteLine("Length of the Title is : " + TitleLength);

            // Storing URL in String variable
            String PageURL = driver.Url;

            // Storing URL length in Int variable
            int URLLength = PageURL.Length;

            // Printing URL on Console
            Console.WriteLine("URL of the page is : " + PageURL);

            // Printing URL length on console
            Console.WriteLine("Length of the URL is : " + URLLength);

            // Storing Page Source in String variable
            String PageSource = driver.PageSource;

            // Storing Page Source length in Int variable
            int PageSourceLength = driver.PageSource.Length;

            // Printing Page Source on console
            Console.WriteLine("Page Source of the page is : " + PageSource);

            // Printing Page SOurce length on console
            Console.WriteLine("Length of the Page Source is : " + PageSourceLength);

            //Closing browser
            driver.Quit();


        }
    }
}
