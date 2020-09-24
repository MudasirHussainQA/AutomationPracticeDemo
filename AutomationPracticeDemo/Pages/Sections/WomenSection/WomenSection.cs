using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.Pages.Sections.WomenSection
{
    public class WomenSection
    {
        private readonly Driver _driver;

        public WomenSection(Driver driver)
        {
            _driver = driver;
        }

        private Element ProductSelect => _driver.FindElement(By.XPath("(//a[@class='product_img_link'])[1]"));

        private Element DressesIcon => _driver.FindElement(By.XPath("(//span[@class='grower CLOSE'])[2]"));

        private Element SummerDresses => _driver.FindElement(By.CssSelector("li[class='last'] a[title='Short dress, long dress, silk dress, printed dress, you will find the perfect dress for summer.']"));

        private Element SelectDropdown => _driver.FindElement(By.CssSelector("select[id='selectProductSort']"));

        private Element AddToCartButton => _driver.FindElement(By.CssSelector("p[id='add_to_cart']"));

        private Element FilterOption => _driver.FindElement(By.CssSelector("input[id='layered_id_feature_3']"));

        private Element ProceedToCheckout => _driver.FindElement(By.CssSelector("a[title='Proceed to checkout']"));

        private Element AgreeToTerms => _driver.FindElement(By.CssSelector("input[id='cgv']"));

        private Element TotalProductsPrice => _driver.FindElement(By.CssSelector("td[id='total_product']"));

        private Element TotalShippingAmount => _driver.FindElement(By.CssSelector("td[id='total_shipping']"));

        private Element TaxAmount => _driver.FindElement(By.CssSelector("td[id='total_tax']"));

        private Element TotalAmount => _driver.FindElement(By.CssSelector("span[id='total_price']"));

        private string  totalproductprice => TotalProductsPrice.Text.Split()[0].TrimEnd('$');

        private string totalshippmentamount => TotalShippingAmount.Text.Split()[0].TrimEnd('$');

        private string taxamount => TaxAmount.Text.Split()[0].TrimEnd('$');

        private string totalamount => TotalAmount.Text.Split()[0].TrimEnd('$');





        public void SelectProductInWomenSection()
        {
           
            ProductSelect.Click();
            
            
            AddToCartButton.Click();            
            ProceedToCheckout.Click();            
            ProceedToCheckout.Click();            
            ProceedToCheckout.Click();           
            AgreeToTerms.Click();            
            ProceedToCheckout.Click();            
        }

        public void AssertTotalAmountOnCheckoutPage()
        {
            Assert.AreEqual((totalproductprice + totalshippmentamount + taxamount), totalamount);
        }

        public void VerifySortingOptions()
        {
            DressesIcon.Click();
            SummerDresses.Click();
            //var selectelement = new SelectElement(SelectDropdown);
            //selectelement.SelectByText("Product Name: Z to A");
           // selectelement.SelectByText("Price: Highest first");


        }

        public void ApplyFilterInSummerListingPage()
        {
            DressesIcon.Click();
            SummerDresses.Click();
            FilterOption.Click();
        }
            
    }
}
