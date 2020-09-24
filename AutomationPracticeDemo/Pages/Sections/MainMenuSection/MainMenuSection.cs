using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.Pages.Sections.MainMenuSection
{
    public class MainMenuSection
    {
        private readonly Driver _driver;

        public MainMenuSection(Driver driver)
        {
            _driver = driver;
        }

        private Element WomenLink => _driver.FindElement(By.LinkText("Women"));
        private Element DressesLink => _driver.FindElement(By.LinkText("Blog"));
        private Element CartLink => _driver.FindElement(By.LinkText("Cart"));
        private Element TShirtsLink => _driver.FindElement(By.LinkText("T-SHIRTS"));
        private Element MyAccountLink => _driver.FindElement(By.LinkText("My Account"));
        private Element PromotionsLink => _driver.FindElement(By.LinkText("Promotions"));

        private Element SignIn => _driver.FindElement(By.CssSelector("a[title='Log in to your customer account']"));

        public void OpenWomenPage()
        {
            WomenLink.Click();
        }

        public void OpenDressesPage()
        {
            DressesLink.Click();
        }

        public void OpenTShirtsPage()
        {
            TShirtsLink.Click();
        }

        public void OpenPromotionsPage()
        {
            PromotionsLink.Click();
        }

        public void OpenSignInPage()
        {
            SignIn.Click();
        }
    }
}
