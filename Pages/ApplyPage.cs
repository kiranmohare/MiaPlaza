using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using MiaPlazaAssignment.Locators;
using MiaPlazaAssignment.Config;
using System;

namespace MiaPlazaAssignment.Pages
{
    public class ApplyPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public ApplyPage(IWebDriver driver, WebDriverWait wait)
        {
            this.driver = driver;
            this.wait = wait;
        }

        public void FillParentInformation(string firstName, string lastName, string email, string phone)
        {
            IWebElement parentFirstName = wait.Until(d => d.FindElement(ApplyPageLocators.ParentFirstName));
            parentFirstName.SendKeys(firstName);

            IWebElement parentLastName = driver.FindElement(ApplyPageLocators.ParentLastName);
            parentLastName.SendKeys(lastName);

            IWebElement parentEmail = driver.FindElement(ApplyPageLocators.ParentEmail);
            parentEmail.SendKeys(email);

            IWebElement parentPhone = driver.FindElement(ApplyPageLocators.ParentPhone);
            parentPhone.SendKeys(phone);
        }

        public void ProceedToStudentInformation()
        {
            IWebElement nextButton = driver.FindElement(ApplyPageLocators.NextButton);
            nextButton.Click();

            wait.Until(d => d.FindElement(ApplyPageLocators.StudentInfoHeader));
        }
    }
}