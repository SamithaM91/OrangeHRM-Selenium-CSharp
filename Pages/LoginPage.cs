using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM_C_.DriverManagement;
using SeleniumExtras.WaitHelpers;

namespace OrangeHRM_C_.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;
        WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement userNameField => driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        private IWebElement passwordField => driver.FindElement(By.XPath("//input[@type='password']"));
        private IWebElement loginButton => driver.FindElement(By.XPath("//button[@type='submit']"));


        public void Login(string username, string password) {

            // Wait for the username field to be visible and interactable
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(userNameField));

            userNameField.Clear();
            userNameField.SendKeys("Admin");

            // Wait for the password field to be visible and interactable
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(passwordField)); // Ensure the field is clickable

            passwordField.Clear();
            passwordField.SendKeys("password");


            // Wait for the login button to be visible and interactable
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(loginButton));
            loginButton.Click();

       
        }


    }
}
