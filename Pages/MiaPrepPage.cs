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

        public void ApplyToMOHS()
        {
            IWebElement applyLink = wait.Until(d => d.FindElement(MiaPrepPageLocators.ApplyLink));
            applyLink.Click();
        }
    }
}