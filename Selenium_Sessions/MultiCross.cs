using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Sessions
{
    class MultiCross
    {

        public static void Main(String[] args)
        {

            //url for the client to connect the hub
            Uri u = new Uri(" http://192.168.1.14:4444/wd/hub");

           // DesiredCapabilities config = new DesiredCapabilities();

            //config.SetCapability("browser", "chrome");

            // user browser specific options to confugure...

            FirefoxOptions f = new FirefoxOptions();
            //     f.BrowserName = "firefox";
            f.PlatformName = "windows";

         
            //use remote webdriver...
            IWebDriver d1 = new RemoteWebDriver(u, f);
            d1.Url = "https://www.linkedin.com";

            Console.WriteLine(d1.Title);

          /*  IWebDriver d2 = new FirefoxDriver();

            d2.Url = "https://www.linkedin.com/legal/user-agreement?trk=d_checkpoint_lg_consumerLogin_ft_user_agreement";

            Console.WriteLine(d1.Title);*/
        }
    }
}
