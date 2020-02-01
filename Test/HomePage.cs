using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class HomePage : TestBase
    {

        //(Test-1)
        [FindsBy(How = How.Id, Using = "inputEmail")]
	    IWebElement Email;



        [FindsBy(How = How.Id, Using = "inputPassword")]
	IWebElement Password;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Sign in')]")]
	IWebElement Signin;


    public HomePage()
    {
        PageFactory.InitElements(driver, this);
    }

    public String validateHomePageTitle()
    {
            return driver.Title;
    }

    public void login(String em, String pwd)
    {
        Email.SendKeys(em);
        Password.SendKeys(pwd);
        Signin.Click();
    }

    //(Test-2)
        [FindsBy(How = How.XPath, Using = "//ul[@class='list-group']//li")]
        IList<IWebElement> list_items;

    [FindsBy(How=How.XPath, Using = "//ul[@class='list-group']//li[2]")]

    IWebElement listitemstext;

    [FindsBy(How = How.XPath, Using = "//ul[@class='list-group']//li[2]//span")]

    IWebElement listitemsbadgetext;


    public void ListItem()
    {
            int count = list_items.Count;
        Assert.AreEqual(count, 3);

        String validateText = listitemstext.Text;
        Assert.AreEqual(validateText, "List Item 2 6");

        String validateBadge = listitemsbadgetext.Text;
        Assert.AreEqual(validateBadge, "6");
    }


    //(Test-3)
    [FindsBy(How = How.XPath, Using = "//button[@id='dropdownMenuButton']")]

    IWebElement DropDownItem1;

    [FindsBy(How = How.XPath, Using = "//button[@id='dropdownMenuButton']")]

    IWebElement DropDownItem2;

    [FindsBy(How = How.XPath, Using = "//a[@class='dropdown-item'][3]")]

    IWebElement DropDownItem3;

    public void DropDown()
    {

        String textString = DropDownItem1.Text;
        Assert.AreEqual(textString, "Option 1");

        DropDownItem2.Click();
        DropDownItem3.Click();
    }


    //(Test-4)
    [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Button')])[1]")]

    IWebElement button1;

    [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Button')])[2]")]

    IWebElement button2;

    public void Button1()
    {

        Assert.AreEqual(button1.Enabled, true);

        Assert.AreEqual(button2.Enabled, false);
    }


    //(Test-5)
    [FindsBy(How = How.XPath, Using = "(//button[contains(text(),'Button')])[3]")]

    IWebElement button3;

    public void Button3()
    {
        //Thread.sleep(5000);
        TestUtilities.dynamicWait(driver, button3, 50000);
        Assert.AreEqual(button3.Enabled, true);
    }


    //(Test-6)
    [FindsBy(How = How.XPath, Using = "//table[@class='table table-bordered table-dark']//tbody//tr[3]//td[3]")]
    IWebElement tabletext;

    public void Table()
    {
        String validateCellText = tabletext.Text;

        Assert.AreEqual(validateCellText, "Ventosanzap");

    }
}


}
