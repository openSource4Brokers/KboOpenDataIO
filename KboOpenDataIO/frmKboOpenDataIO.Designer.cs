namespace KboOpenDataIO
{
    partial class frmKboOpenDataIO
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
            this.tbHostedConnectionstring = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLocal = new System.Windows.Forms.RadioButton();
            this.rbHosted = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCheckHostedSqlServer = new System.Windows.Forms.Button();
            this.tbLocalConnectionstring = new System.Windows.Forms.TextBox();
            this.btnCheckLocalSqlServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadCsv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCsvLocation = new System.Windows.Forms.TextBox();
            this.btnGetCsvLocation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbHostedConnectionstring
            // 
            this.tbHostedConnectionstring.Location = new System.Drawing.Point(110, 109);
            this.tbHostedConnectionstring.Multiline = true;
            this.tbHostedConnectionstring.Name = "tbHostedConnectionstring";
            this.tbHostedConnectionstring.Size = new System.Drawing.Size(505, 62);
            this.tbHostedConnectionstring.TabIndex = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLocal);
            this.groupBox1.Controls.Add(this.rbHosted);
            this.groupBox1.Location = new System.Drawing.Point(110, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 62);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server";
            this.groupBox1.Visible = false;
            // 
            // rbLocal
            // 
            this.rbLocal.AutoSize = true;
            this.rbLocal.Location = new System.Drawing.Point(17, 21);
            this.rbLocal.Name = "rbLocal";
            this.rbLocal.Size = new System.Drawing.Size(73, 17);
            this.rbLocal.TabIndex = 85;
            this.rbLocal.Text = "Use Local";
            this.rbLocal.UseVisualStyleBackColor = true;
            this.rbLocal.CheckedChanged += new System.EventHandler(this.RbLocal_CheckedChanged);
            // 
            // rbHosted
            // 
            this.rbHosted.AutoSize = true;
            this.rbHosted.Location = new System.Drawing.Point(96, 21);
            this.rbHosted.Name = "rbHosted";
            this.rbHosted.Size = new System.Drawing.Size(81, 17);
            this.rbHosted.TabIndex = 86;
            this.rbHosted.Text = "Use Hosted";
            this.rbHosted.UseVisualStyleBackColor = true;
            this.rbHosted.CheckedChanged += new System.EventHandler(this.RbHosted_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "? hosted sqlserver";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCheckHostedSqlServer
            // 
            this.btnCheckHostedSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckHostedSqlServer.Location = new System.Drawing.Point(28, 149);
            this.btnCheckHostedSqlServer.Name = "btnCheckHostedSqlServer";
            this.btnCheckHostedSqlServer.Size = new System.Drawing.Size(76, 22);
            this.btnCheckHostedSqlServer.TabIndex = 106;
            this.btnCheckHostedSqlServer.Text = "Remember";
            this.btnCheckHostedSqlServer.UseVisualStyleBackColor = true;
            this.btnCheckHostedSqlServer.Click += new System.EventHandler(this.BtnCheckHostedSqlServer_Click);
            // 
            // tbLocalConnectionstring
            // 
            this.tbLocalConnectionstring.Location = new System.Drawing.Point(110, 51);
            this.tbLocalConnectionstring.Multiline = true;
            this.tbLocalConnectionstring.Name = "tbLocalConnectionstring";
            this.tbLocalConnectionstring.Size = new System.Drawing.Size(505, 50);
            this.tbLocalConnectionstring.TabIndex = 102;
            // 
            // btnCheckLocalSqlServer
            // 
            this.btnCheckLocalSqlServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckLocalSqlServer.Location = new System.Drawing.Point(28, 79);
            this.btnCheckLocalSqlServer.Name = "btnCheckLocalSqlServer";
            this.btnCheckLocalSqlServer.Size = new System.Drawing.Size(76, 22);
            this.btnCheckLocalSqlServer.TabIndex = 103;
            this.btnCheckLocalSqlServer.Text = "Remember";
            this.btnCheckLocalSqlServer.UseVisualStyleBackColor = true;
            this.btnCheckLocalSqlServer.Click += new System.EventHandler(this.BtnCheckLocalSqlServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "? local sqlserver";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnReadCsv
            // 
            this.btnReadCsv.Enabled = false;
            this.btnReadCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadCsv.Location = new System.Drawing.Point(543, 187);
            this.btnReadCsv.Name = "btnReadCsv";
            this.btnReadCsv.Size = new System.Drawing.Size(72, 25);
            this.btnReadCsv.TabIndex = 101;
            this.btnReadCsv.Text = "Start !";
            this.btnReadCsv.UseVisualStyleBackColor = true;
            this.btnReadCsv.Click += new System.EventHandler(this.BtnReadCsv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "? *.csv";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbCsvLocation
            // 
            this.tbCsvLocation.Location = new System.Drawing.Point(110, 12);
            this.tbCsvLocation.Multiline = true;
            this.tbCsvLocation.Name = "tbCsvLocation";
            this.tbCsvLocation.Size = new System.Drawing.Size(505, 22);
            this.tbCsvLocation.TabIndex = 98;
            // 
            // btnGetCsvLocation
            // 
            this.btnGetCsvLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetCsvLocation.Location = new System.Drawing.Point(63, 12);
            this.btnGetCsvLocation.Name = "btnGetCsvLocation";
            this.btnGetCsvLocation.Size = new System.Drawing.Size(41, 22);
            this.btnGetCsvLocation.TabIndex = 99;
            this.btnGetCsvLocation.Text = "...";
            this.btnGetCsvLocation.UseVisualStyleBackColor = true;
            this.btnGetCsvLocation.Click += new System.EventHandler(this.BtnGetCsvLocation_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(543, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 109;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // frmKboOpenDataIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(637, 261);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbHostedConnectionstring);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCheckHostedSqlServer);
            this.Controls.Add(this.tbLocalConnectionstring);
            this.Controls.Add(this.btnCheckLocalSqlServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReadCsv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCsvLocation);
            this.Controls.Add(this.btnGetCsvLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKboOpenDataIO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmKboOpenDataIO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbHostedConnectionstring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLocal;
        private System.Windows.Forms.RadioButton rbHosted;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnCheckHostedSqlServer;
        internal System.Windows.Forms.TextBox tbLocalConnectionstring;
        internal System.Windows.Forms.Button btnCheckLocalSqlServer;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReadCsv;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox tbCsvLocation;
        internal System.Windows.Forms.Button btnGetCsvLocation;
        private System.Windows.Forms.Button btnClose;
    }
}

