using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

[TestFixture]
public class Chrome_Sample_test
{
    private IWebDriver driver;
    public string homeURL;


    [Test(Description = "Check Fiction button and verify that It will display next page with Fiction heading")]
    public void TestCase()
    {


        homeURL = "http://skunkworks.ignitesol.com:3000/";
        driver.Navigate().GoToUrl(homeURL);
        WebDriverWait wait = new WebDriverWait(driver, System.TimeSpan.FromSeconds(15));
        driver.FindElement(By.XPath("//span[contains(text(),'FICTION')]")).Click();
        Thread.Sleep(2000);
        string Title = driver.FindElement(By.XPath("//h1")).Text;
        Assert.AreEqual("FICTION",Title);
    }
    [TearDown]
    public void TearDownTest()
    {
        driver.Close();
    }


    [SetUp]
    public void SetupTest()
    {
        homeURL = "http://skunkworks.ignitesol.com:3000/";
        driver = new ChromeDriver();

    }


}



