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
        }

        private void folderBrowserButton_Click(object sender, EventArgs e)
        {
            FD.SelectedPath = "Pictures";

            if (FD.ShowDialog() == DialogResult.OK)
                offlineModeDirectoryTextbox.Text = FD.SelectedPath;
        }
    }
}