using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using TradeMe.Helpers;

namespace TradeMe.Pages
{
    public static class HomePage
    {
        private static IWebElement searchTextbox => Driver.driver.FindElement(By.Id("searchString"));
        private static IWebElement categories => Driver.driver.FindElement(By.XPath("//*[contains(text(),'in all categories')]"));
        private static IWebElement clothingAndFashion => Driver.driver.FindElement(By.XPath("//*[@id='SearchType']/option[10]"));
        private static IWebElement magnifierIcon => Driver.driver.FindElement(By.XPath("//button[@value='Search']"));
        


        public static void SearchBag()
        {
            searchTextbox.Click();
            searchTextbox.SendKeys("bag");
        }

        public static void SelectCategory()
        {
            categories.Click();
            clothingAndFashion.Click();
        }

        public static void ClickSearchIcon()
        {
            magnifierIcon.Click();
        }

    }
}
