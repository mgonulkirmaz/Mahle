using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using Newtonsoft.Json;

/*
 * refreshSelectPanel(int)   For update indicator panel location (takes only Y axis)
 * 
 * Default useable screen size (824; 615)
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */

namespace Mahle
{
    public partial class MainScreen : Form
    {
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]

        public MainScreen()
        {
            InitializeComponent();
        }

        SettingsHandler settingsHandler;
        Timer updateTimer = new Timer();    //Calls update function every 1 sec (Updates Date and Time)
        Point panelLocation = new Point(0, 100);    //For indicator location
        Point defUserControlLocation = new Point(200, 25); //For default user control location
        Size defUserControlSize = new Size(824, 615);

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            RefreshSelectPanel(buttonExit.Location.Y);
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            SetLocationsForUserControls();
            updateTimer.Interval = 1000;
            updateTimer.Tick += new EventHandler(UpdateDateTime);
            updateTimer.Start();
            RefreshSelectPanel(buttonMainScreen.Location.Y);
            settingsScreen.Visible = false;
            settingsHandler = new SettingsHandler();
            Logger.WriteLog("Ayarlar yüklendi.");
            RunWriteBox("Ayarlar yüklendi.");
            Core.Start();
        }

        private void UpdateDateTime(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void SetLocationsForUserControls()
        {
            settingsScreen.Location = defUserControlLocation;
            settingsScreen.Size = defUserControlSize;
        }

        private void RefreshSelectPanel(int y_axis) //Updates selected menu indicator location
        {
            panelLocation.Y = y_axis;
            panelSelected.Location = panelLocation;
        }

        private void ButtonMainScreen_Click(object sender, EventArgs e)
        {
            RefreshSelectPanel(buttonMainScreen.Location.Y);
            settingsScreen.Visible = false;
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            RefreshSelectPanel(buttonSettings.Location.Y);
            settingsScreen.Visible = true;
            settingsScreen.BringToFront();
            settingsScreen.RefreshValues();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Logger.Stop();    //Stops logger when program closed
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if(Core.RunState)
            {
                RunWriteBox("\nZaten çalışıyor.");
            }
            else
            {
                SettingsHandler.RefreshSettings();
                SettingsHandler.RefreshValues();
                Core.ProcessStart();
                RunWriteBox("\nÇalışma başlatıldı.");
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if(!Core.RunState)
            {
                RunWriteBox("\nProgram zaten çalışmıyor.");
            }
            else
            {
                Core.Stop();
                RunWriteBox("\nÇalışma durduruldu.");
            }
        }

        private async Task RunWriteBox(string text)
        {
            await WriteLogToBox(text);
        }

        private async Task WriteLogToBox(string text)
        {
            txtLog.Text += text;
        }
    }
}
