using System;
using System.Collections.Generic;
using BankDataAccess2.DataAccess;

namespace BusinessLayer
{
    public static class LogManager
    {
        public static void AddLog(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                throw new ArgumentException("Log mesajı boş olamaz.");

            LogsDataAccess.InsertLog(message);
        }

        public static List<string> GetAllLogs()
        {
            return LogsDataAccess.GetAllLogs();
        }
    }
}
