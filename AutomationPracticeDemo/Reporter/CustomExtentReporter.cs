using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.Reporter
{
    public class CustomExtentReporter
    {
        private readonly ExtentHtmlReporter extentHtmlReporter;

        private readonly ExtentReports extentReports;

        private static CustomExtentReporter customExtentReporter;

        private CustomExtentReporter()
        {
            extentHtmlReporter = new ExtentHtmlReporter(@"C:\Users\Mudasir\Documents\Visual Studio 2015\Projects\AutomationPracticeDemo\TestDisplayResults");
            extentReports = new ExtentReports();
            extentReports.AttachReporter(extentHtmlReporter);
        }

        public static CustomExtentReporter GetInstance()
        {
            if (customExtentReporter == null)
            {
                customExtentReporter = new CustomExtentReporter();
            }

            return customExtentReporter;

        }

        public void AddToReport(string name, string description, UnitTestOutcome status, string error)
        {
            switch (status)
            {
                case UnitTestOutcome.Passed:
                    extentReports.CreateTest(name, description).Pass("");
                    break;
                case UnitTestOutcome.Failed:
                    extentReports.CreateTest(name, description).Fail(error);
                    break;
                default:
                    extentReports.CreateTest(name, description).Skip("");
                    break;
            }
        }

        public void WriteReport()
        {
            extentReports?.Flush();
        }


    }
}
