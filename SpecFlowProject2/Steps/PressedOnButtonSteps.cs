using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using System;
using TechTalk.SpecFlow;



namespace SWDT_AutFundHW.Steps
{
    [Binding]
    public class PressedOnButtonSteps
    {
        IWebDriver driver = new ChromeDriver("C:\\");

       //private readonly ScenarioContext _scenarioContext;
        /*public PressedOnButtonSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }*/

        [Given(@"the user is on home page")]
        public void GivenTheUserIsOnHomePage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.epam.com/");
        }
        
        [Given(@"the user on services page")]
        public void GivenTheUserOnServicesPage()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.epam.com/services/");
        }
        
        [When(@"the services button is pressed")]
        public void WhenTheServicesButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[1]/span[1]/a")).Click();
        }
        
        [When(@"the about button is pressed")]
        public void WhenTheAboutButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[5]/span[1]/a")).Click();
        }
        
        [When(@"the our work button is pressed")]
        public void WhenTheOurWorkButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[3]/span[1]/a")).Click();
        }
        
        [When(@"the insights button is pressed")]
        public void WhenTheInsightsButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='wrapper']/div[2]/div[1]/header/div/nav/ul/li[4]/span/a")).Click();
        }
        
        [When(@"the engineer button is pressed")]
        public void WhenTheEngineerButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[2]/section/div/div/div/div[3]/a")).Click();
        }
        
        [When(@"the consult button is pressed")]
        public void WhenTheConsultButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[2]/section/div/div/div/div[1]/a")).Click();
        }
        
        [When(@"the design button is pressed")]
        public void WhenTheDesignButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[2]/section/div/div/div/div[2]/a")).Click();
        }
        
        [When(@"the operate button is pressed")]
        public void WhenTheOperateButtonIsPressed()
        {
            driver.FindElement(By.XPath("//*[@id='main']/div[1]/div[2]/section/div/div/div/div[4]/a")).Click();
        }
        
        [Then(@"the page services appears")]
        public void ThenThePageServicesAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/services"));
            driver.Close();
        }
        
        [Then(@"the page about appears")]
        public void ThenThePageAboutAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/about"));
            driver.Close();
        }
        
        [Then(@"the page our work appears")]
        public void ThenThePageOurWorkAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/our-work"));
            driver.Close();
        }
        
        [Then(@"the page insights appears")]
        public void ThenThePageInsightsAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/insights"));
            driver.Close();
        }
        
        [Then(@"the page engineer appears")]
        public void ThenThePageEngineerAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/services/engineer"));
            driver.Close();
        }
        
        [Then(@"the page consult appears")]
        public void ThenThePageConsultAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/services/consult-and-design"));
            driver.Close();
        }
        
        [Then(@"the page design appears")]
        public void ThenThePageDesignAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/services/consult-and-design"));
            driver.Close();
        }
        
        [Then(@"the page operate appears")]
        public void ThenThePageOperateAppears()
        {
            Assert.That(driver.Url.ToString(), Is.EqualTo("https://www.epam.com/services/operate"));
            driver.Close();
        }
    }
}
