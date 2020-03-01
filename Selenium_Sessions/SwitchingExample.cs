using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class SwitchingExample
    {
        public static void Main(String[] args)
        {

            FirefoxOptions ffopt = new FirefoxOptions();
            ffopt.AddArgument("-disable-notifications");

            IWebDriver driver = new FirefoxDriver();

            /* driver.Url = "https://www.cleartrip.com/";

             IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
             js.ExecuteScript("alert('Hello this is alert');");

             driver.SwitchTo().Alert().Accept();

             IAlert a = driver.SwitchTo().Alert();
             //accept
             //dismiss
             //sendkeys
             //text

             driver.FindElement(By.Id("SearchBtn")).Click();

           */

            driver.Url = "http://demo.automationtesting.in/Alerts.html";

            driver.FindElement(By.XPath("//a[contains(text(),'Alert with Textbox')]")).Click();
            driver.FindElement(By.XPath("//button[@class='btn btn-info']")).Click();
            IAlert a = driver.SwitchTo().Alert();

           

            a.SendKeys("Hello Lankesh");
            Console.WriteLine("Text " + a.Text);
            //a.Accept();
            a.Dismiss();

            driver.Url = "http://demo.automationtesting.in/Windows.html";

            driver.FindElement(By.XPath("//div[@id='Tabbed']//button[@class='btn btn-info'][contains(text(),'click')]")).Click();

            Thread.Sleep(TimeSpan.FromSeconds(10));

            //windowhandle and windowhandles..
            ReadOnlyCollection<String> str = driver.WindowHandles;

            foreach (String s in str)
            {
                driver.SwitchTo().Window(s);
                if(driver.Title.Contains("Sakinalium"))
                {
                    //Console.WriteLine(driver.Title);
                    //Actual test
                    driver.FindElement(By.XPath("//ul[@class='nav navbar-nav navbar-right']//a[contains(text(),'Contact')]")).Click();
                }

                Console.WriteLine(driver.Title);
            }
            Console.ReadKey();

        }
    }

    // Totry
    
/*

1) Pop-Ups...
(Alert Box, unexpected browser pop-ups)

2) Multiple Tabs / 
Windows 

4) Frames
--> identify the frame using findelement method
--> SwitchTo the frame using swithchto
--> identify elements inside and perform operation
*/
}
