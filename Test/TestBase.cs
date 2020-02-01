using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class TestBase
    {

        public static IWebDriver driver;
        private static string url = "file:///C:/Users/Usha%20Bhat/Downloads/index.html";
        
        //public static Properties prop;

        public TestBase()
        {

         /*   try
            {
                prop = new Properties();
                FileInputStream ip = new FileInputStream("C:\\Users\\dell\\Desktop\\Zain\\TestPage\\src\\main\\java\\com\\testpage\\config\\config.properties");
                prop.load(ip);
            }

            catch (FileNotFoundException e)
            {
                e.printStackTrace();
            }

            catch (IOException e)
            {
                e.printStackTrace();
            }
      */  }

        public static void initialization()
        {
            /*String browserName = prop.getProperty("browser");
            if (browserName.equals("chrome"))
            {*/
                //System.setProperty("webdriver.chrome.driver", "chromedriver_79.exe");
                driver = new ChromeDriver();
            /*}*/

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(TestUtilities.PAGE_LOAD_TIMEOUT);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TestUtilities.IMPLICIT_WAIT);
            driver.Url= url;

        }

    }

}
