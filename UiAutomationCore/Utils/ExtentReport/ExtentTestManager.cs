using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using AventStack.ExtentReports;

namespace UiAutomationCore.Utils.ExtentReport
{
    public static class ExtentTestManager
    {
        private static readonly Dictionary<string, ExtentTest> ParentTestMap = new Dictionary<string, ExtentTest>();
        private static readonly ThreadLocal<ExtentTest> ParentTest = new ThreadLocal<ExtentTest>();
        private static readonly ThreadLocal<ExtentTest> ChildTest = new ThreadLocal<ExtentTest>();

        private static readonly object SyncLock = new object();

        public static ExtentTest CreateTest(string testName, string description = null)
        {
            testName = NormalizeName(testName);
            lock (SyncLock)
            {
                ParentTest.Value = ExtentService.Instance.CreateTest(testName, description);
                return ParentTest.Value;
            }
        }

        public static ExtentTest CreateMethod(string parentName, string testName, string description = null)
        {
            lock (SyncLock)
            {
                ExtentTest parentTest = null;
                if (!ParentTestMap.ContainsKey(parentName))
                {
                    parentTest = ExtentService.Instance.CreateTest(testName);
                    ParentTestMap.Add(parentName, parentTest);
                }
                else
                {
                    parentTest = ParentTestMap[parentName];
                }

                ParentTest.Value = parentTest;
                ChildTest.Value = parentTest.CreateNode(testName, description);
                return ChildTest.Value;
            }
        }

        private static string NormalizeName(string name)
        {
            var nameParts = name.Split("_").ToList();
            var method = nameParts[0];
            var description = nameParts.Last();
            nameParts.Remove(method);
            nameParts.Remove(description);
            description = string.Join(" ", Regex.Split(description, @"(?<!^)(?=[A-Z])")).ToLower();

            var preparedUrl = nameParts
                .Select(part => part.ToLower().Contains("id") ? $"{{{part.ToLower()}}}" : part.ToLower()).ToList();
            var url = string.Join("/", preparedUrl).ToLower();
            return $"[{method}] /{url} - {description}";
        }

        public static ExtentTest CreateMethod(string testName)
        {
            lock (SyncLock)
            {
                ChildTest.Value = ParentTest.Value.CreateNode(testName);
                return ChildTest.Value;
            }
        }

        public static ExtentTest GetMethod()
        {
            lock (SyncLock)
            {
                return ChildTest.Value;
            }
        }

        public static ExtentTest GetTest()
        {
            lock (SyncLock)
            {
                return ParentTest.Value;
            }
        }
    }
}