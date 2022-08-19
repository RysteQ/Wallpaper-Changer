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
        OnlineMode onlineMode = new OnlineMode();

        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (modeSelectionListbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a mode from the panel to the right", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (running)
                StopWallpaperChanger(onlineMode, offlineMode);
            
            running = true;

            if (modeSelectionListbox.SelectedIndex == 0)
            {
                offlineMode.SetInterval(wallpaperChangeIntervalMinutes);
                offlineMode.SetDirectory(wallpaperDirectory);
                offlineMode.start();
            } else
            {
                // TODO
            }

            startButton.Text = "Stop";
        }

        private void StopWallpaperChanger(OnlineMode onlineModeObject, OfflineMode offlineModeObject)
        {
            if (onlineOrOffline)
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
        }

        private void setOnlineModeButton_Click(object sender, EventArgs e)
        {
            deviantartProfileUrl = onlineModeDirectoryLabel.Text;
        }

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            FD.SelectedPath = "Pictures";

            if (FD.ShowDialog() == DialogResult.OK)
                offlineModeDirectoryTextbox.Text = FD.SelectedPath;
        }
    }
}