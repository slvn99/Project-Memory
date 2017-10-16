namespace Memory
{
    partial class Form2
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
            this.Play = new System.Windows.Forms.PictureBox();
            this.Highscore = new System.Windows.Forms.PictureBox();
            this.Settings = new System.Windows.Forms.PictureBox();
            this.Load = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.PictureBox();
            this.Fullscreen = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.Memory = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Highscore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fullscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = global::Memory.Properties.Resources.PlayButton;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Play.Location = new System.Drawing.Point(608, 191);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(214, 216);
            this.Play.TabIndex = 8;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Highscore
            // 
            this.Highscore.BackColor = System.Drawing.Color.Transparent;
            this.Highscore.BackgroundImage = global::Memory.Properties.Resources.RankingButton;
            this.Highscore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Highscore.Location = new System.Drawing.Point(100, 471);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(226, 214);
            this.Highscore.TabIndex = 7;
            this.Highscore.TabStop = false;
            this.Highscore.Click += new System.EventHandler(this.Highscore_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BackgroundImage = global::Memory.Properties.Resources.SettingsButton;
            this.Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Settings.Location = new System.Drawing.Point(1049, 471);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(226, 214);
            this.Settings.TabIndex = 6;
            this.Settings.TabStop = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.Transparent;
            this.Load.BackgroundImage = global::Memory.Properties.Resources.SaveButton;
            this.Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Load.Location = new System.Drawing.Point(608, 471);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(214, 214);
            this.Load.TabIndex = 5;
            this.Load.TabStop = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.BackgroundImage = global::Memory.Properties.Resources.Naamloos_1;
            this.bar.Location = new System.Drawing.Point(-1, -1);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(1367, 34);
            this.bar.TabIndex = 3;
            this.bar.TabStop = false;
            this.bar.Click += new System.EventHandler(this.bar_Click);
            // 
            // Fullscreen
            // 
            this.Fullscreen.BackColor = System.Drawing.Color.Transparent;
            this.Fullscreen.BackgroundImage = global::Memory.Properties.Resources.maximize_window1600_2;
            this.Fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Fullscreen.Location = new System.Drawing.Point(1292, -1);
            this.Fullscreen.Name = "Fullscreen";
            this.Fullscreen.Size = new System.Drawing.Size(38, 33);
            this.Fullscreen.TabIndex = 2;
            this.Fullscreen.TabStop = false;
            this.Fullscreen.Click += new System.EventHandler(this.Fullscreen_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BackgroundImage = global::Memory.Properties.Resources.ExitButton;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit.Location = new System.Drawing.Point(1336, -1);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(30, 33);
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Memory
            // 
            this.Memory.BackColor = System.Drawing.Color.Transparent;
            this.Memory.BackgroundImage = global::Memory.Properties.Resources.coollogo_com_11864820;
            this.Memory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Memory.Location = new System.Drawing.Point(486, 27);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(464, 158);
            this.Memory.TabIndex = 1;
            this.Memory.TabStop = false;
            // 
            // cat
            // 
            this.cat.BackColor = System.Drawing.Color.Transparent;
            this.cat.Image = global::Memory.Properties.Resources.Nice;
            this.cat.Location = new System.Drawing.Point(-1, -2);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(1367, 699);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 0;
            this.cat.TabStop = false;
            this.cat.Click += new System.EventHandler(this.cat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 697);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.Fullscreen);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.cat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Highscore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fullscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox Memory;
        private System.Windows.Forms.PictureBox Fullscreen;
        private System.Windows.Forms.PictureBox bar;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Load;
        private System.Windows.Forms.PictureBox Settings;
        private System.Windows.Forms.PictureBox Highscore;
        private System.Windows.Forms.PictureBox Play;
    }
}