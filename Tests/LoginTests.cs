using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM_C_.DriverManagement;
using OrangeHRM_C_.Pages;
using SeleniumExtras.WaitHelpers;

namespace OrangeHRM_C_.Tests
{
    [TestFixture]
    public class LoginTests
    {
        private IWebDriver? driver;
        private LoginPage? loginPage;

        [SetUp]
        public void SetUp()
        {
            driver = Driver.getWebDriver();
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            loginPage = new LoginPage(driver);

        }

        [Test]
        public void LoginTest() {

            loginPage?.Login("Admin", "admin123");

            // Wait for the page to load after login
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));  
        
        }

        [TearDown]
        public void TearDown() {
            if (driver != null) { 

                driver.Quit();
                driver.Dispose();
                driver = null;
            
            }
        }
        
    }
}
