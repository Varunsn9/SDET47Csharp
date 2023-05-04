using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Net.NetworkInformation;

namespace SDET47CSharp.Object_Repo.LoginPage
{
    
    public class LoginPageElements
    {
        [FindsBy(How = How.Name, Using = "user_name")]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "user_password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement LoginButton { get; set; }

        public LoginPageElements(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        public void Login(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Click();
        }
    }
}
