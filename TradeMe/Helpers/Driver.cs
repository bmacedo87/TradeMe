using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradeMe.Helpers
{
    public class Driver
    {
        //Initialize the browser
        public static IWebDriver driver { get; set; }

        public void Initialize()
        {
            //Defining the browser
            driver = new ChromeDriver();

            //Maximise the window
            driver.Manage().Window.Maximize();

            //Go to TradeMe website
            driver.Navigate().GoToUrl("www.trademe.co.nz");
        }
    }
}   
