using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.Pages.Sections.SignInSection
{
    public class SignInSection
    {
        private readonly Driver _driver;
        public SignInSection(Driver driver)
        {
            _driver = driver;
        }

        private Element EmailID => _driver.FindElement(By.CssSelector("input[id='email']"));

        private Element Password => _driver.FindElement(By.CssSelector("input[id='passwd']"));

        private Element SignInButton => _driver.FindElement(By.CssSelector("button[id='SubmitLogin']"));

        public void SignInApplication(string username, string password)
        {

            EmailID.TypeText(username);
            Password.TypeText(password);            
            SignInButton.Click();

        }


    }
}
