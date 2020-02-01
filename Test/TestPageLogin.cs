using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class TestPageLogin : TestBase
    {

        HomePage HomePage;
       // HomePage homepage;

    public static IWebDriver driver;


    public TestPageLogin() : base()
    {
        
    }

    
    [OneTimeSetUp]
    public void setUp()
    {
        initialization();
        HomePage = new HomePage();
    }


    [Test, Order(1)]
    public void HomePage1()
    {
        HomePage.login("zak2020@yahoo.com", "password");
    }


    [Test,Order(2)]

    public void ListItemTest()
    {
        HomePage.ListItem();
    }


    [Test, Order(3)]

    public void DropDownItemTest()
    {
        HomePage.DropDown();
    }


    [Test, Order(4)]

    public void ButtonTest1()
    {
        HomePage.Button1();
    }


    [Test, Order(5)]

    public void ButtonTest2()
    {
        HomePage.Button3();
    }


    [Test, Order(6)]

    public void TableTest()
    {
        HomePage.Table();
    }


        [OneTimeTearDown]
        public void closeBrowser() {
            driver.Quit();
        }
    }
    class dummy
    {
        public static void Main(String[] args)
        {

        }
    }
}
