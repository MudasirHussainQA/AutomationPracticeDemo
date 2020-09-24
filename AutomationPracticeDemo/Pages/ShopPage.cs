using AutomationPracticeDemo.Pages.Sections.MainMenuSection;
using AutomationPracticeDemo.Pages.Sections.NewsletterSubscriptionSection;
using AutomationPracticeDemo.Pages.Sections.SignInSection;
using AutomationPracticeDemo.Pages.Sections.WomenSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo
{
    public abstract class ShopPage
    {
        protected readonly Driver Driver;

        public ShopPage(Driver driver)
        {
            Driver = driver;
            NewsletterSubscriptionSection = new NewsletterSubscriptionSection(driver);
            MainMenuSection = new MainMenuSection(driver);
            SignInSection = new SignInSection(driver);
            WomenSection = new WomenSection(driver);
        }
        public NewsletterSubscriptionSection NewsletterSubscriptionSection { get; }

        public MainMenuSection MainMenuSection { get; }

        public SignInSection SignInSection { get; }

        public WomenSection WomenSection { get; }
    }
}
