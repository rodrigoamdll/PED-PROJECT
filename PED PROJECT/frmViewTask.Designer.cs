
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewTask));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbvista = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxprox = new Guna.UI.WinForms.GunaGroupBox();
            this.tablaprox = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.cmbcat = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gbxtipo = new Guna.UI.WinForms.GunaGroupBox();
            this.tablatipo = new Guna.UI.WinForms.GunaDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxprox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaprox)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.gbxtipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablatipo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(141, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(440, 58);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tareas Programadas";
            // 
            // cmbvista
            // 
            this.cmbvista.BackColor = System.Drawing.Color.Transparent;
            this.cmbvista.BaseColor = System.Drawing.Color.White;
            this.cmbvista.BorderColor = System.Drawing.Color.Silver;
            this.cmbvista.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbvista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbvista.FocusedColor = System.Drawing.Color.Empty;
            this.cmbvista.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbvista.ForeColor = System.Drawing.Color.Black;
            this.cmbvista.FormattingEnabled = true;
            this.cmbvista.Items.AddRange(new object[] {
            "Por tipo",
            "Por proximidad"});
            this.cmbvista.Location = new System.Drawing.Point(167, 16);
            this.cmbvista.Name = "cmbvista";
            this.cmbvista.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbvista.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbvista.Radius = 7;
            this.cmbvista.Size = new System.Drawing.Size(201, 31);
            this.cmbvista.TabIndex = 53;
            this.cmbvista.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
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
            // gbxprox
            // 
            this.gbxprox.BackColor = System.Drawing.Color.Transparent;
            this.gbxprox.BaseColor = System.Drawing.Color.SlateBlue;
            this.gbxprox.BorderColor = System.Drawing.Color.SlateBlue;
            this.gbxprox.Controls.Add(this.tablaprox);
            this.gbxprox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxprox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.gbxprox.LineColor = System.Drawing.Color.Indigo;
            this.gbxprox.Location = new System.Drawing.Point(107, 249);
            this.gbxprox.Name = "gbxprox";
            this.gbxprox.Radius = 25;
            this.gbxprox.Size = new System.Drawing.Size(588, 354);
            this.gbxprox.TabIndex = 37;
            this.gbxprox.Text = "   Por Proximidad";
            this.gbxprox.TextLocation = new System.Drawing.Point(10, 8);
            this.gbxprox.Visible = false;
            // 
            // tablaprox
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tablaprox.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaprox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaprox.BackgroundColor = System.Drawing.Color.White;
            this.tablaprox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaprox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaprox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaprox.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaprox.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaprox.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaprox.EnableHeadersVisualStyles = false;
            this.tablaprox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaprox.Location = new System.Drawing.Point(36, 61);
            this.tablaprox.Name = "tablaprox";
            this.tablaprox.RowHeadersVisible = false;
            this.tablaprox.RowHeadersWidth = 51;
            this.tablaprox.RowTemplate.Height = 24;
            this.tablaprox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaprox.Size = new System.Drawing.Size(521, 214);
            this.tablaprox.TabIndex = 29;
            this.tablaprox.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablaprox.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaprox.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablaprox.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablaprox.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablaprox.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablaprox.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablaprox.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaprox.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablaprox.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaprox.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaprox.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablaprox.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablaprox.ThemeStyle.HeaderStyle.Height = 4;
            this.tablaprox.ThemeStyle.ReadOnly = false;
            this.tablaprox.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablaprox.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaprox.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaprox.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablaprox.ThemeStyle.RowsStyle.Height = 24;
            this.tablaprox.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablaprox.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gunaElipsePanel1.Controls.Add(this.cmbcat);
            this.gunaElipsePanel1.Controls.Add(this.label1);
            this.gunaElipsePanel1.Controls.Add(this.gunaButton2);
            this.gunaElipsePanel1.Controls.Add(this.label2);
            this.gunaElipsePanel1.Controls.Add(this.cmbvista);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(107, 118);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 15;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(588, 105);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // cmbcat
            // 
            this.cmbcat.BackColor = System.Drawing.Color.Transparent;
            this.cmbcat.BaseColor = System.Drawing.Color.White;
            this.cmbcat.BorderColor = System.Drawing.Color.Silver;
            this.cmbcat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcat.FocusedColor = System.Drawing.Color.Empty;
            this.cmbcat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcat.ForeColor = System.Drawing.Color.Black;
            this.cmbcat.FormattingEnabled = true;
            this.cmbcat.Items.AddRange(new object[] {
            "Laborales",
            "Acádemicas",
            "Del Hogar",
            "Cuidado Personal",
            "Ocio y Recreacion"});
            this.cmbcat.Location = new System.Drawing.Point(167, 57);
            this.cmbcat.Name = "cmbcat";
            this.cmbcat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbcat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbcat.Radius = 7;
            this.cmbcat.Size = new System.Drawing.Size(201, 31);
            this.cmbcat.TabIndex = 55;
            this.cmbcat.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Categoria";
            this.label1.Visible = false;
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
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gbxtipo
            // 
            this.gbxtipo.BackColor = System.Drawing.Color.Transparent;
            this.gbxtipo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(185)))));
            this.gbxtipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(155)))), ((int)(((byte)(185)))));
            this.gbxtipo.Controls.Add(this.tablatipo);
            this.gbxtipo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxtipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(216)))), ((int)(((byte)(237)))));
            this.gbxtipo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(28)))), ((int)(((byte)(116)))));
            this.gbxtipo.Location = new System.Drawing.Point(107, 249);
            this.gbxtipo.Name = "gbxtipo";
            this.gbxtipo.Radius = 25;
            this.gbxtipo.Size = new System.Drawing.Size(588, 354);
            this.gbxtipo.TabIndex = 36;
            this.gbxtipo.Text = "   Por Tipo";
            this.gbxtipo.TextLocation = new System.Drawing.Point(10, 8);
            this.gbxtipo.Visible = false;
            // 
            // tablatipo
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.tablatipo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablatipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablatipo.BackgroundColor = System.Drawing.Color.White;
            this.tablatipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablatipo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablatipo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablatipo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablatipo.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablatipo.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablatipo.EnableHeadersVisualStyles = false;
            this.tablatipo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablatipo.Location = new System.Drawing.Point(36, 61);
            this.tablatipo.Name = "tablatipo";
            this.tablatipo.RowHeadersVisible = false;
            this.tablatipo.RowHeadersWidth = 51;
            this.tablatipo.RowTemplate.Height = 24;
            this.tablatipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablatipo.Size = new System.Drawing.Size(521, 214);
            this.tablatipo.TabIndex = 30;
            this.tablatipo.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tablatipo.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tablatipo.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tablatipo.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tablatipo.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tablatipo.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tablatipo.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tablatipo.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablatipo.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tablatipo.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablatipo.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablatipo.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tablatipo.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tablatipo.ThemeStyle.HeaderStyle.Height = 4;
            this.tablatipo.ThemeStyle.ReadOnly = false;
            this.tablatipo.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tablatipo.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablatipo.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablatipo.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tablatipo.ThemeStyle.RowsStyle.Height = 24;
            this.tablatipo.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tablatipo.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(113, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 39);
            this.label3.TabIndex = 21;
            this.label3.Text = "No tienes tareas pendientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(47, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 357);
            this.panel1.TabIndex = 37;
            this.panel1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(450, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmViewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(222)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(817, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxprox);
            this.Controls.Add(this.gbxtipo);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewTask";
            this.Text = "Vista General";
            this.gbxprox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaprox)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gbxtipo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablatipo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaComboBox cmbvista;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGroupBox gbxprox;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaGroupBox gbxtipo;
        private Guna.UI.WinForms.GunaComboBox cmbcat;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView tablaprox;
        private Guna.UI.WinForms.GunaDataGridView tablatipo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}