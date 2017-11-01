namespace Memory
{
	partial class SettingsPage
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.ThemaBox = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.VolumeUp = new System.Windows.Forms.PictureBox();
            this.VolumeDown = new System.Windows.Forms.PictureBox();
            this.MuteButton = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            this.ServerDebug = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.PictureBox();
            this.Themas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Themas)).BeginInit();
            this.SuspendLayout();
            // 
            // ThemaBox
            // 
            this.ThemaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemaBox.Items.AddRange(new object[] {
            "Media",
            "Films",
            "Games"});
            this.ThemaBox.Location = new System.Drawing.Point(436, 336);
            this.ThemaBox.Name = "ThemaBox";
            this.ThemaBox.Size = new System.Drawing.Size(121, 21);
            this.ThemaBox.TabIndex = 0;
            this.ThemaBox.SelectedIndexChanged += new System.EventHandler(this.ThemaBox_SelectedIndexChanged);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.DimGray;
            this.Apply.BackgroundImage = global::Memory.Properties.Resources.toepassen;
            this.Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Apply.Font = new System.Drawing.Font("Arial", 13F);
            this.Apply.Location = new System.Drawing.Point(404, 464);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(181, 63);
            this.Apply.TabIndex = 4;
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // VolumeUp
            // 
            this.VolumeUp.BackColor = System.Drawing.Color.Transparent;
            this.VolumeUp.BackgroundImage = global::Memory.Properties.Resources.SpeakerButton;
            this.VolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeUp.Location = new System.Drawing.Point(624, 159);
            this.VolumeUp.Name = "VolumeUp";
            this.VolumeUp.Size = new System.Drawing.Size(88, 88);
            this.VolumeUp.TabIndex = 5;
            this.VolumeUp.TabStop = false;
            this.VolumeUp.Click += new System.EventHandler(this.VolumeUp_Click);
            // 
            // VolumeDown
            // 
            this.VolumeDown.BackColor = System.Drawing.Color.Transparent;
            this.VolumeDown.BackgroundImage = global::Memory.Properties.Resources.VolumeDownButton;
            this.VolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeDown.Location = new System.Drawing.Point(530, 159);
            this.VolumeDown.Name = "VolumeDown";
            this.VolumeDown.Size = new System.Drawing.Size(88, 88);
            this.VolumeDown.TabIndex = 7;
            this.VolumeDown.TabStop = false;
            this.VolumeDown.Click += new System.EventHandler(this.VolumeDown_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.BackColor = System.Drawing.Color.Transparent;
            this.MuteButton.BackgroundImage = global::Memory.Properties.Resources.MuteButton;
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteButton.Location = new System.Drawing.Point(436, 159);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(88, 88);
            this.MuteButton.TabIndex = 8;
            this.MuteButton.TabStop = false;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = global::Memory.Properties.Resources.Settings;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(359, 19);
            this.Settings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(358, 105);
            this.Settings.TabIndex = 11;
            this.Settings.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = global::Memory.Properties.Resources.HomeButton;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Location = new System.Drawing.Point(988, 512);
            this.Home.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(75, 81);
            this.Home.TabIndex = 10;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ServerDebug
            // 
            this.ServerDebug.Location = new System.Drawing.Point(51, 487);
            this.ServerDebug.Name = "ServerDebug";
            this.ServerDebug.Size = new System.Drawing.Size(75, 23);
            this.ServerDebug.TabIndex = 12;
            this.ServerDebug.Text = "ServerDebug";
            this.ServerDebug.UseVisualStyleBackColor = true;
            this.ServerDebug.Click += new System.EventHandler(this.ServerDebug_Click);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.BackgroundImage = global::Memory.Properties.Resources.coollogo_com_52152217;
            this.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Volume.Location = new System.Drawing.Point(68, 159);
            this.Volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(340, 88);
            this.Volume.TabIndex = 13;
            this.Volume.TabStop = false;
            // 
            // Themas
            // 
            this.Themas.BackColor = System.Drawing.Color.Transparent;
            this.Themas.BackgroundImage = global::Memory.Properties.Resources.Thema_s;
            this.Themas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Themas.Location = new System.Drawing.Point(68, 284);
            this.Themas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Themas.Name = "Themas";
            this.Themas.Size = new System.Drawing.Size(347, 72);
            this.Themas.TabIndex = 14;
            this.Themas.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1168, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.background_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 593);
            this.Controls.Add(this.Themas);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.ServerDebug);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.VolumeDown);
            this.Controls.Add(this.VolumeUp);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.ThemaBox);
            this.Name = "SettingsPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Themas)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox ThemaBox;
		private System.Windows.Forms.Button Apply;
		private System.Windows.Forms.PictureBox VolumeUp;
		private System.Windows.Forms.PictureBox VolumeDown;
		private System.Windows.Forms.PictureBox MuteButton;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.PictureBox Home;
        private System.Windows.Forms.Button ServerDebug;
        private System.Windows.Forms.PictureBox Volume;
        private System.Windows.Forms.PictureBox Themas;
        private System.Windows.Forms.Button button1;
    }
}