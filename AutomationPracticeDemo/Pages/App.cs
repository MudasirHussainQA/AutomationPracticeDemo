using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace AutomationPracticeDemo
{
    public class App : IDisposable
    {
        private readonly Driver _driver;
        private bool _disposed = false;

        public App(Browser browserType = Browser.Chrome)
        {
            _driver = new LoggingDriver(new WebDriver());
            _driver.Start(browserType);
            BrowserService = _driver;
            CookiesService = _driver;
            DialogService = _driver;
        }

        public IBrowserService BrowserService { get; }
        public ICookiesService CookiesService { get; }
        public IDialogService DialogService { get; }

        public TPage Create<TPage>()
            where TPage : ShopPage
        {
            var constructor = typeof(TPage).GetTypeInfo().GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault();
            var page = constructor?.Invoke(new object[] { _driver }) as TPage;
            return page;
        }

        public TPage GoTo<TPage>()
            where TPage : NavigatableShopPage
        {
            var constructor = typeof(TPage).GetTypeInfo().GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance).FirstOrDefault();
            var page = constructor?.Invoke(new object[] { _driver }) as TPage;
            page?.Open();

            return page;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                _driver.Quit();
            }

            _disposed = true;
        }

    }
}
