using System.Reflection;

namespace Wallpaper_Changer
{
    public partial class MainForm : Form
    {
        private int wallpaperChangeIntervalMinutes = 1;
        private string wallpaperDirectory = null;
        private string deviantartProfileUrl = null;
        private bool running = false;
        private bool onlineOrOffline = false;

        OfflineMode offlineMode = new OfflineMode();

        public MainForm()
        {
            InitializeComponent();
            CheckDefaultFolder();
        }

        private void CheckDefaultFolder()
        {
            if (Properties.Settings.Default.DefaultFolder != "{EMPTY}")
            {
                offlineModeDirectoryTextbox.Text = Properties.Settings.Default.DefaultFolder;
                setOfflineModeButton_Click(null, null);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (running)
            {
                StopWallpaperChanger(offlineMode);
                return;
            }

            offlineMode.SetInterval(wallpaperChangeIntervalMinutes);
            offlineMode.SetDirectory(wallpaperDirectory);
            offlineMode.start();

            startButton.Text = "Stop";
            running = true;
        }

        private void StopWallpaperChanger(OfflineMode offlineModeObject)
        {
            offlineModeObject.stop();

            startButton.Text = "Start";
            running = false;
        }

        private void increaseWallpaperIntervalButton_Click(object sender, EventArgs e)
        {
            if (wallpaperChangeIntervalMinutes < 60)
            {
                wallpaperChangeIntervalMinutes++;
                wallpaperIntervalLabel.Text = wallpaperChangeIntervalMinutes.ToString();
            } else
            {
                MessageBox.Show("Cannot increase the value further", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void decreaseWallpaperIntervalButton_Click(object sender, EventArgs e)
        {
            if (wallpaperChangeIntervalMinutes > 1)
            {
                wallpaperChangeIntervalMinutes--;
                wallpaperIntervalLabel.Text = wallpaperChangeIntervalMinutes.ToString();
            }
            else
            {
                MessageBox.Show("Cannot decrease the value further", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setOfflineModeButton_Click(object sender, EventArgs e)
        {
            wallpaperDirectory = offlineModeDirectoryTextbox.Text;
            Properties.Settings.Default.DefaultFolder = wallpaperDirectory;
            Properties.Settings.Default.Save();
        }

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            FD.SelectedPath = "Pictures";

            if (FD.ShowDialog() == DialogResult.OK)
                offlineModeDirectoryTextbox.Text = FD.SelectedPath;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon.Visible = true;
            Hide();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Environment.Exit(0);
        }
    }
}