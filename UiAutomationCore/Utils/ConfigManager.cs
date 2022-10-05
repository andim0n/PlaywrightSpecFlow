﻿using Microsoft.Extensions.Configuration;

namespace UiAutomationCore.Utils
{
    public static class ConfigManager
    {
        public static IConfiguration Configuration => new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();

        public static string BaseUiUrl => Configuration["Pages:BaseьUiUrl"];
        public static string WebTablesPageUrl => Configuration["Pages:WebTablesPageUrl"];
        public static string BooksPageUrl => Configuration["Pages:BooksPageUrl"];
        public static string ChromeBrowser => Configuration["Browsers:Chrome"];
        public static string FirefoxBrowser => Configuration["Browsers:Firefox"];
        public static string OperaBrowser => Configuration["Browsers:Opera"];

        public static float WaitTimeout => (float)Convert.ToDouble(Configuration["Timeouts:Wait"]);
    }
}