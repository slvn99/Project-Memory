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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.MuteButton = new System.Windows.Forms.Button();
			this.SpeakerButton = new System.Windows.Forms.Button();
			this.ThemaBox = new System.Windows.Forms.ComboBox();
			this.HomeButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Arial", 40F);
			this.label1.Location = new System.Drawing.Point(462, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 61);
			this.label1.TabIndex = 0;
			this.label1.Text = "Settings";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Arial", 20F);
			this.label2.Location = new System.Drawing.Point(261, 168);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Music";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Arial", 20F);
			this.label3.Location = new System.Drawing.Point(261, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thema\'s";
			// 
			// MuteButton
			// 
			this.MuteButton.BackColor = System.Drawing.Color.Transparent;
			this.MuteButton.BackgroundImage = global::Memory.Properties.Resources.MuteButton;
			this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.MuteButton.ForeColor = System.Drawing.Color.Transparent;
			this.MuteButton.Location = new System.Drawing.Point(468, 157);
			this.MuteButton.Name = "MuteButton";
			this.MuteButton.Size = new System.Drawing.Size(75, 65);
			this.MuteButton.TabIndex = 4;
			this.MuteButton.UseVisualStyleBackColor = false;
			this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
			// 
			// SpeakerButton
			// 
			this.SpeakerButton.BackColor = System.Drawing.Color.Transparent;
			this.SpeakerButton.BackgroundImage = global::Memory.Properties.Resources.SpeakerButton;
			this.SpeakerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SpeakerButton.Location = new System.Drawing.Point(540, 157);
			this.SpeakerButton.Name = "SpeakerButton";
			this.SpeakerButton.Size = new System.Drawing.Size(72, 65);
			this.SpeakerButton.TabIndex = 5;
			this.SpeakerButton.UseVisualStyleBackColor = false;
			this.SpeakerButton.Click += new System.EventHandler(this.SpeakerButton_Click);
			// 
			// ThemaBox
			// 
			this.ThemaBox.FormattingEnabled = true;
			this.ThemaBox.Items.AddRange(new object[] {
            "Thema 1",
            "Thema 2",
            "Thema 3"});
			this.ThemaBox.Location = new System.Drawing.Point(468, 265);
			this.ThemaBox.Name = "ThemaBox";
			this.ThemaBox.Size = new System.Drawing.Size(121, 21);
			this.ThemaBox.TabIndex = 6;
			this.ThemaBox.SelectedIndexChanged += new System.EventHandler(this.ThemaBox_SelectedIndexChanged);
			// 
			// HomeButton
			// 
			this.HomeButton.BackColor = System.Drawing.Color.Transparent;
			this.HomeButton.BackgroundImage = global::Memory.Properties.Resources.HomeButton;
			this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.HomeButton.Location = new System.Drawing.Point(975, 506);
			this.HomeButton.Name = "HomeButton";
			this.HomeButton.Size = new System.Drawing.Size(88, 88);
			this.HomeButton.TabIndex = 7;
			this.HomeButton.UseVisualStyleBackColor = false;
			this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
			// 
			// SettingsPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Memory.Properties.Resources.background_game;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1063, 593);
			this.Controls.Add(this.HomeButton);
			this.Controls.Add(this.ThemaBox);
			this.Controls.Add(this.SpeakerButton);
			this.Controls.Add(this.MuteButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SettingsPage";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsPage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button MuteButton;
		private System.Windows.Forms.Button SpeakerButton;
		private System.Windows.Forms.ComboBox ThemaBox;
		private System.Windows.Forms.Button HomeButton;
	}
}