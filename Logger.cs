using System;
using System.IO;
using System.Threading.Tasks;

namespace Mahle
{
    public class Logger
    {
        StreamWriter logger;
        readonly string path;
        readonly string fileName;

        public Logger(string path) // Creates a text file with name of start date and time
        {
            this.path = path;
            fileName = path + "/" + DateTime.Now.ToString().Replace(':', '.') + ".txt";
            logger = new StreamWriter(fileName);
            logger.WriteLine(DateTime.Now + " -> " + "Uygulama başlatıldı.");            
        }

        public void WriteLog(string message)    // Writes given message to log files with date and time
        {
            logger.WriteLine(DateTime.Now + " -> " + message);
        }

        public void StopLogger()    // Writes closing date and time. Closes the application logger
        {
            logger.WriteLine(DateTime.Now + " -> " + "Uygulama kapatıldı.");
            logger.Close();
        }
    }
}
