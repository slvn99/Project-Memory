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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameServer));
            this.NaamTextBox = new System.Windows.Forms.TextBox();
            this.BeurtLabel = new System.Windows.Forms.Label();
            this.IpTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.PuntenLocal = new System.Windows.Forms.Label();
            this.PuntenOther = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.PictureBox();
            this.bevestig_button = new System.Windows.Forms.PictureBox();
            this.type_uw_naam = new System.Windows.Forms.PictureBox();
            this.client_button = new System.Windows.Forms.PictureBox();
            this.host_button = new System.Windows.Forms.PictureBox();
            this.home_button = new System.Windows.Forms.PictureBox();
            this.GridButton8Dup = new System.Windows.Forms.Button();
            this.GridButton8 = new System.Windows.Forms.Button();
            this.GridButton7Dup = new System.Windows.Forms.Button();
            this.GridButton7 = new System.Windows.Forms.Button();
            this.GridButton6Dup = new System.Windows.Forms.Button();
            this.GridButton6 = new System.Windows.Forms.Button();
            this.GridButton5Dup = new System.Windows.Forms.Button();
            this.GridButton5 = new System.Windows.Forms.Button();
            this.GridButton4Dup = new System.Windows.Forms.Button();
            this.GridButton4 = new System.Windows.Forms.Button();
            this.GridButton3Dup = new System.Windows.Forms.Button();
            this.GridButton3 = new System.Windows.Forms.Button();
            this.GridButton2Dup = new System.Windows.Forms.Button();
            this.GridButton2 = new System.Windows.Forms.Button();
            this.GridButton1Dup = new System.Windows.Forms.Button();
            this.GridButton1 = new System.Windows.Forms.Button();
            this.hostofclient = new System.Windows.Forms.PictureBox();
            this.ip = new System.Windows.Forms.PictureBox();
            this.BeurtBox = new System.Windows.Forms.PictureBox();
            this.Speler1Box = new System.Windows.Forms.PictureBox();
            this.Speler2Box = new System.Windows.Forms.PictureBox();
            this.OtherPlayerLabel = new System.Windows.Forms.Label();
            this.LocalPlayerLabel = new System.Windows.Forms.Label();
            this.ConnectingLabel = new System.Windows.Forms.Label();
            this.Connecting1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.connect_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevestig_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_uw_naam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.host_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostofclient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeurtBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speler1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speler2Box)).BeginInit();
            this.SuspendLayout();
            // 
            // NaamTextBox
            // 
            this.NaamTextBox.Location = new System.Drawing.Point(487, 122);
            this.NaamTextBox.Name = "NaamTextBox";
            this.NaamTextBox.Size = new System.Drawing.Size(100, 20);
            this.NaamTextBox.TabIndex = 4;
            // 
            // BeurtLabel
            // 
            this.BeurtLabel.AutoSize = true;
            this.BeurtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeurtLabel.Location = new System.Drawing.Point(107, 92);
            this.BeurtLabel.Name = "BeurtLabel";
            this.BeurtLabel.Size = new System.Drawing.Size(48, 20);
            this.BeurtLabel.TabIndex = 26;
            this.BeurtLabel.Text = "Beurt";
            // 
            // IpTextBox
            // 
            this.IpTextBox.Location = new System.Drawing.Point(464, 243);
            this.IpTextBox.Name = "IpTextBox";
            this.IpTextBox.Size = new System.Drawing.Size(150, 20);
            this.IpTextBox.TabIndex = 28;
            this.IpTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IpTextBox_KeyPress);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // PuntenLocal
            // 
            this.PuntenLocal.AutoSize = true;
            this.PuntenLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntenLocal.Location = new System.Drawing.Point(195, 12);
            this.PuntenLocal.Name = "PuntenLocal";
            this.PuntenLocal.Size = new System.Drawing.Size(69, 20);
            this.PuntenLocal.TabIndex = 31;
            this.PuntenLocal.Text = "PuntenL";
            // 
            // PuntenOther
            // 
            this.PuntenOther.AutoSize = true;
            this.PuntenOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntenOther.Location = new System.Drawing.Point(195, 47);
            this.PuntenOther.Name = "PuntenOther";
            this.PuntenOther.Size = new System.Drawing.Size(72, 20);
            this.PuntenOther.TabIndex = 32;
            this.PuntenOther.Text = "PuntenO";
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.Transparent;
            this.connect_button.BackgroundImage = global::Memory.Properties.Resources.connect_button;
            this.connect_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connect_button.Location = new System.Drawing.Point(487, 263);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(100, 33);
            this.connect_button.TabIndex = 38;
            this.connect_button.TabStop = false;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // bevestig_button
            // 
            this.bevestig_button.BackColor = System.Drawing.Color.Transparent;
            this.bevestig_button.BackgroundImage = global::Memory.Properties.Resources.bevestig_button;
            this.bevestig_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bevestig_button.Location = new System.Drawing.Point(487, 142);
            this.bevestig_button.Name = "bevestig_button";
            this.bevestig_button.Size = new System.Drawing.Size(100, 32);
            this.bevestig_button.TabIndex = 37;
            this.bevestig_button.TabStop = false;
            this.bevestig_button.Click += new System.EventHandler(this.bevestig_button_Click);
            // 
            // type_uw_naam
            // 
            this.type_uw_naam.BackColor = System.Drawing.Color.Transparent;
            this.type_uw_naam.BackgroundImage = global::Memory.Properties.Resources.type_uw_naam;
            this.type_uw_naam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.type_uw_naam.Location = new System.Drawing.Point(448, 88);
            this.type_uw_naam.Name = "type_uw_naam";
            this.type_uw_naam.Size = new System.Drawing.Size(183, 33);
            this.type_uw_naam.TabIndex = 35;
            this.type_uw_naam.TabStop = false;
            // 
            // client_button
            // 
            this.client_button.BackColor = System.Drawing.Color.Transparent;
            this.client_button.BackgroundImage = global::Memory.Properties.Resources.client_button;
            this.client_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.client_button.Location = new System.Drawing.Point(541, 189);
            this.client_button.Name = "client_button";
            this.client_button.Size = new System.Drawing.Size(90, 33);
            this.client_button.TabIndex = 34;
            this.client_button.TabStop = false;
            this.client_button.Click += new System.EventHandler(this.client_button_Click);
            // 
            // host_button
            // 
            this.host_button.BackColor = System.Drawing.Color.Transparent;
            this.host_button.BackgroundImage = global::Memory.Properties.Resources.host_button;
            this.host_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.host_button.Location = new System.Drawing.Point(449, 189);
            this.host_button.Name = "host_button";
            this.host_button.Size = new System.Drawing.Size(90, 33);
            this.host_button.TabIndex = 33;
            this.host_button.TabStop = false;
            this.host_button.Click += new System.EventHandler(this.host_button_Click);
            // 
            // home_button
            // 
            this.home_button.BackColor = System.Drawing.Color.Transparent;
            this.home_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home_button.Image = global::Memory.Properties.Resources.HomeButton;
            this.home_button.Location = new System.Drawing.Point(951, 481);
            this.home_button.Name = "home_button";
            this.home_button.Size = new System.Drawing.Size(100, 100);
            this.home_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.home_button.TabIndex = 30;
            this.home_button.TabStop = false;
            this.home_button.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GridButton8Dup
            // 
            this.GridButton8Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton8Dup.BackgroundImage")));
            this.GridButton8Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton8Dup.Location = new System.Drawing.Point(676, 420);
            this.GridButton8Dup.Name = "GridButton8Dup";
            this.GridButton8Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton8Dup.TabIndex = 22;
            this.GridButton8Dup.Tag = "8";
            this.GridButton8Dup.UseVisualStyleBackColor = true;
            this.GridButton8Dup.Click += new System.EventHandler(this.GridButton8Dup_Click);
            // 
            // GridButton8
            // 
            this.GridButton8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton8.BackgroundImage")));
            this.GridButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton8.Location = new System.Drawing.Point(540, 420);
            this.GridButton8.Name = "GridButton8";
            this.GridButton8.Size = new System.Drawing.Size(130, 130);
            this.GridButton8.TabIndex = 21;
            this.GridButton8.Tag = "8";
            this.GridButton8.UseVisualStyleBackColor = true;
            this.GridButton8.Click += new System.EventHandler(this.GridButton8_Click);
            // 
            // GridButton7Dup
            // 
            this.GridButton7Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton7Dup.BackgroundImage")));
            this.GridButton7Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton7Dup.Location = new System.Drawing.Point(404, 420);
            this.GridButton7Dup.Name = "GridButton7Dup";
            this.GridButton7Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton7Dup.TabIndex = 20;
            this.GridButton7Dup.Tag = "7";
            this.GridButton7Dup.UseVisualStyleBackColor = true;
            this.GridButton7Dup.Click += new System.EventHandler(this.GridButton7Dup_Click);
            // 
            // GridButton7
            // 
            this.GridButton7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton7.BackgroundImage")));
            this.GridButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton7.Location = new System.Drawing.Point(268, 420);
            this.GridButton7.Name = "GridButton7";
            this.GridButton7.Size = new System.Drawing.Size(130, 130);
            this.GridButton7.TabIndex = 19;
            this.GridButton7.Tag = "7";
            this.GridButton7.UseVisualStyleBackColor = true;
            this.GridButton7.Click += new System.EventHandler(this.GridButton7_Click);
            // 
            // GridButton6Dup
            // 
            this.GridButton6Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton6Dup.BackgroundImage")));
            this.GridButton6Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton6Dup.Location = new System.Drawing.Point(676, 284);
            this.GridButton6Dup.Name = "GridButton6Dup";
            this.GridButton6Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton6Dup.TabIndex = 18;
            this.GridButton6Dup.Tag = "6";
            this.GridButton6Dup.UseVisualStyleBackColor = true;
            this.GridButton6Dup.Click += new System.EventHandler(this.GridButton6Dup_Click);
            // 
            // GridButton6
            // 
            this.GridButton6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton6.BackgroundImage")));
            this.GridButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton6.Location = new System.Drawing.Point(540, 284);
            this.GridButton6.Name = "GridButton6";
            this.GridButton6.Size = new System.Drawing.Size(130, 130);
            this.GridButton6.TabIndex = 17;
            this.GridButton6.Tag = "6";
            this.GridButton6.UseVisualStyleBackColor = true;
            this.GridButton6.Click += new System.EventHandler(this.GridButton6_Click);
            // 
            // GridButton5Dup
            // 
            this.GridButton5Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton5Dup.BackgroundImage")));
            this.GridButton5Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton5Dup.Location = new System.Drawing.Point(404, 284);
            this.GridButton5Dup.Name = "GridButton5Dup";
            this.GridButton5Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton5Dup.TabIndex = 16;
            this.GridButton5Dup.Tag = "5";
            this.GridButton5Dup.UseVisualStyleBackColor = true;
            this.GridButton5Dup.Click += new System.EventHandler(this.GridButton5Dup_Click);
            // 
            // GridButton5
            // 
            this.GridButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton5.BackgroundImage")));
            this.GridButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton5.Location = new System.Drawing.Point(268, 284);
            this.GridButton5.Name = "GridButton5";
            this.GridButton5.Size = new System.Drawing.Size(130, 130);
            this.GridButton5.TabIndex = 15;
            this.GridButton5.Tag = "5";
            this.GridButton5.UseVisualStyleBackColor = true;
            this.GridButton5.Click += new System.EventHandler(this.GridButton5_Click);
            // 
            // GridButton4Dup
            // 
            this.GridButton4Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton4Dup.BackgroundImage")));
            this.GridButton4Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton4Dup.Location = new System.Drawing.Point(676, 148);
            this.GridButton4Dup.Name = "GridButton4Dup";
            this.GridButton4Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton4Dup.TabIndex = 14;
            this.GridButton4Dup.Tag = "4";
            this.GridButton4Dup.UseVisualStyleBackColor = true;
            this.GridButton4Dup.Click += new System.EventHandler(this.GridButton4Dup_Click);
            // 
            // GridButton4
            // 
            this.GridButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton4.BackgroundImage")));
            this.GridButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton4.Location = new System.Drawing.Point(540, 148);
            this.GridButton4.Name = "GridButton4";
            this.GridButton4.Size = new System.Drawing.Size(130, 130);
            this.GridButton4.TabIndex = 13;
            this.GridButton4.Tag = "4";
            this.GridButton4.UseVisualStyleBackColor = true;
            this.GridButton4.Click += new System.EventHandler(this.GridButton4_Click);
            // 
            // GridButton3Dup
            // 
            this.GridButton3Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton3Dup.BackgroundImage")));
            this.GridButton3Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton3Dup.Location = new System.Drawing.Point(404, 148);
            this.GridButton3Dup.Name = "GridButton3Dup";
            this.GridButton3Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton3Dup.TabIndex = 12;
            this.GridButton3Dup.Tag = "3";
            this.GridButton3Dup.UseVisualStyleBackColor = true;
            this.GridButton3Dup.Click += new System.EventHandler(this.GridButton3Dup_Click);
            // 
            // GridButton3
            // 
            this.GridButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton3.BackgroundImage")));
            this.GridButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton3.Location = new System.Drawing.Point(268, 148);
            this.GridButton3.Name = "GridButton3";
            this.GridButton3.Size = new System.Drawing.Size(130, 130);
            this.GridButton3.TabIndex = 11;
            this.GridButton3.Tag = "3";
            this.GridButton3.UseVisualStyleBackColor = true;
            this.GridButton3.Click += new System.EventHandler(this.GridButton3_Click);
            // 
            // GridButton2Dup
            // 
            this.GridButton2Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton2Dup.BackgroundImage")));
            this.GridButton2Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton2Dup.Location = new System.Drawing.Point(676, 12);
            this.GridButton2Dup.Name = "GridButton2Dup";
            this.GridButton2Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton2Dup.TabIndex = 10;
            this.GridButton2Dup.Tag = "2";
            this.GridButton2Dup.UseVisualStyleBackColor = true;
            this.GridButton2Dup.Click += new System.EventHandler(this.GridButton2Dup_Click);
            // 
            // GridButton2
            // 
            this.GridButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton2.BackgroundImage")));
            this.GridButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton2.Location = new System.Drawing.Point(540, 12);
            this.GridButton2.Name = "GridButton2";
            this.GridButton2.Size = new System.Drawing.Size(130, 130);
            this.GridButton2.TabIndex = 9;
            this.GridButton2.Tag = "2";
            this.GridButton2.UseVisualStyleBackColor = true;
            this.GridButton2.Click += new System.EventHandler(this.GridButton2_Click);
            // 
            // GridButton1Dup
            // 
            this.GridButton1Dup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton1Dup.BackgroundImage")));
            this.GridButton1Dup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton1Dup.Location = new System.Drawing.Point(404, 12);
            this.GridButton1Dup.Name = "GridButton1Dup";
            this.GridButton1Dup.Size = new System.Drawing.Size(130, 130);
            this.GridButton1Dup.TabIndex = 8;
            this.GridButton1Dup.Tag = "1";
            this.GridButton1Dup.UseVisualStyleBackColor = true;
            this.GridButton1Dup.Click += new System.EventHandler(this.GridButton1Dup_Click);
            // 
            // GridButton1
            // 
            this.GridButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GridButton1.BackgroundImage")));
            this.GridButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GridButton1.Location = new System.Drawing.Point(268, 12);
            this.GridButton1.Name = "GridButton1";
            this.GridButton1.Size = new System.Drawing.Size(130, 130);
            this.GridButton1.TabIndex = 7;
            this.GridButton1.Tag = "1";
            this.GridButton1.UseVisualStyleBackColor = true;
            this.GridButton1.Click += new System.EventHandler(this.GridButton1_Click);
            // 
            // hostofclient
            // 
            this.hostofclient.BackColor = System.Drawing.Color.Transparent;
            this.hostofclient.BackgroundImage = global::Memory.Properties.Resources.hostofclient;
            this.hostofclient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hostofclient.Location = new System.Drawing.Point(435, 159);
            this.hostofclient.Name = "hostofclient";
            this.hostofclient.Size = new System.Drawing.Size(207, 33);
            this.hostofclient.TabIndex = 40;
            this.hostofclient.TabStop = false;
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.ip.BackgroundImage = global::Memory.Properties.Resources.ip;
            this.ip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ip.Location = new System.Drawing.Point(449, 220);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(182, 27);
            this.ip.TabIndex = 41;
            this.ip.TabStop = false;
            // 
            // BeurtBox
            // 
            this.BeurtBox.BackColor = System.Drawing.Color.Transparent;
            this.BeurtBox.BackgroundImage = global::Memory.Properties.Resources.Beurt1;
            this.BeurtBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BeurtBox.Location = new System.Drawing.Point(11, 81);
            this.BeurtBox.Margin = new System.Windows.Forms.Padding(2);
            this.BeurtBox.Name = "BeurtBox";
            this.BeurtBox.Size = new System.Drawing.Size(91, 40);
            this.BeurtBox.TabIndex = 43;
            this.BeurtBox.TabStop = false;
            this.BeurtBox.Visible = false;
            // 
            // Speler1Box
            // 
            this.Speler1Box.BackColor = System.Drawing.Color.Transparent;
            this.Speler1Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Speler1Box.BackgroundImage")));
            this.Speler1Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Speler1Box.Location = new System.Drawing.Point(11, 9);
            this.Speler1Box.Margin = new System.Windows.Forms.Padding(2);
            this.Speler1Box.Name = "Speler1Box";
            this.Speler1Box.Size = new System.Drawing.Size(75, 29);
            this.Speler1Box.TabIndex = 44;
            this.Speler1Box.TabStop = false;
            this.Speler1Box.Visible = false;
            // 
            // Speler2Box
            // 
            this.Speler2Box.BackColor = System.Drawing.Color.Transparent;
            this.Speler2Box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Speler2Box.BackgroundImage")));
            this.Speler2Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Speler2Box.Location = new System.Drawing.Point(11, 42);
            this.Speler2Box.Margin = new System.Windows.Forms.Padding(2);
            this.Speler2Box.Name = "Speler2Box";
            this.Speler2Box.Size = new System.Drawing.Size(75, 30);
            this.Speler2Box.TabIndex = 45;
            this.Speler2Box.TabStop = false;
            this.Speler2Box.Visible = false;
            // 
            // OtherPlayerLabel
            // 
            this.OtherPlayerLabel.AutoSize = true;
            this.OtherPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherPlayerLabel.Location = new System.Drawing.Point(91, 47);
            this.OtherPlayerLabel.Name = "OtherPlayerLabel";
            this.OtherPlayerLabel.Size = new System.Drawing.Size(92, 20);
            this.OtherPlayerLabel.TabIndex = 25;
            this.OtherPlayerLabel.Text = "OtherPlayer";
            // 
            // LocalPlayerLabel
            // 
            this.LocalPlayerLabel.AutoSize = true;
            this.LocalPlayerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocalPlayerLabel.Location = new System.Drawing.Point(91, 12);
            this.LocalPlayerLabel.Name = "LocalPlayerLabel";
            this.LocalPlayerLabel.Size = new System.Drawing.Size(90, 20);
            this.LocalPlayerLabel.TabIndex = 24;
            this.LocalPlayerLabel.Text = "LocalPlayer";
            // 
            // ConnectingLabel
            // 
            this.ConnectingLabel.AutoSize = true;
            this.ConnectingLabel.BackColor = System.Drawing.Color.White;
            this.ConnectingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ConnectingLabel.Location = new System.Drawing.Point(474, 299);
            this.ConnectingLabel.Name = "ConnectingLabel";
            this.ConnectingLabel.Size = new System.Drawing.Size(127, 25);
            this.ConnectingLabel.TabIndex = 46;
            this.ConnectingLabel.Text = "Connecting...";
            // 
            // Connecting1Label
            // 
            this.Connecting1Label.AutoSize = true;
            this.Connecting1Label.BackColor = System.Drawing.Color.White;
            this.Connecting1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connecting1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Connecting1Label.Location = new System.Drawing.Point(474, 220);
            this.Connecting1Label.Name = "Connecting1Label";
            this.Connecting1Label.Size = new System.Drawing.Size(127, 25);
            this.Connecting1Label.TabIndex = 47;
            this.Connecting1Label.Text = "Connecting...";
            // 
            // GameServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 593);
            this.Controls.Add(this.Connecting1Label);
            this.Controls.Add(this.ConnectingLabel);
            this.Controls.Add(this.Speler2Box);
            this.Controls.Add(this.Speler1Box);
            this.Controls.Add(this.BeurtBox);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.hostofclient);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.bevestig_button);
            this.Controls.Add(this.type_uw_naam);
            this.Controls.Add(this.client_button);
            this.Controls.Add(this.host_button);
            this.Controls.Add(this.PuntenOther);
            this.Controls.Add(this.PuntenLocal);
            this.Controls.Add(this.home_button);
            this.Controls.Add(this.IpTextBox);
            this.Controls.Add(this.NaamTextBox);
            this.Controls.Add(this.BeurtLabel);
            this.Controls.Add(this.OtherPlayerLabel);
            this.Controls.Add(this.LocalPlayerLabel);
            this.Controls.Add(this.GridButton8Dup);
            this.Controls.Add(this.GridButton8);
            this.Controls.Add(this.GridButton7Dup);
            this.Controls.Add(this.GridButton7);
            this.Controls.Add(this.GridButton6Dup);
            this.Controls.Add(this.GridButton6);
            this.Controls.Add(this.GridButton5Dup);
            this.Controls.Add(this.GridButton5);
            this.Controls.Add(this.GridButton4Dup);
            this.Controls.Add(this.GridButton4);
            this.Controls.Add(this.GridButton3Dup);
            this.Controls.Add(this.GridButton3);
            this.Controls.Add(this.GridButton2Dup);
            this.Controls.Add(this.GridButton2);
            this.Controls.Add(this.GridButton1Dup);
            this.Controls.Add(this.GridButton1);
            this.Name = "GameServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameServer_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.connect_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bevestig_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_uw_naam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.host_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.home_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostofclient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BeurtBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speler1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speler2Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NaamTextBox;
        private System.Windows.Forms.Button GridButton1Dup;
        private System.Windows.Forms.Button GridButton2;
        private System.Windows.Forms.Button GridButton2Dup;
        private System.Windows.Forms.Button GridButton3;
        private System.Windows.Forms.Button GridButton3Dup;
        private System.Windows.Forms.Button GridButton4;
        private System.Windows.Forms.Button GridButton4Dup;
        private System.Windows.Forms.Button GridButton5;
        private System.Windows.Forms.Button GridButton5Dup;
        private System.Windows.Forms.Button GridButton6;
        private System.Windows.Forms.Button GridButton6Dup;
        private System.Windows.Forms.Button GridButton7;
        private System.Windows.Forms.Button GridButton7Dup;
        private System.Windows.Forms.Button GridButton8;
        private System.Windows.Forms.Button GridButton8Dup;
        private System.Windows.Forms.Button GridButton1;
        private System.Windows.Forms.Label BeurtLabel;
        private System.Windows.Forms.TextBox IpTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.PictureBox home_button;
        private System.Windows.Forms.Label PuntenLocal;
        private System.Windows.Forms.Label PuntenOther;
        private System.Windows.Forms.PictureBox host_button;
        private System.Windows.Forms.PictureBox client_button;
        private System.Windows.Forms.PictureBox type_uw_naam;
        private System.Windows.Forms.PictureBox bevestig_button;
        private System.Windows.Forms.PictureBox connect_button;
        private System.Windows.Forms.PictureBox hostofclient;
        private System.Windows.Forms.PictureBox ip;
        private System.Windows.Forms.PictureBox BeurtBox;
        private System.Windows.Forms.PictureBox Speler1Box;
        private System.Windows.Forms.PictureBox Speler2Box;
        private System.Windows.Forms.Label OtherPlayerLabel;
        private System.Windows.Forms.Label LocalPlayerLabel;
        private System.Windows.Forms.Label ConnectingLabel;
        private System.Windows.Forms.Label Connecting1Label;
    }
}