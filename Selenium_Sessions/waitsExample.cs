using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class waitsExample
    {
        public static void Main(String[] args)
        {

            IWebDriver driver =  new FirefoxDriver();

            //Page to load completely with in three seconds
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.cleartrip.com";


            /* Console.WriteLine("before sleep");
              Thread.Sleep(5000);
              Console.WriteLine("after sleep");
              */
            /*  driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromMilliseconds(1);
              IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
              js.ExecuteAsyncScript("alert('Hello Lankesh');");
              */

            /*
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1);
            driver.FindElement(By.Id("FromTag")).SendKeys("Bangalore");
            */

            WebDriverWait wt = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wt.Until(ExpectedConditions.ElementToBeClickable(By.Id("SearchBtn")));
            driver.FindElement(By.Id("SearchBtn")).Click();

            WebDriverWait ft = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            ft.PollingInterval = TimeSpan.FromSeconds(2);
            ft.Until(ExpectedConditions.AlertIsPresent());

    

        }



    }
}
