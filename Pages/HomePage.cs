using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MiaPlazaAssignment.Locators;
using MiaPlazaAssignment.Config;
using System;

namespace MiaPlazaAssignment.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void NavigateToBaseUrl()
        {
            driver.Navigate().GoToUrl(AppConfig.BaseUrl);
        }

        public void NavigateToMiaPrep()
        {
            IWebElement bannerLink = wait.Until(d => d.FindElement(HomePageLocators.MiaPrepBannerLink));
            bannerLink.Click();
        }
    }
}