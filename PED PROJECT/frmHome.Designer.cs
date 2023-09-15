
namespace PED_PROJECT
{
    partial class frmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.noact = new Guna.UI.WinForms.GunaGradient2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.moon = new System.Windows.Forms.PictureBox();
            this.sun = new System.Windows.Forms.PictureBox();
            this.act = new Guna.UI.WinForms.GunaGradient2Panel();
            this.tablatareas = new Guna.UI.WinForms.GunaDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pp3 = new Guna.UI.WinForms.GunaButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pp4 = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.noact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).BeginInit();
            this.act.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablatareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 58);
            this.label1.TabIndex = 24;
            this.label1.Text = "Buenos días, Usuario";
            // 
            // sunrise
            // 
            this.sunrise.Image = ((System.Drawing.Image)(resources.GetObject("sunrise.Image")));
            this.sunrise.Location = new System.Drawing.Point(685, 4);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(120, 120);
            this.sunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sunrise.TabIndex = 25;
            this.sunrise.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(70, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(395, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Parece que estas al día";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(211, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 157);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // noact
            // 
            this.noact.BackColor = System.Drawing.Color.Transparent;
            this.noact.Controls.Add(this.label3);
            this.noact.Controls.Add(this.pictureBox2);
            this.noact.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.noact.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.noact.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.noact.Location = new System.Drawing.Point(128, 134);
            this.noact.Name = "noact";
            this.noact.Radius = 25;
            this.noact.Size = new System.Drawing.Size(539, 431);
            this.noact.TabIndex = 28;
            this.noact.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // moon
            // 
            this.moon.Image = ((System.Drawing.Image)(resources.GetObject("moon.Image")));
            this.moon.Location = new System.Drawing.Point(685, 4);
            this.moon.Name = "moon";
            this.moon.Size = new System.Drawing.Size(120, 120);
            this.moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.moon.TabIndex = 29;
            this.moon.TabStop = false;
            // 
            // sun
            // 
            this.sun.Image = ((System.Drawing.Image)(resources.GetObject("sun.Image")));
            this.sun.Location = new System.Drawing.Point(685, 4);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(120, 120);
            this.sun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sun.TabIndex = 30;
            this.sun.TabStop = false;
            // 
            // act
            // 
            this.act.BackColor = System.Drawing.Color.Transparent;
            this.act.Controls.Add(this.tablatareas);
            this.act.Controls.Add(this.label2);
            this.act.Controls.Add(this.pictureBox1);
            this.act.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.act.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.act.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.act.Location = new System.Drawing.Point(126, 133);
            this.act.Name = "act";
            this.act.Radius = 25;
            this.act.Size = new System.Drawing.Size(539, 431);
            this.act.TabIndex = 29;
            this.act.Visible = false;
            // 
            // tablatareas
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.tablatareas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tablatareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablatareas.BackgroundColor = System.Drawing.Color.White;
            this.tablatareas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablatareas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablatareas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablatareas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablatareas.ColumnHeadersHeight = 4;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablatareas.DefaultCellStyle = dataGridViewCellStyle12;
            this.tablatareas.EnableHeadersVisualStyles = false;
            this.tablatareas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablatareas.Location = new System.Drawing.Point(52, 144);
            this.tablatareas.Name = "tablatareas";
            this.tablatareas.RowHeadersVisible = false;
            this.tablatareas.RowHeadersWidth = 51;
            this.tablatareas.RowTemplate.Height = 24;
            this.tablatareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablatareas.Size = new System.Drawing.Size(434, 214);
            this.tablatareas.TabIndex = 28;
            this.tablatareas.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablatareas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablatareas.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablatareas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablatareas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablatareas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablatareas.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablatareas.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablatareas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablatareas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablatareas.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tablatareas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablatareas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablatareas.ThemeStyle.HeaderStyle.Height = 4;
            this.tablatareas.ThemeStyle.ReadOnly = false;
            this.tablatareas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablatareas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablatareas.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablatareas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablatareas.ThemeStyle.RowsStyle.Height = 24;
            this.tablatareas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablatareas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(70, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Proximas Tareas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(659, 578);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "label4";
            // 
            // pp3
            // 
            this.pp3.AnimationHoverSpeed = 0.07F;
            this.pp3.AnimationSpeed = 0.03F;
            this.pp3.BackColor = System.Drawing.Color.Transparent;
            this.pp3.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.pp3.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.pp3.BorderSize = 3;
            this.pp3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pp3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pp3.FocusedColor = System.Drawing.Color.Empty;
            this.pp3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pp3.ForeColor = System.Drawing.Color.Navy;
            this.pp3.Image = ((System.Drawing.Image)(resources.GetObject("pp3.Image")));
            this.pp3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pp3.ImageSize = new System.Drawing.Size(52, 52);
            this.pp3.Location = new System.Drawing.Point(701, 251);
            this.pp3.Name = "pp3";
            this.pp3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pp3.OnHoverBorderColor = System.Drawing.Color.White;
            this.pp3.OnHoverForeColor = System.Drawing.Color.Navy;
            this.pp3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("pp3.OnHoverImage")));
            this.pp3.OnPressedColor = System.Drawing.Color.Blue;
            this.pp3.Radius = 30;
            this.pp3.Size = new System.Drawing.Size(89, 80);
            this.pp3.TabIndex = 66;
            this.pp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pp3.Click += new System.EventHandler(this.pp3_Click);
            this.pp3.MouseHover += new System.EventHandler(this.pp3_MouseHover);
            // 
            // pp4
            // 
            this.pp4.AnimationHoverSpeed = 0.07F;
            this.pp4.AnimationSpeed = 0.03F;
            this.pp4.BackColor = System.Drawing.Color.Transparent;
            this.pp4.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.pp4.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.pp4.BorderSize = 3;
            this.pp4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pp4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pp4.FocusedColor = System.Drawing.Color.Empty;
            this.pp4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pp4.ForeColor = System.Drawing.Color.Navy;
            this.pp4.Image = ((System.Drawing.Image)(resources.GetObject("pp4.Image")));
            this.pp4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pp4.ImageSize = new System.Drawing.Size(52, 52);
            this.pp4.Location = new System.Drawing.Point(701, 388);
            this.pp4.Name = "pp4";
            this.pp4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pp4.OnHoverBorderColor = System.Drawing.Color.White;
            this.pp4.OnHoverForeColor = System.Drawing.Color.Navy;
            this.pp4.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("pp4.OnHoverImage")));
            this.pp4.OnPressedColor = System.Drawing.Color.Blue;
            this.pp4.Radius = 30;
            this.pp4.Size = new System.Drawing.Size(89, 80);
            this.pp4.TabIndex = 67;
            this.pp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pp4.Click += new System.EventHandler(this.gunaButton1_Click);
            this.pp4.MouseHover += new System.EventHandler(this.gunaButton1_MouseHover);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(817, 615);
            this.Controls.Add(this.pp4);
            this.Controls.Add(this.pp3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.act);
            this.Controls.Add(this.sun);
            this.Controls.Add(this.moon);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noact);
            this.Name = "frmHome";
            this.Text = "frmHome";
            ((System.ComponentModel.ISupportInitialize)(this.sunrise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.noact.ResumeLayout(false);
            this.noact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sun)).EndInit();
            this.act.ResumeLayout(false);
            this.act.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablatareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox sunrise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaGradient2Panel noact;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox moon;
        private System.Windows.Forms.PictureBox sun;
        private Guna.UI.WinForms.GunaGradient2Panel act;
        private Guna.UI.WinForms.GunaDataGridView tablatareas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaButton pp3;
        private System.Windows.Forms.ToolTip toolTip1;
        public Guna.UI.WinForms.GunaButton pp4;
    }
}