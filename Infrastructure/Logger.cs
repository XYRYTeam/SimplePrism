using log4net;
using System;
using System.IO;
using System.Reflection;

namespace Infrastructure
{
    public class Logger
    {
        private ILog logger;

        public static Logger Default { get; private set; }

        static Logger()
        {
            //log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            Default = new Logger(LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType));
        }

        /// <summary>
        /// 指定名称初始化Logger
        /// </summary>
        /// <param name="name">The name.</param>
        public Logger(string name) : this(LogManager.GetLogger(name))
        {
        }

        private Logger(ILog logger)
        {
            this.logger = logger;
        }

        public static Logger GetLogger(Type type)
        {
            return new Logger(LogManager.GetLogger(type));
        }

        public void Debug(Exception ex, string msg = "")
        {
            logger.Debug(msg, ex);
        }

        public void Debug(string msg, params object[] args)
        {
            logger.DebugFormat(msg, args);
        }

        public void Info(Exception ex, string msg = "")
        {
            logger.Info(msg, ex);
        }

        public void Info(string msg, params object[] args)
        {
            logger.InfoFormat(msg, args);
        }

        public void Warn(Exception ex, string msg = "")
        {
            logger.Warn(msg, ex);
        }

        public void Warn(string msg, params object[] args)
        {
            logger.WarnFormat(msg, args);
        }

        public void Error(Exception ex, string msg = "")
        {
            logger.Error(msg, ex);
        }

        public void Error(string msg, params object[] args)
        {
            logger.ErrorFormat(msg, args);
        }

        public void Fatal(Exception ex, string msg = "")
        {
            logger.Fatal(msg, ex);
        }

        public void Fatal(string msg, params object[] args)
        {
            logger.FatalFormat(msg, args);
        }

        public void Flush(int timeoutMilliseconds)
        {
            LogManager.Flush(timeoutMilliseconds);
        }
    }
}