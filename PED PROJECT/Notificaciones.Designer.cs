
namespace PED_PROJECT
{
    partial class Notificaciones
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
            this.PicAlertBox = new System.Windows.Forms.PictureBox();
            this.LineAlertBox = new System.Windows.Forms.Panel();
            this.LblTextAlertBox = new System.Windows.Forms.Label();
            this.LblTitleAlertBox = new System.Windows.Forms.Label();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.ellipse = new Ellipse.EllipseControl();
            ((System.ComponentModel.ISupportInitialize)(this.PicAlertBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicAlertBox
            // 
            this.PicAlertBox.Location = new System.Drawing.Point(26, 15);
            this.PicAlertBox.Name = "PicAlertBox";
            this.PicAlertBox.Size = new System.Drawing.Size(50, 50);
            this.PicAlertBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAlertBox.TabIndex = 4;
            this.PicAlertBox.TabStop = false;
            // 
            // LineAlertBox
            // 
            this.LineAlertBox.BackColor = System.Drawing.Color.Black;
            this.LineAlertBox.Location = new System.Drawing.Point(1, 74);
            this.LineAlertBox.Name = "LineAlertBox";
            this.LineAlertBox.Size = new System.Drawing.Size(8, 6);
            this.LineAlertBox.TabIndex = 7;
            // 
            // LblTextAlertBox
            // 
            this.LblTextAlertBox.AutoSize = true;
            this.LblTextAlertBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextAlertBox.Location = new System.Drawing.Point(106, 49);
            this.LblTextAlertBox.Name = "LblTextAlertBox";
            this.LblTextAlertBox.Size = new System.Drawing.Size(128, 23);
            this.LblTextAlertBox.TabIndex = 6;
            this.LblTextAlertBox.Text = "TextAlertBox";
            // 
            // LblTitleAlertBox
            // 
            this.LblTitleAlertBox.AutoSize = true;
            this.LblTitleAlertBox.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitleAlertBox.Location = new System.Drawing.Point(104, 15);
            this.LblTitleAlertBox.Name = "LblTitleAlertBox";
            this.LblTitleAlertBox.Size = new System.Drawing.Size(180, 34);
            this.LblTitleAlertBox.TabIndex = 5;
            this.LblTitleAlertBox.Text = "TitleAlertBox";
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 10;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // ellipse
            // 
            this.ellipse.CornerRadius = 20;
            this.ellipse.TargetControl = this;
            // 
            // Notificaciones
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 80);
            this.Controls.Add(this.PicAlertBox);
            this.Controls.Add(this.LineAlertBox);
            this.Controls.Add(this.LblTextAlertBox);
            this.Controls.Add(this.LblTitleAlertBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Notificaciones";
            this.Text = "Notificaciones";
            this.Load += new System.EventHandler(this.Notificaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicAlertBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicAlertBox;
        private System.Windows.Forms.Panel LineAlertBox;
        private System.Windows.Forms.Label LblTextAlertBox;
        private System.Windows.Forms.Label LblTitleAlertBox;
        private System.Windows.Forms.Timer timerAnimation;
        private Ellipse.EllipseControl ellipse;
    }
}