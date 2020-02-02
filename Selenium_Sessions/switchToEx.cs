using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class switchToEx
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            /*      driver.Url = "http://demo.automationtesting.in/Alerts.html";

                  IWebElement alertTab = driver.FindElement(By.XPath("//a[contains(text(),'Alert with Textbox')]"));
                  alertTab.Click();

                  IWebElement clickButt = driver.FindElement(By.XPath("//button[@class='btn btn-info']"));
                  clickButt.Click();

                  IAlert a = driver.SwitchTo().Alert();
                  Console.WriteLine("Text on alert box is " +a.Text);

                a.SendKeys("Lankesh");

                   a.Accept();
                a.Dismiss();
      */


            driver.Url = "http://demo.automationtesting.in/Windows.html";

            driver.FindElement(By.XPath("//div[@id='Tabbed']//button[@class='btn btn-info'][contains(text(),'click')]")).Click();

            ICollection<String> s = driver.WindowHandles;
            Console.WriteLine("Tabs available" + s.Count);

            foreach(String s1 in s)
            {
                Console.WriteLine("Tabs : " + s1);
                driver.SwitchTo().Window(s1);
                if (driver.Title.Contains("Sakinalium"))
                {
                    driver.FindElement(By.XPath("//ul[@class='nav navbar-nav navbar-right']//a[contains(text(),'Contact')]")).Click();
                    Console.WriteLine("current URL is " + driver.Url);
                }
            }




            Console.ReadKey();


        }

    }
}
