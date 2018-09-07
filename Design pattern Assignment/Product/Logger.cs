using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    sealed class Logger:ILogger
    {
        private static Logger singleInstance = null;
        private static readonly object lockObject = new object();
       
        public static Logger SingleInstance
        {
            get
            {
                if (singleInstance == null)
                {
                    lock (lockObject)
                    {
                        if (singleInstance == null)
                        {
                            singleInstance = new Logger();
                        }

                    }
                }
                return singleInstance;
            }
        }
        public void LogMessage(string message)
        {
            File.AppendAllText("C:/Users/udhawan/Desktop/logFile.txt", message +  DateTime.Now.ToLongDateString() +DateTime.Now.ToLongTimeString() + Environment.NewLine);
        }
    }
}
