using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mahle
{
    public partial class SettingsScreen : UserControl
    {
        private FolderBrowserDialog chooseFolder = new FolderBrowserDialog();

        public SettingsScreen()
        {
            InitializeComponent();
        }

        public void RefreshValues()
        {
            comboRealValue.Items.Clear();
            listBox.Items.Clear();
            string[] str = SettingsHandler.GetRealValues();
            string[] str2 = SettingsHandler.GetTargetValues();

            int i = 0;

            foreach (string s in str)
            {
                comboRealValue.Items.Add(s);
                listBox.Items.Add(s + "\t|  " + str2[i]);
                i++;
            }

            if (comboRealValue.Items.Count != 0)
            {
                comboRealValue.SelectedIndex = 0;
            }

        }

        private void BtnChangeInput_Click(object sender, System.EventArgs e)
        {
            string newInput;

            DialogResult dResult = chooseFolder.ShowDialog();

            if (dResult == DialogResult.OK && !string.IsNullOrWhiteSpace(chooseFolder.SelectedPath))
            {
                newInput = chooseFolder.SelectedPath;
                SettingsHandler.settings.InputFolder = newInput;
                SettingsHandler.SaveSettings();
                SettingsHandler.RefreshSettings();
                Logger.WriteLog("Giriş klasörü değiştirildi.   (" + newInput + ")");
                SettingsHandler.RefreshValues();
            }
        }

        private void BtnChangeOutput_Click(object sender, System.EventArgs e)
        {
            string newOutput;

            DialogResult dResult = chooseFolder.ShowDialog();

            if (dResult == DialogResult.OK && !string.IsNullOrWhiteSpace(chooseFolder.SelectedPath))
            {
                newOutput = chooseFolder.SelectedPath;
                SettingsHandler.settings.OutputFolder = newOutput;
                SettingsHandler.SaveSettings();
                SettingsHandler.RefreshSettings();
                Logger.WriteLog("Çıkış klasörü değiştirildi.   (" + newOutput + ")");
                SettingsHandler.RefreshValues();
            }
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if(txtRealValue.Text != "" && txtTargetValue.Text != "" && txtRealValue != null && txtTargetValue != null 
                && !txtRealValue.Text.Contains(",") && !txtTargetValue.Text.Contains(",") && SettingsHandler.values.RealValues != "" && SettingsHandler.values.TargetValues != "")
            {
                SettingsHandler.values.RealValues += "," + txtRealValue.Text;
                SettingsHandler.values.TargetValues += "," + txtTargetValue.Text;
                SettingsHandler.SaveValues();
                Logger.WriteLog("Yeni değer başarıyla eklendi.   (" + txtRealValue.Text + "\t| " + txtTargetValue.Text + ")");
                SettingsHandler.RefreshValues();
                RefreshValues();
                txtRealValue.Text = "";
                txtTargetValue.Text = "";                
                MessageBox.Show("Değer ekleme başarılı.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if(txtRealValue.Text != "" && txtTargetValue.Text != "" && txtRealValue != null && txtTargetValue != null
                && !txtRealValue.Text.Contains(",") && !txtTargetValue.Text.Contains(",") && SettingsHandler.values.RealValues == "" && SettingsHandler.values.TargetValues == "")
            {
                SettingsHandler.values.RealValues += txtRealValue.Text;
                SettingsHandler.values.TargetValues += txtTargetValue.Text;
                SettingsHandler.SaveValues();
                Logger.WriteLog("Yeni değer başarıyla eklendi.   (" + txtRealValue.Text + "\t| " + txtTargetValue.Text + ")");
                SettingsHandler.RefreshValues();
                RefreshValues();
                txtRealValue.Text = "";
                txtTargetValue.Text = "";
                MessageBox.Show("Değer ekleme başarılı.", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void BtnDelete_Click(object sender, System.EventArgs e)
        {
            string deleteValue = comboRealValue.SelectedItem.ToString();
            string[] realValues = SettingsHandler.GetRealValues();
            string[] targetValues = SettingsHandler.GetTargetValues();             

            if(realValues.Length == 1 && realValues[0] == "~HATA")
            {
                Logger.WriteLog("Değer verisi bulunamadı.");
            }
            else if(realValues.Length > 1)
            {
                int i = 0;

                for (i = 0; i < realValues.Length; i++)
                {
                    if (realValues[i] == deleteValue)
                    {
                        break;
                    }
                }

                Logger.WriteLog("Bir değer silindi.   (" + realValues[i] + "\t" + targetValues[i] + ")");

                SettingsHandler.values.RealValues = SettingsHandler.values.RealValues.Replace(realValues[i] + ",", "");
                SettingsHandler.values.RealValues = SettingsHandler.values.RealValues.Replace("," + realValues[i], "");
                SettingsHandler.values.TargetValues = SettingsHandler.values.TargetValues.Replace(targetValues[i] + ",", "");
                SettingsHandler.values.TargetValues = SettingsHandler.values.TargetValues.Replace("," + targetValues[i], "");
                SettingsHandler.SaveValues();

            }
            else if(realValues.Length <= 0 || realValues == null)
            {
                Logger.WriteLog("Değer verisi bulunamadı.");
            }
            else
            {
                Logger.WriteLog("Bir değer silindi.   (" + realValues[0] + "\t" + targetValues[0] + ")");

                SettingsHandler.values.RealValues = SettingsHandler.values.RealValues.Replace(realValues[0], "");
                SettingsHandler.values.TargetValues = SettingsHandler.values.TargetValues.Replace(targetValues[0], "");
                SettingsHandler.SaveValues();

            }
            
            SettingsHandler.RefreshValues();
            RefreshValues();

        }

        private void ListBox_DoubleClick(object sender, System.EventArgs e)
        {
            comboRealValue.SelectedIndex = listBox.SelectedIndex;
        }
    }
}
