using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TradeMe.Helpers;
using TradeMe.Pages;

namespace TradeMe
{
    public class HomePage_Tests : Driver
    {
       
        [Test][Category("TC-001-01")]
        public void SearchItem_Test()
        {
            //Launch browser and access TradeMe website
            Initialize();

            //Click on textbox and type in text
            HomePage.SearchBag();

            //Click on magnifier icon
            HomePage.ClickSearchIcon();

        }
    }
}