using OpenQA.Selenium;

namespace MiaPlazaAssignment.Locators
{
    public class ApplyPageLocators
    {
        public static readonly By ParentFirstName = By.Id("parentFirstName");
        public static readonly By ParentLastName = By.Id("parentLastName");
        public static readonly By ParentEmail = By.Id("parentEmail");
        public static readonly By ParentPhone = By.Id("parentPhone");
        public static readonly By NextButton = By.XPath("//button[text()='Next']");
        public static readonly By StudentInfoHeader = By.XPath("//h2[text()='Student Information']");
    }
}