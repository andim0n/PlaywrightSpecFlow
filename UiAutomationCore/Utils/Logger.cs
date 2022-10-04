//using System;
//using UiAutomationCore.Utils.ExtentReport;
////using Serilog;
////using Serilog.Events;
////using Serilog.Sinks.SystemConsole.Themes;

//namespace UiAutomationCore.Utils
//{
//    public static class Logger
//    {
//        //private static ILogger? _logger;
//        //private static ILogger Log => _logger ??= new LoggerConfiguration()
//            //.MinimumLevel.Override("Microsoft", LogEventLevel.Fatal)
//            //.MinimumLevel.Debug().WriteTo.Console(theme: AnsiConsoleTheme.Code).CreateLogger();

//        public static void Info(string message)
//        {
//            Log.Information(message);
//            try
//            {
//                ExtentTestManager.GetMethod().Info(message);
//            }
//            catch (Exception)
//            {
//                // ignored
//            }
//        }

//        public static void Info (string message, params object?[]? values) => Log.Information(message, values);

//        public static void Debug(string message)
//        {
//            Log.Debug(message);
//            try { ExtentTestManager.GetMethod().Debug(message); }
//            catch (Exception)
//            {
//                // ignored
//            }
//        }

//        public static void Warning(string message)
//        {
//            Log.Warning(message);
//            try { ExtentTestManager.GetMethod().Warning(message); }
//            catch (Exception)
//            {
//                // ignored
//            }
//        }

//        public static void Error(string message)
//        {
//            Log.Error(message);
//            try
//            {
//                ExtentTestManager.GetMethod().Error(message);
//            }
//            catch (Exception)
//            {
//                // ignored
//            }
//        }

//        public static void Fatal(string message)
//        {
//            Log.Fatal(message);
//            try { ExtentTestManager.GetMethod().Fail(message); }
//            catch (Exception)
//            {
//                //ignored
//            }
//        }
//    }
//}