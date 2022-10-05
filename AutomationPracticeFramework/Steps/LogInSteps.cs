using AutomationPracticeFramework.Helpers;
using AutomationPracticeFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class LogInSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        [Given(@"user enter '(.*)' as Email address term and enter '(.*)' as Password word")]
        public void GivenUserEnterAsEmailAddressTermAndEnterAsPasswordWord(string p0, string p1)
        {
            ut.EnterTextInElement(hp.signInField, p0);
            ut.EnterTextInElement(hp.signInField, p1);
        }
        
        [When(@"user submits the Sign In button")]
        public void WhenUserSubmitsTheSignInButton()
        {
            ut.ClickOnElement(hp.signInBtn);
        }
        
        [Then(@"user need to be successfully logged in")]
        public void ThenUserNeedToBeSuccessfullyLoggedIn()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
