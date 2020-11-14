using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebTestingDemo.Utilities;

namespace WebTestingDemo.PageObject
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement helloSignIn => driver.FindElement(By.XPath("//span[text()='Hello, Sign in']"));

        IWebElement createYourAmazonAccount => driver.FindElement(By.Id("createAccountSubmit"));

        IWebElement yourName => driver.FindElement(By.XPath("//*[@id='ap_customer_name']"));




        public void ClickOnHelloSignIn()
        {
            helloSignIn.Click();
        }

        public void CreateYourAmazonAccount()
        {
            Thread.Sleep(5000);
            createYourAmazonAccount.Click();
        }

        public void EnterYourName()
        {
            yourName.SendKeys("Akin Oladeji");
        }




        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://www.amazon.co.uk/");
        }









    }
}
