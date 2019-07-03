namespace Mahle
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonMainScreen = new System.Windows.Forms.Button();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.settingsScreen = new Mahle.SettingsScreen();
            this.leftPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.leftPanel.Controls.Add(this.buttonSettings);
            this.leftPanel.Controls.Add(this.buttonMainScreen);
            this.leftPanel.Controls.Add(this.panelSelected);
            this.leftPanel.Controls.Add(this.buttonExit);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.ForeColor = System.Drawing.Color.White;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(200, 640);
            this.leftPanel.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSettings.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonSettings.Location = new System.Drawing.Point(5, 200);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(195, 60);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Ayarlar";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonMainScreen
            // 
            this.buttonMainScreen.FlatAppearance.BorderSize = 0;
            this.buttonMainScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMainScreen.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMainScreen.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonMainScreen.Location = new System.Drawing.Point(5, 100);
            this.buttonMainScreen.Name = "buttonMainScreen";
            this.buttonMainScreen.Size = new System.Drawing.Size(195, 60);
            this.buttonMainScreen.TabIndex = 3;
            this.buttonMainScreen.Text = "Anasayfa";
            this.buttonMainScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMainScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMainScreen.UseVisualStyleBackColor = true;
            this.buttonMainScreen.Click += new System.EventHandler(this.ButtonMainScreen_Click);
            // 
            // panelSelected
            // 
            this.panelSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSelected.Location = new System.Drawing.Point(3, 3);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(5, 60);
            this.panelSelected.TabIndex = 2;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonExit.ForeColor = System.Drawing.Color.MistyRose;
            this.buttonExit.Location = new System.Drawing.Point(5, 480);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(195, 60);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Çıkış";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.topPanel.Controls.Add(this.labelTime);
            this.topPanel.Controls.Add(this.labelDate);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.Color.White;
            this.topPanel.Location = new System.Drawing.Point(200, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(824, 24);
            this.topPanel.TabIndex = 1;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTime.Location = new System.Drawing.Point(777, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(44, 18);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "21:55";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDate.Location = new System.Drawing.Point(685, 3);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(86, 18);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "18/11/2018";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(500, 100);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 39);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Location = new System.Drawing.Point(624, 100);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 39);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(248, 165);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(728, 445);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // settingsScreen
            // 
            this.settingsScreen.Location = new System.Drawing.Point(200, 620);
            this.settingsScreen.Margin = new System.Windows.Forms.Padding(4);
            this.settingsScreen.Name = "settingsScreen";
            this.settingsScreen.Size = new System.Drawing.Size(22, 20);
            this.settingsScreen.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.settingsScreen);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "--";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.Button buttonMainScreen;
        private System.Windows.Forms.Button buttonSettings;
        private SettingsScreen settingsScreen;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.RichTextBox txtLog;
    }
}

