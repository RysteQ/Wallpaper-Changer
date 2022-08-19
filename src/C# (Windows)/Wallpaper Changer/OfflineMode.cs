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
    public bool IsAllowed()
    {
        return allowedToStart;
    }

    public void start()
    {
        init();

        if (allowedToStart == false)
            return;

        looping = true;

        new Thread(() =>
        {
            while (looping)
            {
                for (int i = 0; i < wallpapersPath.Length; i++)
                {
                    SystemParametersInfo(0x14, 0, wallpapersPath[i], 0x01 | 0x02);
                    Thread.Sleep(wallpaperChangeInterval * 1000 * 60);
                }
            }
        }).Start();
    }

    public void stop()
    {
        looping = false;
    }

    private void init()
    {
        allowedToStart = true;
        
        if (Directory.Exists(wallpaperDirectory))
            wallpapersPath = Directory.GetFiles(wallpaperDirectory);
        else
            allowedToStart = false;
    }

    private string wallpaperDirectory;
    private string[] wallpapersPath;
    private int wallpaperChangeInterval;
    private bool looping = false;
    private bool allowedToStart = false;
}