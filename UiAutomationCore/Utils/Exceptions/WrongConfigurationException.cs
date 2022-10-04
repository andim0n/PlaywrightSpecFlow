using System;

namespace UiAutomationCore.Utils.Exceptions
{
    public class WrongConfigurationException : Exception
    {
        public WrongConfigurationException() {}
        public WrongConfigurationException(string message) : base(message) {}
        public WrongConfigurationException(string message, Exception inner) : base(message, inner) {}
    }
}