using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntoProject.Utilities;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using System.IO;

namespace IntoProject.PageObject
{
    public class IntoProjectClass1
    {
        public IntoProjectClass1()
        {
            PageFactory.InitElements(Hooks1.Driver, this);
        }

        

        [FindsBy(How = How.CssSelector, Using = "#language-switch > a:nth-child(2)")]
        private IWebElement language;

        public void ClickLanguage()

        {
            language.Click();
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=sidebar]/div[2]/ol/li[7]/a")]
        private IWebElement applybutton;

        public bool IsApplyButtonDisplayedInChinese()
        {
            return applybutton.Displayed;

        }

    }
}
