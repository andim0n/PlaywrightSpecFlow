using System;
using System.IO;
using System.Linq;

namespace ABApiAutomation.Utils
{
    public static class DirectoryHelper
    {
        private static DirectoryInfo _tempDirectory;

        public static DirectoryInfo GetSolutionDirectory()
        {
            var directory = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            while (directory != null && !directory.GetFiles("*.sln").Any()) directory = directory.Parent;
            return directory;
        }

        public static DirectoryInfo GetTempDirectory()
        {
            return _tempDirectory ??= GetSolutionDirectory().CreateSubdirectory("temp");
        }

        public static void UpdateCurrentDirectory()
        {
            var dir = Path.GetDirectoryName(typeof(DirectoryHelper).Assembly.Location);
            Environment.CurrentDirectory = dir;
        }
    }
}