namespace CUBE_Launcher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.Initialize = new System.ComponentModel.BackgroundWorker();
            this.Button1 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadingIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Lucida Console", 24F);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(191, 736);
            this.Label1.TabIndex = 8;
            this.Label1.Text = "CUBE v. 🐟\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Initialize
            // 
            this.Initialize.WorkerSupportsCancellation = true;
            this.Initialize.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Initialize_DoWork);
            this.Initialize.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Initialize_RunWorkerCompleted);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 376);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(570, 23);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Start CUBE";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.PictureBox1.Image = global::CUBE_Launcher.Properties.Resources._1;
            this.PictureBox1.Location = new System.Drawing.Point(183, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(411, 411);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 9;
            this.PictureBox1.TabStop = false;
            // 
            // LoadingIcon
            // 
            this.LoadingIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LoadingIcon.Image = ((System.Drawing.Image)(resources.GetObject("LoadingIcon.Image")));
            this.LoadingIcon.Location = new System.Drawing.Point(0, 425);
            this.LoadingIcon.Name = "LoadingIcon";
            this.LoadingIcon.Size = new System.Drawing.Size(594, 411);
            this.LoadingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoadingIcon.TabIndex = 6;
            this.LoadingIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(594, 411);
            this.Controls.Add(this.LoadingIcon);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 450);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 450);
            this.Name = "Form1";
            this.Text = "CUBE Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.ComponentModel.BackgroundWorker Initialize;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.PictureBox LoadingIcon;
    }
}

