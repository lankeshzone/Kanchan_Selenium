using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{

    // The list of elements available in top menu are logo, search, searchButton, cart, contact, signin
    public class TopMenu
    {
        static IWebElement logo, search, searchButton, cart, contact, signin;

        static IWebDriver driver;

        public TopMenu(IWebDriver TCdriver)
        {
            driver = TCdriver;
        }

        //identification of element
        static void logoImage()
        {
            logo = driver.FindElement(By.XPath("//img[@class='logo img-responsive']"));
        }

        //performing the action on the element
        public void logo_click()
        {
            logoImage();
            logo.Click();
        }

        static void searchText()
        {
            search = driver.FindElement(By.Id("search_query_top"));
        }
        public void searchText_Enter()
        {
            searchText();
            search.SendKeys("Lankesh");
        }

    }
}
