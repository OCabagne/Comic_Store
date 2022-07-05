namespace FrontLayer
{
    partial class ClientScreen
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdCuenta = new System.Windows.Forms.Button();
            this.cmdCarrito = new System.Windows.Forms.Button();
            this.cmdSuscripcion = new System.Windows.Forms.Button();
            this.cmdTienda = new System.Windows.Forms.Button();
            this.cmdMin = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Label();
            this.Pagina = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.cmdCuenta);
            this.panel2.Controls.Add(this.cmdCarrito);
            this.panel2.Controls.Add(this.cmdSuscripcion);
            this.panel2.Controls.Add(this.cmdTienda);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 609);
            this.panel2.TabIndex = 2;
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
            this.cmdCuenta.Location = new System.Drawing.Point(0, 511);
            this.cmdCuenta.Name = "cmdCuenta";
            this.cmdCuenta.Size = new System.Drawing.Size(178, 38);
            this.cmdCuenta.TabIndex = 3;
            this.cmdCuenta.Text = "Cuenta";
            this.cmdCuenta.UseVisualStyleBackColor = true;
            this.cmdCuenta.Click += new System.EventHandler(this.cmdCuenta_Click);
            // 
            // cmdCarrito
            // 
            this.cmdCarrito.FlatAppearance.BorderSize = 0;
            this.cmdCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCarrito.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCarrito.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdCarrito.Location = new System.Drawing.Point(0, 205);
            this.cmdCarrito.Name = "cmdCarrito";
            this.cmdCarrito.Size = new System.Drawing.Size(178, 38);
            this.cmdCarrito.TabIndex = 2;
            this.cmdCarrito.Text = "Carrito";
            this.cmdCarrito.UseVisualStyleBackColor = true;
            this.cmdCarrito.Click += new System.EventHandler(this.cmdCarrito_Click);
            // 
            // cmdSuscripcion
            // 
            this.cmdSuscripcion.FlatAppearance.BorderSize = 0;
            this.cmdSuscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSuscripcion.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSuscripcion.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdSuscripcion.Location = new System.Drawing.Point(0, 379);
            this.cmdSuscripcion.Name = "cmdSuscripcion";
            this.cmdSuscripcion.Size = new System.Drawing.Size(178, 38);
            this.cmdSuscripcion.TabIndex = 1;
            this.cmdSuscripcion.Text = "Suscripciones";
            this.cmdSuscripcion.UseVisualStyleBackColor = true;
            this.cmdSuscripcion.Click += new System.EventHandler(this.cmdSuscripcion_Click);
            // 
            // cmdTienda
            // 
            this.cmdTienda.FlatAppearance.BorderSize = 0;
            this.cmdTienda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTienda.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTienda.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdTienda.Location = new System.Drawing.Point(0, 302);
            this.cmdTienda.Name = "cmdTienda";
            this.cmdTienda.Size = new System.Drawing.Size(178, 38);
            this.cmdTienda.TabIndex = 0;
            this.cmdTienda.Text = "Tienda";
            this.cmdTienda.UseVisualStyleBackColor = true;
            this.cmdTienda.Click += new System.EventHandler(this.cmdTienda_Click);
            // 
            // cmdMin
            // 
            this.cmdMin.AutoSize = true;
            this.cmdMin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdMin.Location = new System.Drawing.Point(672, 9);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(21, 18);
            this.cmdMin.TabIndex = 4;
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
            this.cmdClose.TabIndex = 3;
            this.cmdClose.Text = "X";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // Pagina
            // 
            this.Pagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pagina.Location = new System.Drawing.Point(178, 30);
            this.Pagina.Name = "Pagina";
            this.Pagina.Size = new System.Drawing.Size(554, 579);
            this.Pagina.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(3, 568);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 609);
            this.Controls.Add(this.Pagina);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientScreen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientScreen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientScreen_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label cmdMin;
        private System.Windows.Forms.Label cmdClose;
        private System.Windows.Forms.Button cmdTienda;
        private System.Windows.Forms.Button cmdCarrito;
        private System.Windows.Forms.Button cmdSuscripcion;
        private System.Windows.Forms.Button cmdCuenta;
        private System.Windows.Forms.Panel Pagina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}