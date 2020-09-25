Axelerant Test Demo by Mudasir Hussain

Components of Framework
1.  Selenium    
2.  NUnit        
3.  C#            

Framework Structure
Framework is configured using the Page Object Model Design framework, Decorator pattern.

Pages
HomePage is placed under Pages.There are diverse sections page that exist in Pages Folder like Women Section,T-Shirts Section,NewsLetter Subscription section etc

Parallelization
I have used the NUnit Parallelizable feature in the assemblyinfo.cs code by using NUnit Framework.

Tests: Total Tests=10

1)CheckOut category                 -> VerifyCheckOutByAddingProduct
2)NewsLetterSubscription            -> NewsLetterBlankEmailSubscription,NewsLetterPresentAtFooter,NewsLetterValidEmailSubscription,NewsLetterInvalidEmailSubscription
3)Verification of Header and Footer -> VerifyHeaderFooter,VerifyHeaderFooterInWomenPage,VerifyHeaderFooterSignInPage
4)Summer Dresses Listing Page       -> ApplyFilterVerifyResult,ApplySortPriceandProductNameVerifyResults







Pre-Requisites for this Framework
1.  Nuget package Manager 
2.  Browser Drivers - Download the necessary drivers chromedriver, firefoxdriver etc
3.  Dependent Nuget Manager files - Download all the prerequistes for the same.
4.  C#
5. Browsers - Chrome/FireFox/IE etc





How To run Tests
Build the solution and then run tests.Tests are categorized by their test category and are displaying under same categories.Some Tests were not valid as they result in hanging.