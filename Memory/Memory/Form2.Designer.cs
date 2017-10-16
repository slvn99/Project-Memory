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
            this.SuspendLayout();
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form2";
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
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}