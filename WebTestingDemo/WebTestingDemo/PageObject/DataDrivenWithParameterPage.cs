using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using WebTestingDemo.Utilities;

namespace WebTestingDemo.PageObject
{
    class DataDrivenWithParameterPage
    {

        public DataDrivenWithParameterPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder = 'Username']"));

        IWebElement emailAddress => driver.FindElement(By.XPath("//input[@type ='email']"));

        IWebElement passwordText => driver.FindElement(By.XPath("//input[@type ='password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@type ='submit']"));

        IWebElement newArticle => driver.FindElement(By.XPath("(//a[@class ='nav-link'])[3]"));


        public void EnterUsernameInput(string username)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            usernameInput.SendKeys("username" + randomint);
            //usernameInput.SendKeys(username);
        }

        public void EnterEmailAddress(string email)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            emailAddress.SendKeys("email" + randomint + "@demo.com");
            // emailAddress.SendKeys(email);
        }

        public void EnterPasswordText(string password)
        {
            passwordText.SendKeys(password);
        }


        public void ClickOnSignUpButton()
        {
            signUpButton.Click();
        }

        public void NavigateToWebsite2(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool IsNewArticleDisplayed()
        {
            return newArticle.Displayed;
        }






    }
}
