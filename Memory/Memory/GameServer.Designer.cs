namespace Memory
{
    partial class GameServer
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
            this.HostButton = new System.Windows.Forms.Button();
            this.ClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // HostButton
            // 
            this.HostButton.Location = new System.Drawing.Point(26, 67);
            this.HostButton.Name = "HostButton";
            this.HostButton.Size = new System.Drawing.Size(75, 23);
            this.HostButton.TabIndex = 1;
            this.HostButton.Text = "Host";
            this.HostButton.UseVisualStyleBackColor = true;
            // 
            // ClientButton
            // 
            this.ClientButton.Location = new System.Drawing.Point(107, 67);
            this.ClientButton.Name = "ClientButton";
            this.ClientButton.Size = new System.Drawing.Size(75, 23);
            this.ClientButton.TabIndex = 2;
            this.ClientButton.Text = "Client";
            this.ClientButton.UseVisualStyleBackColor = true;
            // 
            // GameServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 593);
            this.Controls.Add(this.ClientButton);
            this.Controls.Add(this.HostButton);
            this.Controls.Add(this.label1);
            this.Name = "GameServer";
            this.Text = "GameServer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HostButton;
        private System.Windows.Forms.Button ClientButton;
    }
}