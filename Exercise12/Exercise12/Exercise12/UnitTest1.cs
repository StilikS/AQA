using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Exercise12
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl(@"https://calc.by/building-calculators/laminate.html");
            IWebElement method = _driver.FindElement(By.Id("laying_method_laminate"));
            SelectElement select = new SelectElement(method);
            select.SelectByIndex(2);
            
            IWebElement roomLength = _driver.FindElement(By.Id("ln_room_id"));
            roomLength.Clear();
            roomLength.SendKeys("500");
            
            IWebElement roomWidth = _driver.FindElement(By.Id("wd_room_id"));
            roomWidth.Clear();
            roomWidth.SendKeys("400");

            IWebElement laminateLength = _driver.FindElement(By.Id("ln_lam_id"));
            laminateLength.Clear();
            laminateLength.SendKeys("2000");

            IWebElement laminateWidth = _driver.FindElement(By.Id("wd_lam_id"));
            laminateWidth.Clear();
            laminateWidth.SendKeys("200");
            
            IWebElement layingDirection = _driver.FindElement(By.Id("direction-laminate-id1"));
            layingDirection.Click();
            
            IWebElement calculate = _driver.FindElement(By.LinkText("Рассчитать"));
            calculate.Click();
            
            IWebElement resultElement1 = _driver.FindElement(By.XPath("//div[@class='calc-result']/div[1]/span"));
            Assert.AreEqual("53", resultElement1 .GetAttribute("innerText"));
            
            IWebElement resultElement2 = _driver.FindElement(By.XPath("//div[@class='calc-result']/div[2]/span"));
            Assert.AreEqual("7", resultElement2.GetAttribute("innerText"));
        }
        
        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}