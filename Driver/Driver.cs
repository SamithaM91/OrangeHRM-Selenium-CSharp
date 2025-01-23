using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace OrangeHRM_C_.DriverManagement
{
    public class Driver
    {
        private static IWebDriver? driver;

        public static IWebDriver getWebDriver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            }
            return driver;
        }

        public static void quitDriver()
        {
            driver?.Quit();
            driver = null;
        }
    }
}
