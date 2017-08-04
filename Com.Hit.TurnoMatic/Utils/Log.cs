using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Hit.TurnoMatic.Utils
{
    public class Log
    {

        private static LogEntry GetLogEntry()
        {
            LogEntry log = new LogEntry();
            log.TimeStamp = DateTime.Now;
            log.Title = "General";
            log.Priority = 5; // default priority
            log.Severity = System.Diagnostics.TraceEventType.Verbose;  // default severity
            log.MachineName = "LocalHost";
            log.ProcessId = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
            return log;
        }
        //
        public static void LogError(String ClassName, String MethodName, Exception ex)
        {
            LogWriterFactory logWriterFactory = new LogWriterFactory();
            Logger.SetLogWriter(logWriterFactory.Create());

            if (Logger.IsLoggingEnabled())
            {
                try
                {
                    LogEntry log = GetLogEntry();
                    log.Categories.Add("General");
                    log.Priority = 9;
                    log.Severity = System.Diagnostics.TraceEventType.Error;
                    log.Message = String.Format("Class Name: {0} , Methodo Name: {1} ,Message: {2}", ClassName, MethodName, ex.Message);
                    log.ExtendedProperties.Add("Stack Trace", ex.StackTrace);
                    log.ExtendedProperties.Add("Target Site", ex.TargetSite);
                    Logger.Write(log);
                }
                catch { }
            }
        }

    }
}
