using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo
{
    public interface IElementFindService
    {
        Element FindElement(By locator);
        List<Element> FindElements(By locator);
    }
}
