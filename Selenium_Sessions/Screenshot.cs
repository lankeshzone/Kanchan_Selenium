using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class Screenshot
    {

        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin";

            
            //Browser Screenshot
         /*   ITakesScreenshot ts = (ITakesScreenshot)driver; // object of type takesscreenshot
            Screenshot capturescreen = ts.GetScreenshot();
            capturescreen.SaveAsFile("D:\\Test\\screenshot1.jpg");


            //WebElement screenshot
            IWebElement e = null;// = driver.FindElement(By.Id("password-visibility-toggle"));


            try
            {
                ts = (ITakesScreenshot)e;
                capturescreen = ts.GetScreenshot();
                capturescreen.SaveAsFile("D:\\Test\\show.jpg");
            }
            catch (Exception fe)
            {
                Console.WriteLine(fe.Message);
            }
            

    */

            Console.ReadKey();
        }
    }
}
