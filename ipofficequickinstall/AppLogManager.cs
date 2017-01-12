using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Core;
using log4net.Appender;
using log4net.Layout;
using log4net.Config;

namespace ipofficequickinstall
{
    public class AppLogManager
    {
        public static void ConfigureAppender(string filePath, AppenderType appendType)
        {
            var fileAppender = GetAppender(filePath, appendType);
            BasicConfigurator.Configure(fileAppender);
            ((Hierarchy)LogManager.GetRepository()).Root.Level = Level.All;
        }
        private static IAppender GetAppender(string filePath, AppenderType appendType)
        {
            var layout = new PatternLayout("%date %10level %30C.%M - %message%newline");
            //var layout = new PatternLayout("%date %-5level %logger [%C.%M] - %message%newline");
            layout.ActivateOptions(); // According to the docs this must be called as soon as any properties have been changed.

            if (appendType == AppenderType.FileAppender)
            {
                var appender = new FileAppender
                {
                    File = filePath,
                    Encoding = Encoding.UTF8,
                    Threshold = Level.Debug,
                    Layout = layout
                };
                appender.ActivateOptions();

                return appender;
            }
            if (appendType == AppenderType.ConsoleAppender)
            {
                var appender = new ConsoleAppender
                {
                    Threshold = Level.Debug,
                    Layout = layout
                };
                appender.ActivateOptions();

                return appender;
            }
            return null;
        }
    }
    public enum AppenderType
    {
        ConsoleAppender = 0,
        FileAppender = 1,
    }
}
