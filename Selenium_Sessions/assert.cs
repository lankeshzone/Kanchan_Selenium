using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class assert
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin";

            String ExpectedTitle = "Linked";

            String ActualTitile = driver.Title; // uses selenium command

            if (ActualTitile.Contains(ExpectedTitle)) //programming 
                Console.WriteLine("Title matches " + ActualTitile + " :  " + ExpectedTitle);
            else
                Console.WriteLine("Title doesn't match " + ActualTitile + " :  " + ExpectedTitle);

            IWebElement signIN = driver.FindElement(By.ClassName("btn__primary--large"));

            if (signIN.Enabled)
                signIN.Click();
            else
                throw new Exception("Button not eanbled to click");

            // Assert.AreEqual(ExpectedTitle, ActualTitile);

           // Assert.IsFalse(signIN.Displayed);

            String s = "Test";
         //   Assert.IsEmpty(s, "It is null");

            Assert.Fail();

         
            

           /* Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string Runname = "Test" + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string screenshotfilename = "X:\\screenshots\\" + Runname + ".jpg";
            
     
            ss.SaveAsFile(screenshotfilename);
            */

       /*     
            //Browser Screenshot
            ITakesScreenshot ts = ((ITakesScreenshot)driver); // object of type takesscreenshot
            Screenshot capturescreen = ts.GetScreenshot(); // 
            capturescreen.SaveAsFile("D:\\Test\\screenshot1.jpg");


            //WebElement screenshot
            IWebElement e = null;// = driver.FindElement(By.Id("password-visibility-toggle"));
           

            try
            {
                ts = (ITakesScreenshot)e;
                capturescreen = ts.GetScreenshot();
                capturescreen.SaveAsFile("D:\\Test\\show.jpg");
            }
            catch(Exception fe)
            {
                Console.WriteLine(fe.Message);
            }
            FirefoxOptions ff = new FirefoxOptions();
            ff.AcceptInsecureCertificates = true;

        

            Console.ReadKey();*/

        }

    }
}
