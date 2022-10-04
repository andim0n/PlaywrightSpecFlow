using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
//using UiAutomationCore.UI.Browser;
using UiAutomationCore.Utils.ExtentReport;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using AssertionException = UiAutomationCore.Utils.Exceptions.AssertionException;

namespace UiAutomationCore.Utils
{
    public class SoftAssert
    {
        private readonly ThreadLocal<List<string>> _assertionsMessages = new ThreadLocal<List<string>>();

        public void Add(params Action[] actions)
        {
            actions.ToList().ForEach(Add);
        }

        public void Add(Action action)
        {
            _assertionsMessages.Value ??= new List<string>();
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                _assertionsMessages.Value.Add(exception.Message);

                LogError(exception.Message);
            }
        }

        public void AssertAll()
        {
            Logger.Info("-----------Test Finished-----------");

            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                //ExtentTestManager.GetTest().AddScreenCaptureFromBase64String(
                //BrowserFactory.BrowserInstance.TakeScreenshot(), "Screenshot of the test when it failed.");
                LogError(TestContext.CurrentContext.Result.Message);
                ExtentTestManager.CreateMethod("Exception");
                LogError(TestContext.CurrentContext.Result.Message +
                         $". StackTrace: {TestContext.CurrentContext.Result.StackTrace}");
            }

            if (_assertionsMessages.Value == null || _assertionsMessages.Value.Count == 0) return;

            var messages = new List<string>(_assertionsMessages.Value);
            _assertionsMessages.Value.Clear();

            throw new AssertionException(messages);
        }

        private static void LogError(string message)
        {
            Logger.Fatal("ERROR => !**!**!**!**!**!**!**!**!**!**!**!**!");
            Logger.Fatal($"         {message}");
            Logger.Fatal("         !**!**!**!**!**!**!**!**!**!**!**!**!");
        }
    }
}