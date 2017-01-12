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
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            AppLogManager.ConfigureAppender("Logs/log.txt", AppenderType.FileAppender);
            AppLogManager.ConfigureAppender("Logs/log.txt", AppenderType.ConsoleAppender);
            ShowLines("Info message");
            Console.ReadLine();
        }
        static void ShowLines(string msg)
        {
            log.Debug(msg);
        }
    }
}
