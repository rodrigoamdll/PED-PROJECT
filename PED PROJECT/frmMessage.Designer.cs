
namespace PED_PROJECT
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picwhy = new System.Windows.Forms.PictureBox();
            this.picno = new System.Windows.Forms.PictureBox();
            this.picsi = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picwhy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Datos Incompletos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picwhy
            // 
            this.picwhy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picwhy.Image = ((System.Drawing.Image)(resources.GetObject("picwhy.Image")));
            this.picwhy.Location = new System.Drawing.Point(177, 10);
            this.picwhy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picwhy.Name = "picwhy";
            this.picwhy.Size = new System.Drawing.Size(30, 32);
            this.picwhy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picwhy.TabIndex = 36;
            this.picwhy.TabStop = false;
            this.picwhy.Visible = false;
            // 
            // picno
            // 
            this.picno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.picno.Image = ((System.Drawing.Image)(resources.GetObject("picno.Image")));
            this.picno.Location = new System.Drawing.Point(177, 10);
            this.picno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picno.Name = "picno";
            this.picno.Size = new System.Drawing.Size(30, 32);
            this.picno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picno.TabIndex = 37;
            this.picno.TabStop = false;
            this.picno.Visible = false;
            // 
            // picsi
            // 
            this.picsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.picsi.Image = ((System.Drawing.Image)(resources.GetObject("picsi.Image")));
            this.picsi.Location = new System.Drawing.Point(177, 10);
            this.picsi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picsi.Name = "picsi";
            this.picsi.Size = new System.Drawing.Size(30, 32);
            this.picsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsi.TabIndex = 38;
            this.picsi.TabStop = false;
            this.picsi.Visible = false;
            this.picsi.Click += new System.EventHandler(this.picsi_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(103, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 28);
            this.button2.TabIndex = 40;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(173, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 28);
            this.button1.TabIndex = 41;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(173, 63);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 28);
            this.button3.TabIndex = 42;
            this.button3.Text = "Si";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(226, 93);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picsi);
            this.Controls.Add(this.picno);
            this.Controls.Add(this.picwhy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aviso";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMessage_FormClosed);
            this.Load += new System.EventHandler(this.frmMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picwhy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox picwhy;
        public System.Windows.Forms.PictureBox picno;
        public System.Windows.Forms.PictureBox picsi;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
    }
}