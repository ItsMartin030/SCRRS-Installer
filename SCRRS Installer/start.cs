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
        const string version = "0.0.3";


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

            #region Initalize Buttons and Versions INI
            var VersionsINI = new IniFile(Application.StartupPath + "/btn.ini");

            var webRequest = WebRequest.Create(@"https://raw.githubusercontent.com/saugstauberr/SCRRS-Installer/master/versions/versions.ini");

            using (var response = webRequest.GetResponse())
            using (var content = response.GetResponseStream())
            using (var reader = new StreamReader(content))
            {
                var strContent = reader.ReadToEnd();
                File.WriteAllText("btn.ini", strContent);
            }

            if (VersionsINI.Read("name", "Button0") != "hide")
            {
                button0.ButtonText = VersionsINI.Read("name", "Button0");
            } else
            {
                button0.Visible = false;
            }

            if (VersionsINI.Read("name", "Button1") != "hide")
            {
                button1.ButtonText = VersionsINI.Read("name", "Button1");
            }
            else
            {
                button1.Visible = false;
            }

            if (VersionsINI.Read("name", "Button2") != "hide")
            {
                button2.ButtonText = VersionsINI.Read("name", "Button2");
            }
            else
            {
                button2.Visible = false;
            }

            if (VersionsINI.Read("name", "Button3") != "hide")
            {
                button3.ButtonText = VersionsINI.Read("name", "Button3");
            }
            else
            {
                button3.Visible = false;
            }

            if (VersionsINI.Read("name", "Button4") != "hide")
            {
                button4.ButtonText = VersionsINI.Read("name", "Button4");
            }
            else
            {
                button4.Visible = false;
            }

            if (VersionsINI.Read("name", "Button5") != "hide")
            {
                button5.ButtonText = VersionsINI.Read("name", "Button5");
            }
            else
            {
                button5.Visible = false;
            }

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

        public void runVersionAdds(int version)
        {
            var VersionsINI = new IniFile(Application.StartupPath + "/btn.ini");
            switch (VersionsINI.Read("adds", "Button" + version))
            {
                case "ac":
                    renameDefault();
                    break;

                default:
                    undoDefault();
                    break;
            }
        }

        public void renameDefault()
        {
            try
            {
                Directory.Move(teamspeakurl + "default", teamspeakurl + "default_renamed");
            } catch (Exception ex)
            {
                
            }
        }
        public void undoDefault()
        {
            try
            {
                Directory.Move(teamspeakurl + "default_renamed", teamspeakurl + "default");
            }
            catch (Exception ex)
            {
                
            }
        }

        //Gets the selected version URL
        public string getVersionURL(int version)
        {
            var VersionsINI = new IniFile(Application.StartupPath + "/btn.ini");
            switch (version)
            {
                case 0:
                    return VersionsINI.Read("url", "Button0");

                case 1:
                    return VersionsINI.Read("url", "Button1");

                case 2:
                    return VersionsINI.Read("url", "Button2");

                case 3:
                    return VersionsINI.Read("url", "Button3");

                case 4:
                    return VersionsINI.Read("url", "Button4");

                case 5:
                    return VersionsINI.Read("url", "Button5");

                default:
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
        private void button0_Click(object sender, EventArgs e)
        {
            selectedversion = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedversion = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedversion = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedversion = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            selectedversion = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selectedversion = 5;
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
            runVersionAdds(selectedversion);
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
                    button0.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    button0.IdleFillColor = Color.FromArgb(10, 110, 242);
                    button1.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button1.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button2.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button2.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button3.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button3.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button4.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button4.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button5.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button5.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
                case 1:
                    button0.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button0.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button1.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    button1.IdleFillColor = Color.FromArgb(10, 110, 242);
                    button2.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button2.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button3.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button3.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button4.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button4.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button5.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button5.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
                case 2:
                    button0.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button0.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button1.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button1.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button2.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    button2.IdleFillColor = Color.FromArgb(10, 110, 242);
                    button3.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button3.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button4.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button4.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button5.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button5.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
                case 3:
                    button0.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button0.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button1.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button1.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button2.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button2.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button3.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    button3.IdleFillColor = Color.FromArgb(10, 110, 242);
                    button4.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button4.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button5.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button5.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
                case 4:
                    button0.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button0.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button1.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button1.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button2.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button2.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button3.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button3.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button4.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    button4.IdleFillColor = Color.FromArgb(10, 110, 242);
                    button5.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button5.IdleFillColor = Color.FromArgb(16, 17, 20);
                    break;
                case 5:
                    button0.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button0.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button1.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button1.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button2.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button2.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button3.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button3.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button4.ActiveFillColor = Color.FromArgb(16, 17, 20);
                    button4.IdleFillColor = Color.FromArgb(16, 17, 20);
                    button5.ActiveFillColor = Color.FromArgb(10, 110, 242);
                    button5.IdleFillColor = Color.FromArgb(10, 110, 242);
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
