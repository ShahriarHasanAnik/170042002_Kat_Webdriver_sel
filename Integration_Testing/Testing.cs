using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inegration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }
        [Test]
        public void test()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            IWebElement element = driver.FindElement(By.Name("txtstudid"));
            element.SendKeys("Admin");
            IWebElement password = driver.FindElement(By.Name("txtpass"));
            password.SendKeys("admin123");
            driver.FindElement(By.Id("studlogin")).Click();
            String at = driver.Title;
            String et = "Random Website";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
               driver.FindElement(By.XPath("/html/body/div[1]/div/div[3]/div[2]"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}