using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class InteractionsEx
    {

        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://demo.automationtesting.in/Register.html";

            IWebElement interaction, draganddrop, staticEl ;

            interaction = driver.FindElement(By.XPath("//a[contains(text(),'Interactions')]"));
            draganddrop = driver.FindElement(By.XPath("//a[contains(text(),'Drag and Drop')]"));
            staticEl = driver.FindElement(By.XPath("//a[contains(text(),'Static')]"));

            interaction.Click();
            draganddrop.Click();
            staticEl.Click();
        }
    }
}
