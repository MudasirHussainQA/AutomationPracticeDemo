
using AutomationPracticeDemo.Pages.Sections.NewsletterSubscriptionSection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo
{
    public class HomePage : NavigatableShopPage
    {
        private readonly HomePageElements _elements;
        private HomePage(Driver driver) 
            : base(driver)
        {
            
            _elements = new HomePageElements(driver);
        }

        
        protected override string Url => "http://automationpractice.com/";

        public HomePage NavigatetoHomePage()
        {
            Open();            
            return this;
        }
        protected override void WaitForPageLoad()
        {
            _elements.NewsletterBlock.WaitToExists();
        }

        public HomePage AssertMessageNotificationforNewsLetterEmail(string expectedMessage)
        {
            Assert.AreEqual(_elements.MessageAlert.Text, expectedMessage);
            return this;
        }

        public HomePage AssertNewsLetterIsPresentAtFooter()
        {
            Assert.IsTrue(_elements.NewsletterBlock.Displayed.HasValue);

            return this;

        }

        public HomePage AssertHeaderandFooter()
        {
            Assert.AreEqual(_elements.Categories.Text, "Categories");
            Assert.AreEqual(_elements.ShopPhone.Text, "0123-456-789");
            Assert.AreEqual(_elements.NewsletterBlock.Text, "Newsletter");
            Assert.AreEqual(_elements.Information.Text, "Information");
            Assert.AreEqual(_elements.SocialBlock.Text, "Follow us");
            Assert.IsTrue(_elements.HeaderBanner.Displayed.Value, "Header banner is absent");
            Assert.AreEqual(_elements.ContactLink.Text, "Contact us"); ;
            return this;

        }
        


            
    }
}
