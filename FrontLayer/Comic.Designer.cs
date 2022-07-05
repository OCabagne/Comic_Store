namespace FrontLayer
{
    partial class Comic
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
            this.txtNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEditorial = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdMin = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(133, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 38);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Text = "Comic Name";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPrecio.Location = new System.Drawing.Point(121, 350);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(98, 29);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.Text = "$ 00.00";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtStatus.Location = new System.Drawing.Point(330, 350);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(85, 29);
            this.txtStatus.TabIndex = 9;
            this.txtStatus.Text = "Status";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(209, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Comprar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEditorial
            // 
            this.txtEditorial.AutoSize = true;
            this.txtEditorial.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditorial.Location = new System.Drawing.Point(289, 152);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(90, 21);
            this.txtEditorial.TabIndex = 11;
            this.txtEditorial.Text = "Editorial: ";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(289, 224);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(103, 21);
            this.txtFecha.TabIndex = 12;
            this.txtFecha.Text = "Fecha Pub: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontLayer.Properties.Resources._null;
            this.pictureBox1.Location = new System.Drawing.Point(78, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cmdMin
            // 
            this.cmdMin.AutoSize = true;
            this.cmdMin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdMin.Location = new System.Drawing.Point(470, 9);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(21, 18);
            this.cmdMin.TabIndex = 14;
            this.cmdMin.Text = "_";
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.AutoSize = true;
            this.cmdClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdClose.Location = new System.Drawing.Point(497, 9);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(21, 18);
            this.cmdClose.TabIndex = 13;
            this.cmdClose.Text = "X";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Comic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 490);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comic";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Comic_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtEditorial;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.Label cmdMin;
        private System.Windows.Forms.Label cmdClose;
    }
}