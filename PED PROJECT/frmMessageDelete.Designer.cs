namespace PED_PROJECT
{
    partial class frmMessageDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageDelete));
            this.Eliminar = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.picsi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminar.BackColor = System.Drawing.Color.Yellow;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.Black;
            this.Eliminar.Location = new System.Drawing.Point(198, 77);
            this.Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(51, 28);
            this.Eliminar.TabIndex = 46;
            this.Eliminar.Text = "Si";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Visible = false;
            this.Eliminar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancelar.BackColor = System.Drawing.Color.Yellow;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.Black;
            this.Cancelar.Location = new System.Drawing.Point(128, 77);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(51, 28);
            this.Cancelar.TabIndex = 45;
            this.Cancelar.Text = "No";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Visible = false;
            this.Cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // picsi
            // 
            this.picsi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picsi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.picsi.Image = ((System.Drawing.Image)(resources.GetObject("picsi.Image")));
            this.picsi.Location = new System.Drawing.Point(11, 24);
            this.picsi.Margin = new System.Windows.Forms.Padding(2);
            this.picsi.Name = "picsi";
            this.picsi.Size = new System.Drawing.Size(30, 32);
            this.picsi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsi.TabIndex = 44;
            this.picsi.TabStop = false;
            this.picsi.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(225)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 17);
            this.label1.TabIndex = 43;
            this.label1.Text = "Esta seguro que desea eliminar esta tarea";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-31, -5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 149);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // frmMessageDelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 142);
            this.ControlBox = false;
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.picsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessageDelet";
            this.Text = "Aviso";
            ((System.ComponentModel.ISupportInitialize)(this.picsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Eliminar;
        public System.Windows.Forms.Button Cancelar;
        public System.Windows.Forms.PictureBox picsi;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}