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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.ThemaBox = new System.Windows.Forms.ComboBox();
			this.HomeButton = new System.Windows.Forms.Button();
			this.Apply = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
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
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::Memory.Properties.Resources.SpeakerButton;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(508, 159);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 75);
			this.button1.TabIndex = 2;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.BackgroundImage = global::Memory.Properties.Resources.MuteButton;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(436, 159);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 75);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			// 
			// ThemaBox
			// 
			this.ThemaBox.Items.AddRange(new object[] {
            "Thema 1",
            "Thema 2",
            "Thema 3"});
			this.ThemaBox.Location = new System.Drawing.Point(436, 265);
			this.ThemaBox.Name = "ThemaBox";
			this.ThemaBox.Size = new System.Drawing.Size(121, 21);
			this.ThemaBox.TabIndex = 0;
			// 
			// HomeButton
			// 
			this.HomeButton.BackColor = System.Drawing.Color.Transparent;
			this.HomeButton.BackgroundImage = global::Memory.Properties.Resources.HomeButton;
			this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.HomeButton.Location = new System.Drawing.Point(976, 505);
			this.HomeButton.Name = "HomeButton";
			this.HomeButton.Size = new System.Drawing.Size(88, 88);
			this.HomeButton.TabIndex = 3;
			this.HomeButton.UseVisualStyleBackColor = false;
			this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
			// 
			// Apply
			// 
			this.Apply.Font = new System.Drawing.Font("Arial", 13F);
			this.Apply.Location = new System.Drawing.Point(447, 467);
			this.Apply.Name = "Apply";
			this.Apply.Size = new System.Drawing.Size(81, 32);
			this.Apply.TabIndex = 4;
			this.Apply.Text = "Apply";
			this.Apply.UseVisualStyleBackColor = true;
			this.Apply.Click += new System.EventHandler(this.Apply_Click);
			// 
			// SettingsPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Memory.Properties.Resources.background_game;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1063, 593);
			this.Controls.Add(this.Apply);
			this.Controls.Add(this.HomeButton);
			this.Controls.Add(this.ThemaBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SettingsPage";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsPage";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsPage_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox ThemaBox;
		private System.Windows.Forms.Button HomeButton;
		private System.Windows.Forms.Button Apply;
	}
}