using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;


namespace ConsoleApp3
{
    public class Program
    {
        Class1 newc = new Class1();
        static void Main(string[] args)
        {
            //Class1 class1 = new Class1();
            //class1.Testing();
            //Testing_2();
            //log.Debug();
            Program program = new Program();
            program.Testing_2();
            Console.ReadLine();
 
        }

        public void Testing_2()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
                //ewc.getTetx(); 
            }
        }
    }
}
