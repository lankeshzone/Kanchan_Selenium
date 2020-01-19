using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class findElementEx
    {

        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin";

            //Creating a variable of type webElement
            IWebElement userID;

            //creating a By type which returns elements matching the search criteria
            By locator = By.Id("username");

            //FindElement method to pick the first occurence of the By locator.
            userID = driver.FindElement(locator);

            Console.WriteLine("UserID " + userID.Location);

            IList<IWebElement> input;

            locator = By.TagName("input");

            input = driver.FindElements(locator);

            Console.WriteLine("elements from input " + input.Count);

            foreach (IWebElement e in input)
                Console.WriteLine("element location " + e.Location);

           // Console.WriteLine("all elements " + input);

        }
    }
}
