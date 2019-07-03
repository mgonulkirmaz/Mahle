namespace Mahle
{
    partial class SettingsScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeInput = new System.Windows.Forms.Button();
            this.btnChangeOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRealValue = new System.Windows.Forms.TextBox();
            this.txtTargetValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboRealValue = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(179, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Klasörü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(454, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çıkış Klasörü";
            // 
            // btnChangeInput
            // 
            this.btnChangeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeInput.Location = new System.Drawing.Point(281, 64);
            this.btnChangeInput.Name = "btnChangeInput";
            this.btnChangeInput.Size = new System.Drawing.Size(96, 30);
            this.btnChangeInput.TabIndex = 2;
            this.btnChangeInput.Text = "DEĞİŞTİR";
            this.btnChangeInput.UseVisualStyleBackColor = true;
            this.btnChangeInput.Click += new System.EventHandler(this.BtnChangeInput_Click);
            // 
            // btnChangeOutput
            // 
            this.btnChangeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangeOutput.Location = new System.Drawing.Point(558, 64);
            this.btnChangeOutput.Name = "btnChangeOutput";
            this.btnChangeOutput.Size = new System.Drawing.Size(96, 30);
            this.btnChangeOutput.TabIndex = 3;
            this.btnChangeOutput.Text = "DEĞİŞTİR";
            this.btnChangeOutput.UseVisualStyleBackColor = true;
            this.btnChangeOutput.Click += new System.EventHandler(this.BtnChangeOutput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(408, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hedef Değer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(211, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gerçek Değer";
            // 
            // txtRealValue
            // 
            this.txtRealValue.Location = new System.Drawing.Point(182, 141);
            this.txtRealValue.Name = "txtRealValue";
            this.txtRealValue.Size = new System.Drawing.Size(162, 20);
            this.txtRealValue.TabIndex = 6;
            // 
            // txtTargetValue
            // 
            this.txtTargetValue.Location = new System.Drawing.Point(374, 141);
            this.txtTargetValue.Name = "txtTargetValue";
            this.txtTargetValue.Size = new System.Drawing.Size(162, 20);
            this.txtTargetValue.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(558, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(213, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gerçek Değer";
            // 
            // comboRealValue
            // 
            this.comboRealValue.FormattingEnabled = true;
            this.comboRealValue.Location = new System.Drawing.Point(182, 212);
            this.comboRealValue.Name = "comboRealValue";
            this.comboRealValue.Size = new System.Drawing.Size(166, 21);
            this.comboRealValue.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(374, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "SİL";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(182, 259);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(472, 290);
            this.listBox.TabIndex = 12;
            this.listBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // SettingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboRealValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTargetValue);
            this.Controls.Add(this.txtRealValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChangeOutput);
            this.Controls.Add(this.btnChangeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SettingsScreen";
            this.Size = new System.Drawing.Size(824, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChangeInput;
        private System.Windows.Forms.Button btnChangeOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRealValue;
        private System.Windows.Forms.TextBox txtTargetValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboRealValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBox;
    }
}
