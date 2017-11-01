﻿namespace Memory
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
            this.RunningInThe90sButton = new System.Windows.Forms.Button();
            this.Volume = new System.Windows.Forms.PictureBox();
            this.Themas = new System.Windows.Forms.PictureBox();
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
            this.ThemaBox.Location = new System.Drawing.Point(581, 414);
            this.ThemaBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThemaBox.Name = "ThemaBox";
            this.ThemaBox.Size = new System.Drawing.Size(160, 24);
            this.ThemaBox.TabIndex = 0;
            this.ThemaBox.SelectedIndexChanged += new System.EventHandler(this.ThemaBox_SelectedIndexChanged);
            // 
            // Apply
            // 
            this.Apply.BackColor = System.Drawing.Color.DimGray;
            this.Apply.BackgroundImage = global::Memory.Properties.Resources.toepassen;
            this.Apply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Apply.Font = new System.Drawing.Font("Arial", 13F);
            this.Apply.Location = new System.Drawing.Point(539, 571);
            this.Apply.Margin = new System.Windows.Forms.Padding(4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(241, 78);
            this.Apply.TabIndex = 4;
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // VolumeUp
            // 
            this.VolumeUp.BackColor = System.Drawing.Color.Transparent;
            this.VolumeUp.BackgroundImage = global::Memory.Properties.Resources.SpeakerButton;
            this.VolumeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeUp.Location = new System.Drawing.Point(832, 196);
            this.VolumeUp.Margin = new System.Windows.Forms.Padding(4);
            this.VolumeUp.Name = "VolumeUp";
            this.VolumeUp.Size = new System.Drawing.Size(117, 108);
            this.VolumeUp.TabIndex = 5;
            this.VolumeUp.TabStop = false;
            this.VolumeUp.Click += new System.EventHandler(this.VolumeUp_Click);
            // 
            // VolumeDown
            // 
            this.VolumeDown.BackColor = System.Drawing.Color.Transparent;
            this.VolumeDown.BackgroundImage = global::Memory.Properties.Resources.VolumeDownButton;
            this.VolumeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VolumeDown.Location = new System.Drawing.Point(707, 196);
            this.VolumeDown.Margin = new System.Windows.Forms.Padding(4);
            this.VolumeDown.Name = "VolumeDown";
            this.VolumeDown.Size = new System.Drawing.Size(117, 108);
            this.VolumeDown.TabIndex = 7;
            this.VolumeDown.TabStop = false;
            this.VolumeDown.Click += new System.EventHandler(this.VolumeDown_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.BackColor = System.Drawing.Color.Transparent;
            this.MuteButton.BackgroundImage = global::Memory.Properties.Resources.MuteButton;
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteButton.Location = new System.Drawing.Point(581, 196);
            this.MuteButton.Margin = new System.Windows.Forms.Padding(4);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(117, 108);
            this.MuteButton.TabIndex = 8;
            this.MuteButton.TabStop = false;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = global::Memory.Properties.Resources.Settings;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(479, 23);
            this.Settings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(477, 129);
            this.Settings.TabIndex = 11;
            this.Settings.TabStop = false;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = global::Memory.Properties.Resources.HomeButton;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Location = new System.Drawing.Point(1317, 630);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(100, 100);
            this.Home.TabIndex = 10;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ServerDebug
            // 
            this.ServerDebug.Location = new System.Drawing.Point(68, 599);
            this.ServerDebug.Margin = new System.Windows.Forms.Padding(4);
            this.ServerDebug.Name = "ServerDebug";
            this.ServerDebug.Size = new System.Drawing.Size(100, 28);
            this.ServerDebug.TabIndex = 12;
            this.ServerDebug.Text = "ServerDebug";
            this.ServerDebug.UseVisualStyleBackColor = true;
            this.ServerDebug.Click += new System.EventHandler(this.ServerDebug_Click);
            // 
            // RunningInThe90sButton
            // 
            this.RunningInThe90sButton.Location = new System.Drawing.Point(611, 441);
            this.RunningInThe90sButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunningInThe90sButton.Name = "RunningInThe90sButton";
            this.RunningInThe90sButton.Size = new System.Drawing.Size(75, 23);
            this.RunningInThe90sButton.TabIndex = 13;
            this.RunningInThe90sButton.Text = "Running";
            this.RunningInThe90sButton.UseVisualStyleBackColor = true;
            this.RunningInThe90sButton.Click += new System.EventHandler(this.RunningInThe90sButton_Click);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.BackgroundImage = global::Memory.Properties.Resources.coollogo_com_52152217;
            this.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Volume.Location = new System.Drawing.Point(91, 196);
            this.Volume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(453, 108);
            this.Volume.TabIndex = 13;
            this.Volume.TabStop = false;
            // 
            // Themas
            // 
            this.Themas.BackColor = System.Drawing.Color.Transparent;
            this.Themas.BackgroundImage = global::Memory.Properties.Resources.Thema_s;
            this.Themas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Themas.Location = new System.Drawing.Point(91, 350);
            this.Themas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Themas.Name = "Themas";
            this.Themas.Size = new System.Drawing.Size(463, 89);
            this.Themas.TabIndex = 14;
            this.Themas.TabStop = false;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.background_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 730);
            this.Controls.Add(this.RunningInThe90sButton);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button RunningInThe90sButton;
        private System.Windows.Forms.PictureBox Volume;
        private System.Windows.Forms.PictureBox Themas;
    }
}