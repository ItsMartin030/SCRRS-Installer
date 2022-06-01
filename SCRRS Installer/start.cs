using Ionic.Zip;
using SCRRS_Installer.Functions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SCRRS_Installer
{
    public partial class start : Form
    {
        //Programm Version
        const string version = "0.0.2";


        #region Variables
        public int selectedversion = 0;
        public string teamspeakurl = "None";

        #endregion

        public start()
        {
            InitializeComponent();
            versiontxt.Text = version;

            #region Initalize INI

            //Checks if INI File exists, if not it creates it and adds standard path
            if (File.Exists(Application.StartupPath + "/settings.ini") == false)
            {
                File.Create(Application.StartupPath + "/settings.ini");
                ToggleButtons(false);
                MessageBox.Show("Settings-Datei erstellt. Starte das Programm erneut!");
                this.Close();
            }

            //Checks TS3Client folder in the INI file
            var SettingsINI = new IniFile(Application.StartupPath + "/settings.ini");
            if (SettingsINI.Read("teamspeakurl", "Settings") == "")
            {
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


        #region Functions
        //Gets the selected version URL
        public string getVersionURL(int version)
        {
            switch (version)
            {
                case 0:
                    //Normal Version with White Noise
                    // OLD: return Application.StartupPath + "/data/scrrs_normalnoise.zip";
                    return "https://github.com/saugstauberr/SCRRS-Installer/raw/master/versions/scrrs_normalnoise.zip";

                case 1:
                    //Normal Version without White Noise
                    // OLD: return Application.StartupPath + "";
                    return "https://github.com/saugstauberr/SCRRS-Installer/raw/master/versions/scrrs_normalnonoise.zip";

                default:
                    // OLD: return Application.StartupPath + "/data/scrrs_normalnoise.zip";
                    return "https://github.com/saugstauberr/SCRRS-Installer/raw/master/versions/scrrs_normalnoise.zip";
            }
        }


        //Toggle visibility for buttons
        private void ToggleButtons(bool visibility)
        {
            switch (visibility)
            {
                case true:
                    installbtn.Visible = true;
                    uninstallbtn.Visible = true;
                    break;

                case false:
                    installbtn.Visible = false;
                    uninstallbtn.Visible = false;
                    break;
            }
        }
        #endregion


        #region Buttons
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

        private void standardfolderbtn_Click(object sender, EventArgs e)
        {
            var SettingsINI = new IniFile(Application.StartupPath + "/settings.ini");
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
        #endregion

        #region Downloader + Install Button
        private void installbtn_Click(object sender, EventArgs e)
        {
            ToggleButtons(false);
            updateui.Stop();
            File.Delete(teamspeakurl + "scrrs.zip");

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
                webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
                webClient.DownloadFileAsync(new Uri(getVersionURL(selectedversion)), teamspeakurl + "scrrs.zip");
            }
            downloadprogressbar.Visible = true;
        }

        private void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadprogressbar.Value = e.ProgressPercentage;
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            downloadprogressbar.Value = 0;

            if (e.Cancelled)
            {
                MessageBox.Show("Ein Fehler ist aufgetreten!");
                ToggleButtons(true);
                downloadprogressbar.Visible = false;
                updateui.Start();
                return;
            }

            if (e.Error != null) // We have an error! Retry a few times, then abort.
            {
                MessageBox.Show("Ein Fehler ist aufgetreten!");
                ToggleButtons(true);
                downloadprogressbar.Visible = false;
                updateui.Start();
                return;
            }

            if (Directory.Exists(teamspeakurl + "override"))
            {
                Directory.Delete(teamspeakurl + "override", true);
            }

            using (ZipFile zip = ZipFile.Read(teamspeakurl + "scrrs.zip"))
            {
                zip.ExtractAll(teamspeakurl);
            }
            File.Delete(teamspeakurl + "scrrs.zip");
            ToggleButtons(true);
            downloadprogressbar.Visible = false;
            MessageBox.Show("Installation erfolgreich abgeschlossen!");
            updateui.Start();
        }


        private void folderpath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var SettingsINI = new IniFile(Application.StartupPath + "/settings.ini");
                    SettingsINI.Write("teamspeakurl", fbd.SelectedPath + "/plugins/SaltyChat/", "Settings");
                    teamspeakurl = SettingsINI.Read("teamspeakurl", "Settings");
                    MessageBox.Show("Dateipfad wurde erfolgreich gesetzt!");
                }
            }
        }
        #endregion

        #region Timer
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

            if (teamspeakurl == "")
            {
                ToggleButtons(false);
            }
            else
            {
                ToggleButtons(true);
            }
            #endregion
        }
    }
}
