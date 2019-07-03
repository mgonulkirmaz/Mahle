using System;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Mahle
{
    public class Core
    {
        private static FileSystemWatcher systemWatcher = new FileSystemWatcher();
        public static bool RunState = false;

        public static void Start()
        {           
            systemWatcher.Path = SettingsHandler.settings.InputFolder;
            systemWatcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            systemWatcher.Created += OnChange;
            systemWatcher.Renamed += OnChange;
        }

        private static async void OnChange(object sender, EventArgs e)
        {
            await Process();
        }

        private static async Task Process()
        {
            string[] files = Directory.GetFiles(SettingsHandler.settings.InputFolder);

            foreach(string file in files)
            {
                Logger.WriteLog("Yeni dosya bulundu.  (" + file + ")");

                try
                {
                    string temp = file.Replace(SettingsHandler.settings.InputFolder, SettingsHandler.settings.OriginalFilesFolder);
                    string targetDest = file.Replace(SettingsHandler.settings.InputFolder, SettingsHandler.settings.OutputFolder);
                    File.Copy(file, temp);
                    Logger.WriteLog("Orjinal dosya kopyalandı.");
                    temp = File.ReadAllText(file,Encoding.Default);

                    string[] realValues = SettingsHandler.GetRealValues();
                    string[] targetValues = SettingsHandler.GetTargetValues();

                    int i = 0;

                    foreach (string str in realValues)
                    {
                        temp = temp.Replace(str, targetValues[i]);
                        i++;
                    }

                    using (StreamWriter sw = new StreamWriter(targetDest,true,Encoding.Default))
                    {
                        sw.WriteLine(temp);
                        Logger.WriteLog("Değerler değiştirildi ve yeni dosya oluşturuldu.");
                    }

                    File.Delete(file);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public static void ProcessStart()
        {
            RunState = true;
            Logger.WriteLog("Çalışma başlatıldı.");
            systemWatcher.EnableRaisingEvents = true;
        }

        public static void Stop()
        {
            RunState = false;
            Logger.WriteLog("Çalışma durduruldu.");
            systemWatcher.EnableRaisingEvents = false;

        }
    }
}
