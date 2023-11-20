﻿
using OpenQA.Selenium;

namespace Framework.Pages
{
    internal class Common
    {
        internal static IWebElement GetElement(string locator) 
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator) 
        {
            GetElement(locator).Click();        
        }

        internal static void SendKeysToElement(string locator, string keys) 
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetText(string locator) 
        {
            return GetElement(locator).Text;
        }
    }
}