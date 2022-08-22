namespace Wallpaper_Changer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.offlineModeDirectoryLabel = new System.Windows.Forms.Label();
            this.offlineModeDirectoryTextbox = new System.Windows.Forms.TextBox();
            this.setOfflineModeButton = new System.Windows.Forms.Button();
            this.decreaseWallpaperIntervalButton = new System.Windows.Forms.Button();
            this.increaseWallpaperIntervalButton = new System.Windows.Forms.Button();
            this.wallpaperIntervalLabel = new System.Windows.Forms.Label();
            this.autoStartupOnBootRadiobox = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.folderBrowserButton = new System.Windows.Forms.Button();
            this.FD = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // offlineModeDirectoryLabel
            // 
            this.offlineModeDirectoryLabel.AutoSize = true;
            this.offlineModeDirectoryLabel.Location = new System.Drawing.Point(12, 15);
            this.offlineModeDirectoryLabel.Name = "offlineModeDirectoryLabel";
            this.offlineModeDirectoryLabel.Size = new System.Drawing.Size(111, 15);
            this.offlineModeDirectoryLabel.TabIndex = 0;
            this.offlineModeDirectoryLabel.Text = "Wallpaper Directory";
            // 
            // offlineModeDirectoryTextbox
            // 
            this.offlineModeDirectoryTextbox.Location = new System.Drawing.Point(182, 12);
            this.offlineModeDirectoryTextbox.Name = "offlineModeDirectoryTextbox";
            this.offlineModeDirectoryTextbox.Size = new System.Drawing.Size(163, 23);
            this.offlineModeDirectoryTextbox.TabIndex = 2;
            // 
            // setOfflineModeButton
            // 
            this.setOfflineModeButton.Location = new System.Drawing.Point(351, 12);
            this.setOfflineModeButton.Name = "setOfflineModeButton";
            this.setOfflineModeButton.Size = new System.Drawing.Size(89, 23);
            this.setOfflineModeButton.TabIndex = 3;
            this.setOfflineModeButton.Text = "Set";
            this.setOfflineModeButton.UseVisualStyleBackColor = true;
            this.setOfflineModeButton.Click += new System.EventHandler(this.setOfflineModeButton_Click);
            // 
            // decreaseWallpaperIntervalButton
            // 
            this.decreaseWallpaperIntervalButton.Location = new System.Drawing.Point(446, 12);
            this.decreaseWallpaperIntervalButton.Name = "decreaseWallpaperIntervalButton";
            this.decreaseWallpaperIntervalButton.Size = new System.Drawing.Size(75, 22);
            this.decreaseWallpaperIntervalButton.TabIndex = 6;
            this.decreaseWallpaperIntervalButton.Text = "-1 minute";
            this.decreaseWallpaperIntervalButton.UseVisualStyleBackColor = true;
            this.decreaseWallpaperIntervalButton.Click += new System.EventHandler(this.decreaseWallpaperIntervalButton_Click);
            // 
            // increaseWallpaperIntervalButton
            // 
            this.increaseWallpaperIntervalButton.Location = new System.Drawing.Point(554, 11);
            this.increaseWallpaperIntervalButton.Name = "increaseWallpaperIntervalButton";
            this.increaseWallpaperIntervalButton.Size = new System.Drawing.Size(75, 23);
            this.increaseWallpaperIntervalButton.TabIndex = 7;
            this.increaseWallpaperIntervalButton.Text = "+1 minute";
            this.increaseWallpaperIntervalButton.UseVisualStyleBackColor = true;
            this.increaseWallpaperIntervalButton.Click += new System.EventHandler(this.increaseWallpaperIntervalButton_Click);
            // 
            // wallpaperIntervalLabel
            // 
            this.wallpaperIntervalLabel.AutoSize = true;
            this.wallpaperIntervalLabel.Location = new System.Drawing.Point(531, 15);
            this.wallpaperIntervalLabel.Name = "wallpaperIntervalLabel";
            this.wallpaperIntervalLabel.Size = new System.Drawing.Size(13, 15);
            this.wallpaperIntervalLabel.TabIndex = 8;
            this.wallpaperIntervalLabel.Text = "1";
            // 
            // autoStartupOnBootRadiobox
            // 
            this.autoStartupOnBootRadiobox.AutoSize = true;
            this.autoStartupOnBootRadiobox.Location = new System.Drawing.Point(635, 14);
            this.autoStartupOnBootRadiobox.Name = "autoStartupOnBootRadiobox";
            this.autoStartupOnBootRadiobox.Size = new System.Drawing.Size(108, 19);
            this.autoStartupOnBootRadiobox.TabIndex = 9;
            this.autoStartupOnBootRadiobox.TabStop = true;
            this.autoStartupOnBootRadiobox.Text = "Startup on boot";
            this.autoStartupOnBootRadiobox.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(749, 10);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // folderBrowserButton
            // 
            this.folderBrowserButton.Location = new System.Drawing.Point(144, 11);
            this.folderBrowserButton.Name = "folderBrowserButton";
            this.folderBrowserButton.Size = new System.Drawing.Size(32, 24);
            this.folderBrowserButton.TabIndex = 12;
            this.folderBrowserButton.Text = "...";
            this.folderBrowserButton.UseVisualStyleBackColor = true;
            this.folderBrowserButton.Click += new System.EventHandler(this.folderBrowserButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 44);
            this.Controls.Add(this.folderBrowserButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.autoStartupOnBootRadiobox);
            this.Controls.Add(this.wallpaperIntervalLabel);
            this.Controls.Add(this.increaseWallpaperIntervalButton);
            this.Controls.Add(this.decreaseWallpaperIntervalButton);
            this.Controls.Add(this.setOfflineModeButton);
            this.Controls.Add(this.offlineModeDirectoryTextbox);
            this.Controls.Add(this.offlineModeDirectoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Wallpaper Changer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label offlineModeDirectoryLabel;
        private TextBox offlineModeDirectoryTextbox;
        private Button setOfflineModeButton;
        private Button decreaseWallpaperIntervalButton;
        private Button increaseWallpaperIntervalButton;
        private Label wallpaperIntervalLabel;
        private RadioButton autoStartupOnBootRadiobox;
        private Button startButton;
        private Button folderBrowserButton;
        private FolderBrowserDialog FD;
    }
}