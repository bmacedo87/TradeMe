using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TradeMe.Helpers;

namespace TradeMe.Pages
{
    public class ResultsPage
    {
        public static IWebElement searchResults=> Driver.driver.FindElement(By.XPath("//h3[contains(text(),'bag')]"));
        public static IWebElement categoryDropdown => Driver.driver.FindElement(By.XPath("//button[contains(text(),'Category')]"));





        public static void SearchResults_Assertion()
        {
            
        }
    }
}
