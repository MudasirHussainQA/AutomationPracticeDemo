using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo
{
    public abstract class NavigatableShopPage:ShopPage
    {
        protected NavigatableShopPage(Driver driver)
        : base(driver)
        {
        }

        protected abstract string Url { get; }

        public void Open()
        {
            Driver.GoToUrl(Url);
            WaitForPageLoad();
        }

        protected abstract void WaitForPageLoad();

    }
}
