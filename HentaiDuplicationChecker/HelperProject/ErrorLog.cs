using System;
using NLog;

namespace HelperProject
{
    public class ErrorLog
    {
        private static Logger _exceptionLogger = LogManager.GetLogger("ExceptionLog");

        public static void LogError(Exception ex)
        {
            MappedDiagnosticsContext.Set("date", DateTime.Now.ToString());
            MappedDiagnosticsContext.Set("exception", ex.ToString());

            _exceptionLogger.Error("");
        }
    }
}
