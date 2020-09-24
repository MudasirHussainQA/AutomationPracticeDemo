using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.Pages.Sections.NewsletterSubscriptionSection
{
    public class NewsletterSubscriptionSection
    {
        private readonly Driver _driver;

        public NewsletterSubscriptionSection(Driver driver)
        {
            _driver = driver;
        }
       

        private Element NewsletterEmailField => _driver.FindElement(By.CssSelector("input[id*='newsletter']"));

        private Element NewsLetterEmailIcon => _driver.FindElement(By.CssSelector("button[name='submitNewsletter']"));

        public void EnterNewsLetterEmail(string searchText)
        {
            NewsletterEmailField.TypeText(searchText);
        }
        public void SubmitNewsletterEmail()
        {
            NewsLetterEmailIcon.Click();
        }

    }
}
