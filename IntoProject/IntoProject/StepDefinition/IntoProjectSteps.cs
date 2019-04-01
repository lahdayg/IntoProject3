using System;
using IntoProject.PageObject;
using TechTalk.SpecFlow;
using IntoProject.Utilities;
using NUnit.Framework;
namespace IntoProject.StepDefinition
{
    [Binding]
    public class IntoProjectSteps
    {
        IntoProjectClass1 intoprojectclass1;

        public IntoProjectSteps()
        {
            intoprojectclass1 = new IntoProjectClass1();
        }



        [Given(@"I navigate to https://www\.intostudy\.com/en-gb")]
        public void GivenINavigateToHttpsWww_Intostudy_ComEn_Gb()
        {
            //3a. Navigate to website
            Hooks1.Driver.Navigate().GoToUrl("https://www.intostudy.com/en-gb");
            Hooks1.Driver.Manage().Window.Maximize();

            Hooks1.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"I click on the chinese on the banner")]
        public void WhenIClickOnTheChineseOnTheBanner()
        {
            intoprojectclass1.ClickLanguage();
        }
        
        [Then(@"the localisation should change from English to chinese")]
        public void ThenTheLocalisationShouldChangeFromEnglishToChinese()
        {
            Assert.IsTrue(intoprojectclass1.IsApplyButtonDisplayedInChinese(), "Message : Localisation Passed");
        }
    }
}
