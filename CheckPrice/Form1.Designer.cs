
namespace CheckPrice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btInet = new System.Windows.Forms.Button();
            this.btVPN = new System.Windows.Forms.Button();
            this.btBD = new System.Windows.Forms.Button();
            this.btAbout = new System.Windows.Forms.Button();
            this.btInformes = new System.Windows.Forms.Button();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.timerF = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btUpdate
            // 
            this.btUpdate.Enabled = false;
            this.btUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUpdate.Location = new System.Drawing.Point(287, 140);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(229, 71);
            this.btUpdate.TabIndex = 0;
            this.btUpdate.Text = "ACTUALIZAR";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(104, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(605, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACTUALIZADOR PRECIOS AUTOMÁTICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conexión Internet: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Conexión VPN (pfSense): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Conexión Base de Datos: ";
            // 
            // btInet
            // 
            this.btInet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btInet.BackgroundImage")));
            this.btInet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btInet.Enabled = false;
            this.btInet.Location = new System.Drawing.Point(210, 433);
            this.btInet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInet.Name = "btInet";
            this.btInet.Size = new System.Drawing.Size(35, 40);
            this.btInet.TabIndex = 5;
            this.btInet.UseVisualStyleBackColor = true;
            // 
            // btVPN
            // 
            this.btVPN.BackgroundImage = global::CheckPrice.Properties.Resources.not;
            this.btVPN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btVPN.Enabled = false;
            this.btVPN.Location = new System.Drawing.Point(210, 483);
            this.btVPN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btVPN.Name = "btVPN";
            this.btVPN.Size = new System.Drawing.Size(35, 40);
            this.btVPN.TabIndex = 6;
            this.btVPN.UseVisualStyleBackColor = true;
            // 
            // btBD
            // 
            this.btBD.BackgroundImage = global::CheckPrice.Properties.Resources.not;
            this.btBD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBD.Enabled = false;
            this.btBD.Location = new System.Drawing.Point(210, 531);
            this.btBD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btBD.Name = "btBD";
            this.btBD.Size = new System.Drawing.Size(35, 40);
            this.btBD.TabIndex = 7;
            this.btBD.UseVisualStyleBackColor = true;
            // 
            // btAbout
            // 
            this.btAbout.Location = new System.Drawing.Point(640, 533);
            this.btAbout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAbout.Name = "btAbout";
            this.btAbout.Size = new System.Drawing.Size(111, 31);
            this.btAbout.TabIndex = 8;
            this.btAbout.Text = "About!";
            this.btAbout.UseVisualStyleBackColor = true;
            this.btAbout.Click += new System.EventHandler(this.btAbout_Click);
            // 
            // btInformes
            // 
            this.btInformes.Location = new System.Drawing.Point(640, 480);
            this.btInformes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInformes.Name = "btInformes";
            this.btInformes.Size = new System.Drawing.Size(111, 31);
            this.btInformes.TabIndex = 9;
            this.btInformes.Text = "Informes";
            this.btInformes.UseVisualStyleBackColor = true;
            this.btInformes.Click += new System.EventHandler(this.btInformes_Click);
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(185, 263);
            this.pBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(426, 31);
            this.pBar.TabIndex = 10;
            this.pBar.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(185, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 11;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(185, 386);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 17);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Visible = false;
            // 
            // timerF
            // 
            this.timerF.Interval = 1000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 587);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.btInformes);
            this.Controls.Add(this.btAbout);
            this.Controls.Add(this.btBD);
            this.Controls.Add(this.btVPN);
            this.Controls.Add(this.btInet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btUpdate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "CheckPrice V1.0 - TECHTOOLS SRL 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btInet;
        private System.Windows.Forms.Button btVPN;
        private System.Windows.Forms.Button btBD;
        private System.Windows.Forms.Button btAbout;
        private System.Windows.Forms.Button btInformes;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timerF;
    }
}

