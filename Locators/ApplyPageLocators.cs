using OpenQA.Selenium;

namespace MiaPlazaAssignment.Locators
{
    public class ApplyPageLocators
    {
        public static readonly By ParentFirstName = By.XPath("//input[@aria-labelledby='Name-arialabel aria-showelemslabel-Name0 ariarequired-Name0']");

        public static readonly By ParentLastName = By.XPath("//input[@aria-labelledby='Name-arialabel aria-showelemslabel-Name1 ariarequired-Name1']");
        public static readonly By ParentEmail = By.Id("Email-arialabel");
        public static readonly By ParentPhone = By.XPath("//input[@name='PhoneNumber']");
        public static readonly By StudentInfoHeader = By.XPath("//*[contains(text(),'Student Information')][2]");

        public static readonly By DropdownInfoButton = By.XPath("//span[@class='select2-selection__arrow select2FormArrow']/b");

        public static readonly By OptionYesButton = By.Id("select2-Dropdown-arialabel-result-svei-Yes");

        public static readonly By OptionNoButton = By.Id("select2-Dropdown-arialabel-result-hjux-No");

        public static readonly By SelectCalendarDate = By.XPath("//div[@class='calendarCont']/input[1]");

        public static readonly By NextButton = By.XPath("//div[@class='inlineBlock nextAlign']//*[contains(text(),'Next')]");
    }
}