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

        static void Main(string[] args)
        {
            Click_on_image Click_on_image = new Click_on_image();
            Click_on_image.Testing_1();



            //Class1 Click_on_image = new Click_on_image();
            //Click_on_image.Testing_1();
            ////Testing();
            ////log.Debug();
            Console.ReadLine();
        }

        //public void Testing_1()
        //{

        //    log4net.Config.BasicConfigurator.Configure();
        //    log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        //    try
        //    {
        //        string str = String.Empty;
        //        string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
        //    }
        //    catch (Exception ex)
        //    {
        //        log.Error("Error Message: " + ex.Message.ToString(), ex);
        //    }

        //}
    }
}
