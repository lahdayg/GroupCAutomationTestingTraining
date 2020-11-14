using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using WebTestingDemo.PageObject;

namespace WebTestingDemo.StepDefinition
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {
        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }




        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite2(url);

        }
        
        [Given(@"I enter my Username text ""(.*)""")]
        public void GivenIEnterMyUsernameText(string username)
        {
            dataDrivenWithParameterPage.EnterUsernameInput(username);
        }
        
        [Given(@"I enter my email address text ""(.*)""")]
        public void GivenIEnterMyEmailAddressText(string email)
        {
            dataDrivenWithParameterPage.EnterEmailAddress(email);
        }
        
        [Given(@"I enter my password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenWithParameterPage.EnterPasswordText(password);
        }
        
        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            dataDrivenWithParameterPage.ClickOnSignUpButton();
        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            Thread.Sleep(5000);
            Assert.That(dataDrivenWithParameterPage.IsNewArticleDisplayed);
        }
    }
}
