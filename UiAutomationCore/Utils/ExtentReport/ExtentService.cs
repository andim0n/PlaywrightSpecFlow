//using System;
//using AventStack.ExtentReports.Reporter;
//using AventStack.ExtentReports.Reporter.Configuration;
//using AventStack.ExtentReports;

//namespace UiAutomationCore.Utils.ExtentReport
//{
//    public static class ExtentService
//    {
//        private static readonly Lazy<ExtentReports> Lazy =
//            new Lazy<ExtentReports>(() => new ExtentReports());

//        static ExtentService()
//        {   
//            var uniqueName = DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") + "_test_run";
//            var reporter = new ExtentHtmlReporter($".\\{uniqueName}\\");
//            reporter.Config.DocumentTitle = "AutoTests";
//            reporter.Config.Theme = Theme.Standard;
//            Instance.AttachReporter(reporter);
//        }

//        public static ExtentReports Instance => Lazy.Value;
//    }
//}