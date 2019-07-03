using System;
using System.IO;
using System.Threading.Tasks;

namespace Mahle
{
    public class Logger
    {
        private static StreamWriter logger;
        public static string path;
        private static string fileName;

        static Logger() // Creates a text file with name of start date and time
        {
                        
        }

        public static void Start()
        {
            fileName = path + "/" + DateTime.Now.ToString().Replace(':', '.') + ".txt";
            logger = new StreamWriter(fileName);
            logger.WriteLine(DateTime.Now + " -> " + "Uygulama başlatıldı.");
        }

        public static void WriteLog(string message)    // Writes given message to log files with date and time
        {
            logger.WriteLine(DateTime.Now + " -> " + message);
        }

        public static void Stop()    // Writes closing date and time. Closes the application logger
        {
            logger.WriteLine(DateTime.Now + " -> " + "Uygulama kapatıldı.");
            logger.Close();
        }
    }
}
