using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDET47CSharp.Generic.Utilities
{
    public class IWebDriverUtilities
    {
        public void ImplicitlyWaitingInSeconds(IWebDriver driver,int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(seconds);
        }

        public void ExplicitlyWaitingTillTitleContains(IWebDriver driver , int seconds,string titleContains)
        {
            WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            webDriverWait.Until(ExpectedConditions.TitleContains(titleContains));
        }
        public void MaximizeTheBrowser(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
    }
}
