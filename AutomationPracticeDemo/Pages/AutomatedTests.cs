using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomationPracticeDemo.Pages.Sections.NewsletterSubscriptionSection;


namespace AutomationPracticeDemo
{
    [TestClass]
    public class AutomatedTests
    {
        private static App _app;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _app = new App();
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _app.Dispose();
        }

        [TestMethod, TestCategory("NewsletterSubscription")]
        public void NewsLetterValidEmailSubscription()
        {
            var homePage = _app.GoTo<HomePage>();
            homePage.NewsletterSubscriptionSection.EnterNewsLetterEmail("mudsr6july@gmail.com");
            homePage.NewsletterSubscriptionSection.SubmitNewsletterEmail();            
            homePage.AssertMessageNotificationforNewsLetterEmail("Newsletter : This email address is already registered.");            
            
            
        }
        [TestMethod, TestCategory("NewsletterSubscription")]
        public void NewsLetterInvalidEmailSubscription()
        {
            var homePage = _app.GoTo<HomePage>();
            homePage.NewsletterSubscriptionSection.EnterNewsLetterEmail("123");
            homePage.NewsletterSubscriptionSection.SubmitNewsletterEmail();
            homePage.AssertMessageNotificationforNewsLetterEmail("Newsletter : Invalid email address.");

        }

        [TestMethod, TestCategory("NewsletterSubscription")]

        public void NewsLetterBlankEmailSubscription()
        {
            var homePage = _app.GoTo<HomePage>();           
            homePage.NewsletterSubscriptionSection.SubmitNewsletterEmail();
            homePage.AssertMessageNotificationforNewsLetterEmail("Newsletter : Invalid email address.");
        }

        [TestMethod, TestCategory("NewsletterSubscription")]

        public void NewsLetterPresentAtFooter()
        {
            var homePage = _app.GoTo<HomePage>();
            homePage.AssertNewsLetterIsPresentAtFooter();

        }

        [TestMethod, TestCategory("CheckoutCase")]
        public void VerifyCheckOutByAddingProduct()
        {
            var homepage = _app.GoTo<HomePage>();
            homepage.MainMenuSection.OpenSignInPage();
            homepage.SignInSection.SignInApplication("mudsr6july@gmail.com","12345");
            homepage.MainMenuSection.OpenWomenPage();
            homepage.WomenSection.SelectProductInWomenSection();
            homepage.WomenSection.AssertTotalAmountOnCheckoutPage();  
                                 

        }

        [TestMethod, TestCategory("VerificationofHeaderandFooter")]
        public void VerifyHeaderFooter()
        {
            var homepage = _app.GoTo<HomePage>();
            homepage.AssertHeaderandFooter();

        }

        [TestMethod, TestCategory("VerificationofHeaderandFooter")]
        public void VerifyHeaderFooterSignInPage()
        {
            var homepage = _app.GoTo<HomePage>();
            homepage.MainMenuSection.OpenSignInPage();
            homepage.AssertHeaderandFooter();

        }

        [TestMethod, TestCategory("VerificationofHeaderandFooter")]
        public void VerifyHeaderFooterInWomenPage()
        {
            var homepage = _app.GoTo<HomePage>();
            homepage.MainMenuSection.OpenWomenPage();
            homepage.AssertHeaderandFooter();

        }

        [TestMethod, TestCategory("SummerDressesListingPage")]
        public void ApplySortPriceandProductNameVerifyResults()
        {
            var homepage = _app.GoTo<HomePage>();
            homepage.MainMenuSection.OpenWomenPage();
            homepage.WomenSection.VerifySortingOptions();

        }

        [TestMethod, TestCategory("SummerDressesListingPage")]
        public void ApplyFilterVerifyResult()
        {
            var homepage = _app.GoTo<HomePage>();
            homepage.MainMenuSection.OpenWomenPage();
        }
    }
}
