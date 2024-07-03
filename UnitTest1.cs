using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using MiaPlazaAssignment.Pages;
using MiaPlazaAssignment.Config;
using System;

namespace MiaPlazaAssignment;


public class Tests
{
    private IWebDriver driver;
    private WebDriverWait wait;
        private HomePage homePage;
        private MiaPrepPage miaPrepPage;
        private ApplyPage applyPage;

    [SetUp]
    public void Setup()
    {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Manage().Window.Maximize();

            homePage = new HomePage(driver, wait);
            miaPrepPage = new MiaPrepPage(driver, wait);
            applyPage = new ApplyPage(driver, wait);
    }

    [Test]
    public void TestNavigateAndApplyToMOHS()
    {
        homePage.NavigateToBaseUrl();
            Assert.Pass("Successfully navigated to the Base URL");
            homePage.NavigateToMiaPrep();
            miaPrepPage.ApplyToMOHS();
            applyPage.FillParentInformation(TestData.ParentInfo.FirstName, TestData.ParentInfo.LastName, TestData.ParentInfo.Email, TestData.ParentInfo.Phone, TestData.ParentInfo.Date);
            applyPage.ProceedToStudentInformation();

            Assert.Pass("Successfully navigated to Student Information page.");
    }

    [Test]
    public void TestNegativeScenarioForMOHSApplication()
    {
        // Write test case scenario for Negative scenario at Appllication page....

    }

    [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
}