using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestUtilities
    {

        public static long PAGE_LOAD_TIMEOUT = 20;
        public static long IMPLICIT_WAIT = 10;


        public static void dynamicWait(IWebDriver driver, IWebElement element, long timeout)
        {

            //   new WebDriverWait(driver, TimeSpan.FromSeconds(timeout).
            //   until(ExpectedConditions.visibilityOf(element));
        }
    }


}
