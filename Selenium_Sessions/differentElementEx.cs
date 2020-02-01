using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class differentElementEx
    {

        public static void Main(String[] args)
        {

            IWebDriver driver = new ChromeDriver();

            driver.Url = "http://demo.automationtesting.in/Register.html";

            IWebElement skills = driver.FindElement(By.Id("Skills"));
            Console.WriteLine("element val " + skills.Location);

            SelectElement s = new SelectElement(skills);
            //    s.SelectByIndex(3);
           // s.SelectByValue("C");

            //   s.DeselectByValue("C");


            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

           // js.ExecuteScript("window.scrollBy(0,1000);");


            Console.WriteLine("Title " + js.ExecuteScript("return document.title;").ToString());

            // js.ExecuteScript("alert('Hello');");

            IWebElement countrySel = driver.FindElement(By.XPath("//span[@class='select2-selection select2-selection--single']"));
            countrySel.Click();

            IWebElement selectedElement = driver.FindElement(By.XPath("//li[contains(text(),'Denmark')]"));
            selectedElement.Click();


           // Console.WriteLine("Location " + js.ExecuteScript("window.location = 'http://demo.automationtesting.in/Register.html'"));
        }

    }
}
