using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationPracticeFramework.Pages
{
    class HomePage
    {
        readonly IWebDriver driver;

        public By homepage = By.Id("index");
        public By contactUs = By.Id("contact-link");
        public By searchField = By.Id("search_query");
        public By searchBtn = By.Name("submit_search");
        public By signInField = By.Id("login");
        public By signInBtn = By.Name("SubmitLogin");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(homepage));
        }
    }
}
