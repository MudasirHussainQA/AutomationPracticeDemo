using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeDemo.Reporter
{
    [TestClass]
    public class ReportInitialize
    {

        [AssemblyCleanup]
        public static void CleanUp()
        {
            CustomExtentReporter.GetInstance().WriteReport();
        }

    }
}
