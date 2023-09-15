
namespace PED_PROJECT
{
    partial class frmTableEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableEdit));
            this.gbxprox = new Guna.UI.WinForms.GunaGroupBox();
            this.tablaedit = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaButton9 = new Guna.UI.WinForms.GunaButton();
            this.gbxprox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaedit)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxprox
            // 
            this.gbxprox.BackColor = System.Drawing.Color.Transparent;
            this.gbxprox.BaseColor = System.Drawing.Color.DodgerBlue;
            this.gbxprox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gbxprox.Controls.Add(this.tablaedit);
            this.gbxprox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxprox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.gbxprox.LineColor = System.Drawing.Color.Navy;
            this.gbxprox.Location = new System.Drawing.Point(41, 33);
            this.gbxprox.Name = "gbxprox";
            this.gbxprox.Radius = 25;
            this.gbxprox.Size = new System.Drawing.Size(720, 317);
            this.gbxprox.TabIndex = 63;
            this.gbxprox.Text = "   Seleccione una tarea";
            this.gbxprox.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // tablaedit
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tablaedit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaedit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaedit.BackgroundColor = System.Drawing.Color.White;
            this.tablaedit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaedit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaedit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaedit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaedit.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaedit.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaedit.EnableHeadersVisualStyles = false;
            this.tablaedit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaedit.Location = new System.Drawing.Point(29, 52);
            this.tablaedit.Name = "tablaedit";
            this.tablaedit.RowHeadersVisible = false;
            this.tablaedit.RowHeadersWidth = 51;
            this.tablaedit.RowTemplate.Height = 24;
            this.tablaedit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaedit.Size = new System.Drawing.Size(665, 232);
            this.tablaedit.TabIndex = 30;
            this.tablaedit.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablaedit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaedit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaedit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaedit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaedit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaedit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaedit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaedit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaedit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaedit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaedit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaedit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaedit.ThemeStyle.HeaderStyle.Height = 4;
            this.tablaedit.ThemeStyle.ReadOnly = false;
            this.tablaedit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaedit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaedit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaedit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaedit.ThemeStyle.RowsStyle.Height = 24;
            this.tablaedit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaedit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaedit.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaedit_CellMouseClick);
            // 
            // gunaButton9
            // 
            this.gunaButton9.AnimationHoverSpeed = 0.07F;
            this.gunaButton9.AnimationSpeed = 0.03F;
            this.gunaButton9.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton9.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(68)))), ((int)(((byte)(168)))));
            this.gunaButton9.BorderColor = System.Drawing.Color.Black;
            this.gunaButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton9.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton9.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton9.ForeColor = System.Drawing.Color.White;
            this.gunaButton9.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton9.Image")));
            this.gunaButton9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton9.ImageSize = new System.Drawing.Size(13, 13);
            this.gunaButton9.Location = new System.Drawing.Point(575, 366);
            this.gunaButton9.Name = "gunaButton9";
            this.gunaButton9.OnHoverBaseColor = System.Drawing.Color.DarkBlue;
            this.gunaButton9.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton9.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton9.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("gunaButton9.OnHoverImage")));
            this.gunaButton9.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaButton9.Radius = 15;
            this.gunaButton9.Size = new System.Drawing.Size(186, 38);
            this.gunaButton9.TabIndex = 72;
            this.gunaButton9.Text = "Seleccionar";
            this.gunaButton9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton9.Click += new System.EventHandler(this.gunaButton9_Click);
            // 
            // frmTableEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(801, 425);
            this.Controls.Add(this.gunaButton9);
            this.Controls.Add(this.gbxprox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTableEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis tareas";
            this.gbxprox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaedit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGroupBox gbxprox;
        private Guna.UI.WinForms.GunaDataGridView tablaedit;
        private Guna.UI.WinForms.GunaButton gunaButton9;
    }
}