using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCRRS_Installer.Functions;

namespace SCRRS_Installer
{
    public partial class start : Form
    {
        //Programm Version
        const string version = "0.0.1";


        #region Variables
        public int selectedversion = 0;
        public string teamspeakurl = "None";

        #endregion

        public start()
        {
            InitializeComponent();
            versiontxt.Text = version;
            #region Initalize INI
            var SettingsINI = new IniFile(Application.StartupPath + "/data/settings.ini");

            if (SettingsINI.Read("teamspeakurl", "Settings") == "") {
                SettingsINI.Write("teamspeakurl", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/AppData/Roaming/TS3Client/plugins/SaltyChat/", "Settings");
            };

            teamspeakurl = SettingsINI.Read("teamspeakurl", "settings");
            #endregion
        }

        #region Draggable Window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void start_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //Gets the selected version URL
        public string getVersionURL(int version)
        {
            switch (version)
            {
                case 0:
                    //Normal Version with White Noise
                    return Application.StartupPath + "/data/scrrs_normalnoise.zip";

                case 1:
                    //Normal Version without White Noise
                    return Application.StartupPath + "";

                default:
                    return Application.StartupPath + "/data/scrrs_normalnoise.zip";
            }
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            installation.RunWorkerAsync();
        }

        private void updateui_Tick(object sender, EventArgs e)
        {
            switch (selectedversion)
            {
                case 0:
                    versionstd.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    versionstd.IdleFillColor = Color.FromArgb(10, 110, 242);
                    versionstd_nonoise.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    versionstd_nonoise.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
                case 1:
                    versionstd_nonoise.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    versionstd_nonoise.IdleFillColor = Color.FromArgb(10, 110, 242);
                    versionstd.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    versionstd.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
            }

            folderpath.Text = teamspeakurl;
        }

        private void versionstd_Click(object sender, EventArgs e)
        {
            selectedversion = 0;
        }

        private void versionstd_nonoise_Click(object sender, EventArgs e)
        {
            selectedversion = 1;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void installation_DoWork(object sender, DoWorkEventArgs e)
        {
            File.Delete(teamspeakurl + "scrrs.zip");
            File.Copy(getVersionURL(selectedversion), teamspeakurl + "scrrs.zip");

            using (ZipFile zip = ZipFile.Read(teamspeakurl + "scrrs.zip"))
            {
                zip.ExtractAll(teamspeakurl);
            }
            File.Delete(teamspeakurl + "scrrs.zip");
            MessageBox.Show("Installation erfolgreich abgeschlossen!");
        }

        private void folderpath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var SettingsINI = new IniFile(Application.StartupPath + "/data/settings.ini");
                    SettingsINI.Write("teamspeakurl", fbd.SelectedPath + "/plugins/SaltyChat/", "Settings");
                    teamspeakurl = SettingsINI.Read("teamspeakurl", "Settings");
                    MessageBox.Show("Dateipfad wurde erfolgreich gesetzt!");
                }
            }
        }

        private void standardfolderbtn_Click(object sender, EventArgs e)
        {
            var SettingsINI = new IniFile(Application.StartupPath + "/data/settings.ini");
            SettingsINI.Write("teamspeakurl", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/AppData/Roaming/TS3Client/plugins/SaltyChat/", "Settings");
            teamspeakurl = SettingsINI.Read("teamspeakurl", "Settings");
            MessageBox.Show("Der Dateipfad wurde erfolgreich zurückgesetzt!");
        }

        private void uninstallbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(teamspeakurl + "override", true);
                MessageBox.Show("Deinstallation erfolgreich!");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("SCRRS ist nicht installiert!");
            }


        }
    }
}
