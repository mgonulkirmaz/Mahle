using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public MainScreen()
        {
            InitializeComponent();
        }

        Timer updateTimer = new Timer();    //Calls update function every 1 sec (Updates Date and Time)
        Point panelLocation = new Point(0, 100);    //For indicator location
        Point defUserControlLocation = new Point(200, 25); //For default user control location

        private void buttonExit_Click(object sender, EventArgs e)
        {
            refreshSelectPanel(buttonExit.Location.Y);
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            setLocationsForUserControls();
            updateTimer.Interval = 1000;
            updateTimer.Tick += new EventHandler(update);
            updateTimer.Start();
            refreshSelectPanel(buttonMainScreen.Location.Y);
        }

        private void update(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void setLocationsForUserControls()
        {

        }

        private void refreshSelectPanel(int y_axis) //Updates selected menu indicator location
        {
            panelLocation.Y = y_axis;
            panelSelected.Location = panelLocation;
        }

        private void buttonMainScreen_Click(object sender, EventArgs e)
        {
            refreshSelectPanel(buttonMainScreen.Location.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshSelectPanel(buttonSettings.Location.Y);
        }
    }
}
