using System.Runtime.InteropServices;

public sealed class OfflineMode
{
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    static extern int SystemParametersInfo(int action, int parameter, string vParameter, int window);

    public void SetInterval(int wallpaperChangeInterval)
    {
        this.wallpaperChangeInterval = wallpaperChangeInterval;
    }

    public void SetDirectory(string wallpaperDirectory)
    {
        this.wallpaperDirectory = wallpaperDirectory;
    }

    public bool isAllowed()
    {
        return allowedToStart;
    }

    public void start()
    {
        init();

        if (allowedToStart == false)
            return;

        executing = true;

        wallpaperChangingThread = new Thread(() =>
        {
            while (executing)
            {
                for (int i = 0; i < wallpapersPath.Length; i++)
                {
                    SystemParametersInfo(0x14, 0, wallpapersPath[i], 0x01 | 0x02);
                    Thread.Sleep(wallpaperChangeInterval * 1000 * 60);
                }
            }
        });

        wallpaperChangingThread.Start();
    }

    public void stop()
    {
        executing = false;
    }

    private void init()
    {
        allowedToStart = true;

        if (Directory.Exists(wallpaperDirectory))
            wallpapersPath = Directory.EnumerateFiles(wallpaperDirectory, "*.png", SearchOption.TopDirectoryOnly).ToArray();
        else
            allowedToStart = false;

        if (wallpapersPath.Length == 0)
            allowedToStart = false;
    }

    private string wallpaperDirectory;
    private string[] wallpapersPath;
    private int wallpaperChangeInterval;
    private bool allowedToStart = false;
    private bool executing = false;

    Thread wallpaperChangingThread;
}