using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject1
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.irctc.co.in/nget/");
            TestContext.Progress.WriteLine("Browser Opened");
        }

        [Test]
        public void Test1()
        {
            
            TestContext.Progress.WriteLine("Test1 Executed");
        }
        [Test]
        public void Test2()
        {
            TestContext.Progress.WriteLine("Test2 Executed");
        }
        public void Test4()
        {
            TestContext.Progress.WriteLine("Test4 Executed");
        }

        [TearDown]
        public void TearDown()
        {
            TestContext.Progress.WriteLine("After Test");
        }
    }
}