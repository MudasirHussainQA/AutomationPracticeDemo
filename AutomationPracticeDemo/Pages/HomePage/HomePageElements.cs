using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo
{
    public class HomePageElements
    {
        private readonly Driver _driver;

        public HomePageElements(Driver driver)
        {
            _driver = driver;
        }
        public Element NewsletterBlock => _driver.FindElement(By.CssSelector("div[id*='newsletter_block'] h4"));
        public Element SocialBlock => _driver.FindElement(By.CssSelector("section[id='social_block'] h4"));
        public Element Categories => _driver.FindElement(By.CssSelector("section[class*='blockcategories'] h4"));
        public Element Information => _driver.FindElement(By.CssSelector("section[id*='block_various_links_footer'] h4"));
        public Element MyAccount => _driver.FindElement(By.CssSelector("a[title*='Manage my customer account']"));
        public Element HeaderBanner => _driver.FindElement(By.CssSelector("img[class='img-responsive']"));
        public Element ShopPhone => _driver.FindElement(By.CssSelector("span[class='shop-phone'] strong"));

        public Element ContactLink => _driver.FindElement(By.CssSelector("div[id='contact-link'] a"));

        public Element UserInfo => _driver.FindElement(By.CssSelector("div[class='header_user_info'] span"));

        public Element MessageAlert => _driver.FindElement(By.CssSelector("p[class='alert alert-danger']"));
       

        

    }
}
