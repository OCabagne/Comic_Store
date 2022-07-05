namespace FrontLayer
{
    partial class AdminScreen
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
            this.cmdMin = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCuenta = new System.Windows.Forms.Button();
            this.cmdComic = new System.Windows.Forms.Button();
            this.cmdUser = new System.Windows.Forms.Button();
            this.Pagina = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdMin
            // 
            this.cmdMin.AutoSize = true;
            this.cmdMin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdMin.Location = new System.Drawing.Point(672, 9);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(21, 18);
            this.cmdMin.TabIndex = 6;
            this.cmdMin.Text = "_";
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.AutoSize = true;
            this.cmdClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdClose.Location = new System.Drawing.Point(699, 9);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(21, 18);
            this.cmdClose.TabIndex = 5;
            this.cmdClose.Text = "X";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cmdCuenta);
            this.panel2.Controls.Add(this.cmdComic);
            this.panel2.Controls.Add(this.cmdUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 609);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontLayer.Properties.Resources.comicstore;
            this.pictureBox1.Location = new System.Drawing.Point(27, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdCuenta
            // 
            this.cmdCuenta.FlatAppearance.BorderSize = 0;
            this.cmdCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCuenta.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCuenta.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdCuenta.Location = new System.Drawing.Point(0, 515);
            this.cmdCuenta.Name = "cmdCuenta";
            this.cmdCuenta.Size = new System.Drawing.Size(178, 38);
            this.cmdCuenta.TabIndex = 3;
            this.cmdCuenta.Text = "Cuenta";
            this.cmdCuenta.UseVisualStyleBackColor = true;
            this.cmdCuenta.Click += new System.EventHandler(this.cmdCuenta_Click);
            // 
            // cmdComic
            // 
            this.cmdComic.FlatAppearance.BorderSize = 0;
            this.cmdComic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdComic.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdComic.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdComic.Location = new System.Drawing.Point(0, 243);
            this.cmdComic.Name = "cmdComic";
            this.cmdComic.Size = new System.Drawing.Size(178, 38);
            this.cmdComic.TabIndex = 2;
            this.cmdComic.Text = "Comics";
            this.cmdComic.UseVisualStyleBackColor = true;
            this.cmdComic.Click += new System.EventHandler(this.cmdComic_Click);
            // 
            // cmdUser
            // 
            this.cmdUser.FlatAppearance.BorderSize = 0;
            this.cmdUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUser.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUser.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdUser.Location = new System.Drawing.Point(0, 315);
            this.cmdUser.Name = "cmdUser";
            this.cmdUser.Size = new System.Drawing.Size(178, 38);
            this.cmdUser.TabIndex = 0;
            this.cmdUser.Text = "Usuario";
            this.cmdUser.UseVisualStyleBackColor = true;
            this.cmdUser.Click += new System.EventHandler(this.cmdUser_Click);
            // 
            // Pagina
            // 
            this.Pagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pagina.Location = new System.Drawing.Point(178, 30);
            this.Pagina.Name = "Pagina";
            this.Pagina.Size = new System.Drawing.Size(554, 579);
            this.Pagina.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(0, 571);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 609);
            this.Controls.Add(this.Pagina);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminScreen";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AminScreen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminScreen_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmdMin;
        private System.Windows.Forms.Label cmdClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdCuenta;
        private System.Windows.Forms.Button cmdComic;
        private System.Windows.Forms.Button cmdUser;
        private System.Windows.Forms.Panel Pagina;
        private System.Windows.Forms.Button button1;
    }
}