using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using TechTalk.SpecFlow;

namespace WebTestingDemo.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");
           
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }

        // I used after scenerio so that my window can quit after running my test

        [AfterScenario]
        public void AfterScenario()
        {
            //driver.Quit();
        }
    }
}
