using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace NLog
{
    public static class NLogExtensions
    {
        //private static LogMessageGenerator messageGenerator => "Hallo";
        //private static string FormatMessage(string format, params object[] args) => string.Format(format, args);
        //private static ILogger Logger;

        public static LogLevel LogLevel { get; set; } = LogLevel.Debug;

        #region EnterMethod
        private static Action<Logger, string, string, string> _Enter = (logger, format, sender, method)
            => logger.Log(LogLevel, format, sender, method);
        public static Action<Logger, string, string, string> Enter
        {
            get => _Enter;
            set { if (value != null) _Enter = value; }
        }

        public const string DefaultEnterMethodFormat = ">> EnterMethod: {0}.{1}()";

        private static string _EnterMethodFormat = DefaultEnterMethodFormat;
        public static string EnterMethodFormat
        {
            get { return _EnterMethodFormat; }
            set { if (!string.IsNullOrEmpty(value)) _EnterMethodFormat = value; }
        }

        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Generic-marker T is wanted")]
        public static void EnterMethod<T>(this Logger logger, T sender, [CallerMemberName] string method = "")
            => _Enter(logger, EnterMethodFormat, typeof(T).Name, method);
        #endregion

        #region ExitMethod
        private static Action<Logger, string, string, string> _Exit = (logger, format, sender, method)
            => logger.Log(LogLevel, format, sender, method);
        public static Action<Logger, string, string, string> Exit
        {
            get => _Exit;
            set { if (value != null) _Exit = value; }
        }

        public const string DefaultExitMethodFormat = "<< ExitMethod: {0}.{1}()";

        private static string _ExitMethodFormat = DefaultExitMethodFormat;
        public static string ExitMethodFormat
        {
            get { return _ExitMethodFormat; }
            set { if (!string.IsNullOrEmpty(value)) _ExitMethodFormat = value; }
        }

        [SuppressMessage("Style", "IDE0060:Remove unused parameter", Justification = "Generic-marker T is wanted")]
        public static void ExitMethod<T>(this Logger logger, T sender, [CallerMemberName] string method = "")
            => _Exit(logger, ExitMethodFormat, typeof(T).Name, method);
        #endregion
    }
}