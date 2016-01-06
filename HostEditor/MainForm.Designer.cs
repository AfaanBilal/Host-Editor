namespace HostEditor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.tbAlias = new System.Windows.Forms.TextBox();
            this.lblDomainAlias = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.btShowHostFile = new System.Windows.Forms.Button();
            this.tbD = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.tbIpAddr = new System.Windows.Forms.TextBox();
            this.lblTLD = new System.Windows.Forms.Label();
            this.lblIpAddr = new System.Windows.Forms.Label();
            this.btAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRD = new System.Windows.Forms.TextBox();
            this.btnRD = new System.Windows.Forms.Button();
            this.gbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(38, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(213, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Host Editor";
            // 
            // gbMain
            // 
            this.gbMain.BackColor = System.Drawing.Color.Transparent;
            this.gbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbMain.Controls.Add(this.btnRD);
            this.gbMain.Controls.Add(this.tbRD);
            this.gbMain.Controls.Add(this.label3);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Controls.Add(this.tbAlias);
            this.gbMain.Controls.Add(this.lblDomainAlias);
            this.gbMain.Controls.Add(this.btRegister);
            this.gbMain.Controls.Add(this.btShowHostFile);
            this.gbMain.Controls.Add(this.tbD);
            this.gbMain.Controls.Add(this.btReset);
            this.gbMain.Controls.Add(this.tbIpAddr);
            this.gbMain.Controls.Add(this.lblTLD);
            this.gbMain.Controls.Add(this.lblIpAddr);
            this.gbMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMain.Location = new System.Drawing.Point(12, 69);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(519, 482);
            this.gbMain.TabIndex = 2;
            this.gbMain.TabStop = false;
            this.gbMain.Text = ":";
            // 
            // tbAlias
            // 
            this.tbAlias.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAlias.Location = new System.Drawing.Point(251, 132);
            this.tbAlias.MaxLength = 255;
            this.tbAlias.Name = "tbAlias";
            this.tbAlias.Size = new System.Drawing.Size(228, 33);
            this.tbAlias.TabIndex = 4;
            this.tbAlias.Tag = "TLD Alias";
            this.tbAlias.Text = "Example Corp.";
            this.tbAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDomainAlias
            // 
            this.lblDomainAlias.AutoSize = true;
            this.lblDomainAlias.BackColor = System.Drawing.Color.Transparent;
            this.lblDomainAlias.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomainAlias.ForeColor = System.Drawing.Color.Black;
            this.lblDomainAlias.Location = new System.Drawing.Point(26, 133);
            this.lblDomainAlias.Name = "lblDomainAlias";
            this.lblDomainAlias.Size = new System.Drawing.Size(167, 32);
            this.lblDomainAlias.TabIndex = 0;
            this.lblDomainAlias.Text = "Domain Alias :";
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.PaleGreen;
            this.btRegister.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegister.Location = new System.Drawing.Point(149, 177);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(211, 59);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Register Domain";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btShowHostFile
            // 
            this.btShowHostFile.BackColor = System.Drawing.Color.PaleGreen;
            this.btShowHostFile.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btShowHostFile.FlatAppearance.BorderSize = 0;
            this.btShowHostFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btShowHostFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btShowHostFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShowHostFile.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowHostFile.Location = new System.Drawing.Point(7, 429);
            this.btShowHostFile.Name = "btShowHostFile";
            this.btShowHostFile.Size = new System.Drawing.Size(148, 47);
            this.btShowHostFile.TabIndex = 6;
            this.btShowHostFile.Text = "Show HOSTS File";
            this.btShowHostFile.UseVisualStyleBackColor = false;
            this.btShowHostFile.Click += new System.EventHandler(this.btShowHostFile_Click);
            // 
            // tbD
            // 
            this.tbD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbD.Location = new System.Drawing.Point(251, 93);
            this.tbD.MaxLength = 255;
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(228, 33);
            this.tbD.TabIndex = 3;
            this.tbD.Tag = "Top Level Domain";
            this.tbD.Text = "www.example.com";
            this.tbD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.LightCoral;
            this.btReset.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btReset.FlatAppearance.BorderSize = 0;
            this.btReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReset.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(350, 429);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(152, 47);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reset HOSTS File";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tbIpAddr
            // 
            this.tbIpAddr.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIpAddr.Location = new System.Drawing.Point(251, 54);
            this.tbIpAddr.MaxLength = 16;
            this.tbIpAddr.Name = "tbIpAddr";
            this.tbIpAddr.Size = new System.Drawing.Size(228, 33);
            this.tbIpAddr.TabIndex = 2;
            this.tbIpAddr.Tag = "IP Address";
            this.tbIpAddr.Text = "127.0.0.1";
            this.tbIpAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTLD
            // 
            this.lblTLD.AutoSize = true;
            this.lblTLD.BackColor = System.Drawing.Color.Transparent;
            this.lblTLD.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTLD.ForeColor = System.Drawing.Color.Black;
            this.lblTLD.Location = new System.Drawing.Point(26, 94);
            this.lblTLD.Name = "lblTLD";
            this.lblTLD.Size = new System.Drawing.Size(182, 32);
            this.lblTLD.TabIndex = 0;
            this.lblTLD.Text = "Domain Name :";
            // 
            // lblIpAddr
            // 
            this.lblIpAddr.AutoSize = true;
            this.lblIpAddr.BackColor = System.Drawing.Color.Transparent;
            this.lblIpAddr.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpAddr.ForeColor = System.Drawing.Color.Black;
            this.lblIpAddr.Location = new System.Drawing.Point(26, 54);
            this.lblIpAddr.Name = "lblIpAddr";
            this.lblIpAddr.Size = new System.Drawing.Size(137, 32);
            this.lblIpAddr.TabIndex = 0;
            this.lblIpAddr.Text = "IP Address :";
            // 
            // btAbout
            // 
            this.btAbout.BackColor = System.Drawing.Color.PaleGreen;
            this.btAbout.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btAbout.FlatAppearance.BorderSize = 0;
            this.btAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAbout.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAbout.Location = new System.Drawing.Point(438, 12);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(76, 38);
            this.btAbout.TabIndex = 1;
            this.btAbout.Text = "About";
            this.btAbout.UseVisualStyleBackColor = false;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Domain:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Remove Domain:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Domain Name :";
            // 
            // tbRD
            // 
            this.tbRD.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRD.Location = new System.Drawing.Point(251, 312);
            this.tbRD.MaxLength = 255;
            this.tbRD.Name = "tbRD";
            this.tbRD.Size = new System.Drawing.Size(228, 33);
            this.tbRD.TabIndex = 11;
            this.tbRD.Tag = "Top Level Domain";
            this.tbRD.Text = "www.example.com";
            this.tbRD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRD
            // 
            this.btnRD.BackColor = System.Drawing.Color.LightCoral;
            this.btnRD.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnRD.FlatAppearance.BorderSize = 0;
            this.btnRD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnRD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRD.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRD.Location = new System.Drawing.Point(149, 356);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(211, 43);
            this.btnRD.TabIndex = 12;
            this.btnRD.Text = "Remove Domain";
            this.btnRD.UseVisualStyleBackColor = false;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 563);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Host Editor";
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.TextBox tbIpAddr;
        private System.Windows.Forms.Label lblTLD;
        private System.Windows.Forms.Label lblIpAddr;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btShowHostFile;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.TextBox tbAlias;
        private System.Windows.Forms.Label lblDomainAlias;
        private System.Windows.Forms.TextBox tbRD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRD;
    }
}

