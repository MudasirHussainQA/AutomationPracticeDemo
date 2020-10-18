using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.ReportAttribute
{
    //[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestMethodWithReport : TestMethodAttribute
    {
        private readonly object syslock = new object();
        public override TestResult[] Execute(ITestMethod testMethod)
        {
            var name = testMethod.TestClassName + "." + testMethod.TestMethodName;
            var result = base.Execute(testMethod);
            var execution = result.FirstOrDefault();
            var status = execution.Outcome;
            var errormsg = execution?.TestFailureException?.Message;
            var trace = execution?.TestFailureException?.StackTrace;

            lock (syslock)
            {
                //object CustomExtentReporter = null;
                CustomExtentReporter.GetInstance().AddToReport(name, "", status, errormsg + "\n" + trace);
            }

            return result;
        }
    }

}
