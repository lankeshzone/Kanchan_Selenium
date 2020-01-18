using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class WebElementEx
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin";

            IWebElement userID;
            userID = driver.FindElement(By.Id("username"));

            Console.WriteLine("Height " + userID.GetCssValue("height"));
            Console.WriteLine("Property " + userID.GetProperty("name"));
            Console.WriteLine("Attribute " + userID.GetAttribute("tag"));
            Console.WriteLine("Sixe " + userID.Size);
            Console.WriteLine("Position " + userID.Location);

            Console.WriteLine("Enabled??? " + userID.Enabled);
            Console.WriteLine("Displayed?? " + userID.Displayed);
            Console.WriteLine("Selected ?? " + userID.Selected);

            userID.Click();
            Thread.Sleep(2);
            userID.SendKeys("lankeshzone@gmail.com");
            Thread.Sleep(2);
            userID.Clear();

            driver.FindElement(By.ClassName("btn__primary--large")).Submit();

        }
    }
}
