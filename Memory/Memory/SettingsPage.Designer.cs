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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
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
			this.label3.Font = new System.Drawing.Font("Arial", 20F);
			this.label3.Location = new System.Drawing.Point(261, 265);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(117, 32);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thema\'s";
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::Memory.Properties.Resources.MuteButton;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(468, 157);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 65);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::Memory.Properties.Resources.SpeakerButton;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(540, 157);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 65);
			this.button2.TabIndex = 5;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Thema 1",
            "Thema 2",
            "Thema 3"});
			this.comboBox1.Location = new System.Drawing.Point(468, 265);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 6;
			// 
			// SettingsPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Memory.Properties.Resources.background_game;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1063, 593);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "SettingsPage";
			this.ShowInTaskbar = false;
			this.Text = "SettingsPage";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}