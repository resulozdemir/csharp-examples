using System;

namespace arayüzler
{
    class program
    {
       static void Main(string[] args)
       {
        FileLogger fileLogger = new FileLogger();
        fileLogger.writeLog();

        DatabaseLogger databaseLogger = new DatabaseLogger();
        databaseLogger.writeLog();

        SmsLogger smsLogger = new SmsLogger();
        smsLogger.writeLog();

        LogManager logManager = new LogManager(new FileLogger());
        LogManager.writeLog();
       }

    }
}