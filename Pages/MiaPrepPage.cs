using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MiaPlazaAssignment.Locators;
using System;

namespace MiaPlazaAssignment.Pages
{
    public class MiaPrepPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public MiaPrepPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void ClickASUMOHSLink()
        {
            IWebElement applyLink = wait.Until(d => d.FindElement(MiaPrepPageLocators.ByMOHSLink));
            applyLink.Click();
        }

        public void ApplyToMOHS()
        {
            IWebElement schoolLink = wait.Until(d => d.FindElement(MiaPrepPageLocators.ApplyToSchoolButton));
            schoolLink.Click();
        }
    }
}