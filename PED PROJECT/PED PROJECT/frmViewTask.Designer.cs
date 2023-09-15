
namespace PED_PROJECT
{
    partial class frmViewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTask));
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(112, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 58);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tareas Programadas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(667, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Por tipo",
            "Por proximidad"});
            this.gunaComboBox1.Location = new System.Drawing.Point(167, 16);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 7;
            this.gunaComboBox1.Size = new System.Drawing.Size(201, 31);
            this.gunaComboBox1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tipo de vista";
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.SlateBlue;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.SlateBlue;
            this.gunaGroupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Indigo;
            this.gunaGroupBox3.Location = new System.Drawing.Point(431, 204);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Radius = 25;
            this.gunaGroupBox3.Size = new System.Drawing.Size(336, 386);
            this.gunaGroupBox3.TabIndex = 37;
            this.gunaGroupBox3.Text = "   Por Proximidad";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaElipsePanel1.Controls.Add(this.gunaButton2);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.gunaComboBox1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(47, 101);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(588, 68);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(68)))), ((int)(((byte)(168)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.ImageSize = new System.Drawing.Size(21, 21);
            this.gunaButton2.Location = new System.Drawing.Point(384, 16);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.DarkBlue;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton2.OnHoverImage")));
            this.gunaButton2.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButton2.Radius = 15;
            this.gunaButton2.Size = new System.Drawing.Size(187, 38);
            this.gunaButton2.TabIndex = 52;
            this.gunaButton2.Text = "Visualizar";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(185)))));
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(185)))));
            this.gunaGroupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(116)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(47, 204);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 25;
            this.gunaGroupBox2.Size = new System.Drawing.Size(336, 386);
            this.gunaGroupBox2.TabIndex = 36;
            this.gunaGroupBox2.Text = "   Por Tipo";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // frmViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(817, 615);
            this.Controls.Add(this.gunaGroupBox2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaGroupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewTask";
            this.Text = "Vista General";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
    }
}