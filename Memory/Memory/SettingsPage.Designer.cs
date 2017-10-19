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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemaBox = new System.Windows.Forms.ComboBox();
            this.Apply = new System.Windows.Forms.Button();
            this.VolumeUp = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VolumeDown = new System.Windows.Forms.PictureBox();
            this.MuteButton = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 20F);
            this.label2.Location = new System.Drawing.Point(348, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Music";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 20F);
            this.label3.Location = new System.Drawing.Point(348, 326);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thema\'s";
            // 
            // ThemaBox
            // 
            this.ThemaBox.Items.AddRange(new object[] {
            "Thema 1",
            "Thema 2",
            "Thema 3"});
            this.ThemaBox.Location = new System.Drawing.Point(581, 326);
            this.ThemaBox.Margin = new System.Windows.Forms.Padding(4);
            this.ThemaBox.Name = "ThemaBox";
            this.ThemaBox.Size = new System.Drawing.Size(160, 24);
            this.ThemaBox.TabIndex = 0;
            // 
            // Apply
            // 
            this.Apply.Font = new System.Drawing.Font("Arial", 13F);
            this.Apply.Location = new System.Drawing.Point(596, 575);
            this.Apply.Margin = new System.Windows.Forms.Padding(4);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(108, 39);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Apply";
            this.Apply.UseVisualStyleBackColor = true;
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
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-31, -57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 62);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
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
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Transparent;
            this.Home.BackgroundImage = global::Memory.Properties.Resources.HomeButton;
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Location = new System.Drawing.Point(1318, 630);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(100, 100);
            this.Home.TabIndex = 10;
            this.Home.TabStop = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.background_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 730);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.VolumeDown);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.VolumeUp);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.ThemaBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsPage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsPage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsPage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.VolumeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Home)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ThemaBox;
		private System.Windows.Forms.Button Apply;
		private System.Windows.Forms.PictureBox VolumeUp;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox VolumeDown;
		private System.Windows.Forms.PictureBox MuteButton;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.PictureBox Home;
    }
}