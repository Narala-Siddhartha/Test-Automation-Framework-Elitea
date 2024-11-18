using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UtilsLayer
{
    public static class WebDriverUtilities
    {
        public static IWebDriver Driver;

        public static void InitializeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public static void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElement(By locator)
        {
            return Driver.FindElement(locator);
        }

        public static void Clear(IWebElement element)
        {
            element.Clear();
        }

        public static void SendKeys(IWebElement element, string keys)
        {
            element.SendKeys(keys);
        }

        public static void Click(IWebElement element)
        {
            element.Click();
        }
    }
}