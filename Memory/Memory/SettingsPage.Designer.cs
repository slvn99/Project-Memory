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
            this.Homepicture = new System.Windows.Forms.PictureBox();
            this.Volume = new System.Windows.Forms.PictureBox();
            this.MuteVolume = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Homepicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // Homepicture
            // 
            this.Homepicture.BackColor = System.Drawing.Color.Transparent;
            this.Homepicture.BackgroundImage = global::Memory.Properties.Resources.HomeButton;
            this.Homepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Homepicture.Location = new System.Drawing.Point(1315, 630);
            this.Homepicture.Name = "Homepicture";
            this.Homepicture.Size = new System.Drawing.Size(100, 100);
            this.Homepicture.TabIndex = 5;
            this.Homepicture.TabStop = false;
            this.Homepicture.Click += new System.EventHandler(this.Homepicture_Click);
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.Transparent;
            this.Volume.BackgroundImage = global::Memory.Properties.Resources.SpeakerButton;
            this.Volume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Volume.Location = new System.Drawing.Point(687, 188);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(100, 100);
            this.Volume.TabIndex = 6;
            this.Volume.TabStop = false;
            // 
            // MuteVolume
            // 
            this.MuteVolume.BackColor = System.Drawing.Color.Transparent;
            this.MuteVolume.BackgroundImage = global::Memory.Properties.Resources.MuteButton;
            this.MuteVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MuteVolume.Location = new System.Drawing.Point(581, 188);
            this.MuteVolume.Name = "MuteVolume";
            this.MuteVolume.Size = new System.Drawing.Size(100, 100);
            this.MuteVolume.TabIndex = 7;
            this.MuteVolume.TabStop = false;
            this.MuteVolume.Click += new System.EventHandler(this.MuteVolume_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Memory.Properties.Resources.Settings;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(479, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 129);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Memory.Properties.Resources.background_game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1417, 730);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MuteVolume);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Homepicture);
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
            ((System.ComponentModel.ISupportInitialize)(this.Homepicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MuteVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ThemaBox;
		private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.PictureBox Homepicture;
        private System.Windows.Forms.PictureBox Volume;
        private System.Windows.Forms.PictureBox MuteVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}