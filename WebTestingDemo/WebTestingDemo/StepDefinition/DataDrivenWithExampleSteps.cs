using System;
using TechTalk.SpecFlow;
using WebTestingDemo.PageObject;

namespace WebTestingDemo.StepDefinition
{
    [Binding]
    public class DataDrivenWithExampleSteps
    {

        DataDrivenWithExamplesPage dataDrivenWithExamplesPage;

        public DataDrivenWithExampleSteps()
        {
            dataDrivenWithExamplesPage = new DataDrivenWithExamplesPage();

        }



        [Given(@"I enter username text ""(.*)""")]
        public void GivenIEnterUsernameText(string Username)
        {
            dataDrivenWithExamplesPage.EnterUsernameInput(Username);
        }
        
        [Given(@"I enter Email text ""(.*)""")]
        public void GivenIEnterEmailText(string Email)
        {
            dataDrivenWithExamplesPage.EnterEmailAddress(Email);
        }
        
        [Given(@"I enter Password text ""(.*)""")]
        public void GivenIEnterPasswordText(string Password)
        {
            dataDrivenWithExamplesPage.EnterPasswordText(Password);
        }
        
        [When(@"I click on sign up")]
        public void WhenIClickOnSignUp()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
