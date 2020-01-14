using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class BrowserLaunch
    {
        public static void Main(String[] args)
        {

            // created an instance of the chrome browser..
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.linkedin.com";

            //Basic method on WebDriver interface

            Console.WriteLine("Title of the page " + driver.Title);

            Console.WriteLine("Current URL " + driver.Url);

            // Console.WriteLine("Source code of the page" + driver.PageSource);

          //  driver.Manage().Window.Maximize();

        //    driver.Manage().Window.Minimize();

           // driver.Manage().Window.FullScreen();

            Console.WriteLine("Position of the windoow " +driver.Manage().Window.Position);

            Console.WriteLine("Size of the Window " + driver.Manage().Window.Size);


            Console.WriteLine("All cookies " + driver.Manage().Cookies.AllCookies);

            driver.Manage().Cookies.DeleteAllCookies();

            Console.WriteLine(" after deletion " + driver.Manage().Cookies);

            Size d = new Size(10, 10);

          //  driver.Manage().Window.Size = d;

          //  driver.Url = "https://www.google.com";

           // driver.Navigate().Back();

            //driver.Navigate().Forward();

            driver.Navigate().Refresh();

            driver.Navigate().GoToUrl("https://www.facebook.com");

            driver.Quit(); // shut down the browser...


            //IWebDriver driver2 = new FirefoxDriver();
            // driver2.Url = "https://www.facebook.com";

            // IWebDriver driver3 = new EdgeDriver();
            //  driver3.Url = "https://www.google.com";


        }
         
    }
}
