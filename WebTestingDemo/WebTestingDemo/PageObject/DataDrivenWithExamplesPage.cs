using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using WebTestingDemo.Utilities;

namespace WebTestingDemo.PageObject
{
    class DataDrivenWithExamplesPage
    {
        public DataDrivenWithExamplesPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailAddress => driver.FindElement(By.XPath("//input[@type ='email']"));

        IWebElement passwordText => driver.FindElement(By.XPath("//input[@type ='password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type ='submit']"));

        IWebElement newArticle => driver.FindElement(By.XPath("(//a[@class ='nav-link'])[3]"));




        public void EnterUsernameInput(string Username)
        {
            //Random randomGenerator = new Random();
            //int randomint = randomGenerator.Next(1000);
            //usernameInput.SendKeys("Username" + randomint);
            usernameInput.SendKeys(Username);
        }

        public void EnterEmailAddress(string Email)
        {
            //Random randomGenerator = new Random();
            //int randomint = randomGenerator.Next(1000);
            //emailAddress.SendKeys("Email" + randomint + "@demo.com");
            emailAddress.SendKeys(Email);
        }

        public void EnterPasswordText(string Password)
        {
            passwordText.SendKeys(Password);
        }


        public void ClickOnSignUpButton()
        {
            signUpButton.Click();
        }










    }
}
