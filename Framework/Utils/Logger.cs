using System;
using System.IO;
using System.Threading;
using NLog;
using NLog.Config;
using NLog.Layouts;
using NLog.Targets;

namespace Framework.Utils
{
    public class Logger
    {
        private static readonly Lazy<Logger> LazyInstance = new Lazy<Logger>((Func<Logger>) (() => new Logger()));

        private static readonly ThreadLocal<ILogger> Log = new ThreadLocal<ILogger>((Func<ILogger>) (() =>
            (ILogger) LogManager.GetLogger(Thread.CurrentThread.ManagedThreadId.ToString())));

        private Logger()
        {
            try
            {
                LogManager.LoadConfiguration("NLog.config");
            }
            catch (FileNotFoundException)
            {
                LogManager.Configuration = this.GetConfiguration();
            }
        }

        private LoggingConfiguration GetConfiguration()
        {
            string str = "${date:format=yyyy-MM-dd HH\\:mm\\:ss} ${level:uppercase=true} - ${message}";
            LoggingConfiguration loggingConfiguration = new LoggingConfiguration();
            LogLevel info = LogLevel.Info;
            LogLevel fatal1 = LogLevel.Fatal;
            ConsoleTarget consoleTarget = new ConsoleTarget("logconsole");
            consoleTarget.Layout = (Layout) str;
            loggingConfiguration.AddRule(info, fatal1, (Target) consoleTarget);
            LogLevel debug = LogLevel.Debug;
            LogLevel fatal2 = LogLevel.Fatal;
            FileTarget fileTarget = new FileTarget("logfile");
            fileTarget.FileName = (Layout) "../../../Log/log.log";
            fileTarget.Layout = (Layout) str;
            loggingConfiguration.AddRule(debug, fatal2, (Target) fileTarget);
            return loggingConfiguration;
        }

        /// <summary>Gets Logger instance.</summary>
        public static Logger Instance => Logger.LazyInstance.Value;

        /// <summary>Log debug message and optional exception.</summary>
        /// <param name="message">Message</param>
        /// <param name="exception">Exception</param>
        public void Debug(string message, Exception exception = null) => Logger.Log.Value.Debug(exception, message);

        /// <summary>Log info message.</summary>
        /// <param name="message">Message</param>
        public void Info(string message) => Logger.Log.Value.Info(message);

        /// <summary>Log warning message.</summary>
        /// <param name="message">Message</param>
        public void Warn(string message) => Logger.Log.Value.Warn(message);

        /// <summary>Log error message.</summary>
        /// <param name="message">Message</param>
        public void Error(string message) => Logger.Log.Value.Error(message);

        /// <summary>Log fatal message and exception.</summary>
        /// <param name="message">Message</param>
        /// <param name="exception">Exception</param>
        public void Fatal(string message, Exception exception) => Logger.Log.Value.Fatal(exception, message);
    }
}