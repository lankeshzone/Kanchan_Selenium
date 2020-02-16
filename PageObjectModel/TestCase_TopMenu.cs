using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel
{
    class TestCase_TopMenu
    {

        public static void Main(String[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://automationpractice.com/index.php";

            TopMenu tp = new TopMenu(driver);

            tp.logo_click();
            tp.searchText_Enter();

        }
    }
}
