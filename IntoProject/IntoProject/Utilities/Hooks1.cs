using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace IntoProject.Utilities
{
    [Binding]
    public class Hooks1
    {
        //1. create instance of the browser

        public static IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //2. open the browser
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Quit();
        }
    }
}
