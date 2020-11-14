using System;
using TechTalk.SpecFlow;
using WebTestingDemo.PageObject;

namespace WebTestingDemo.StepDefinition
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registrationPage;

        public RegistrationSteps()
        {
            registrationPage = new RegistrationPage();

        }



        [Given(@"I navigate to amazon website")]
        public void GivenINavigateToAmazonWebsite()
        {
            registrationPage.NavigateToWebsite();

        }
        
        [Given(@"I click on Hello Sign in")]
        public void GivenIClickOnHelloSignIn()
        {
            registrationPage.ClickOnHelloSignIn();
        }
        
        [Given(@"I click on create your amazon account")]
        public void GivenIClickOnCreateYourAmazonAccount()
        {
            registrationPage.CreateYourAmazonAccount();
        }
        
        [Given(@"I enter my name")]
        public void GivenIEnterMyName()
        {
            registrationPage.EnterYourName();

        }
        
        [Given(@"I enter my email address")]
        public void GivenIEnterMyEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I reenter my password")]
        public void GivenIReenterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on create your amazon account on the registration page")]
        public void WhenIClickOnCreateYourAmazonAccountOnTheRegistrationPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my account should be successfully created")]
        public void ThenMyAccountShouldBeSuccessfullyCreated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
