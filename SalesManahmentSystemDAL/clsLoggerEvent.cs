using Microsoft.Extensions.Logging.EventLog;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace SalesManahmentSystemBLL.ServicesInterface
{
    public static class clsLoggerEvent
    {
        private static string SourceName = "SMSD";
        static clsLoggerEvent()
        {
            if (OperatingSystem.IsWindows())
            {
                // if exist return false
                if (!EventLog.SourceExists(SourceName))
                {
                    EventLog.CreateEventSource(SourceName, "Application");
                }
            }
        }
        public static void LogEvent(this Exception ex)
        {
            if (OperatingSystem.IsWindows())
            {
                EventLog.WriteEntry(SourceName, HandelMessage(ex));
            }
        }
        private static string HandelMessage(Exception ex)
        {
            return "------Exception Log--------\n" +
                $"Time / Date   : {DateTime.Now}\n" +
                $"Message       : {ex.Message}\n" +
                $"Inner Exeption: {(ex.InnerException != null ? ex.InnerException.Message : "N/A")}\n" +
                $"Stack Trace   : {ex.StackTrace}\n" +
                $"source        : {ex.Source}\n" +
                "-------------------------------";
        }

        public static string ComputeHash(this string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] Hashbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(Hashbytes).Replace("-", "").ToLower();
            }
        }
    }
}
