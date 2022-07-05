namespace FrontLayer
{
    partial class Buscar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cmdLog = new System.Windows.Forms.Button();
            this.optComic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdMin
            // 
            this.cmdMin.AutoSize = true;
            this.cmdMin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdMin.Location = new System.Drawing.Point(454, 9);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(21, 18);
            this.cmdMin.TabIndex = 16;
            this.cmdMin.Text = "_";
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.AutoSize = true;
            this.cmdClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdClose.Location = new System.Drawing.Point(481, 9);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(21, 18);
            this.cmdClose.TabIndex = 15;
            this.cmdClose.Text = "X";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(76, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(151, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Status: ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStatus.Location = new System.Drawing.Point(312, 284);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(64, 21);
            this.lblStatus.TabIndex = 20;
            this.lblStatus.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(149, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Precio: ";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrecio.Location = new System.Drawing.Point(312, 329);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(61, 21);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "$00.00";
            // 
            // cmdLog
            // 
            this.cmdLog.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdLog.FlatAppearance.BorderSize = 0;
            this.cmdLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLog.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdLog.Location = new System.Drawing.Point(144, 155);
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.Size = new System.Drawing.Size(234, 53);
            this.cmdLog.TabIndex = 23;
            this.cmdLog.Text = "Buscar Comic";
            this.cmdLog.UseVisualStyleBackColor = false;
            this.cmdLog.Click += new System.EventHandler(this.cmdLog_Click);
            // 
            // optComic
            // 
            this.optComic.BackColor = System.Drawing.SystemColors.Control;
            this.optComic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optComic.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComic.FormattingEnabled = true;
            this.optComic.Location = new System.Drawing.Point(161, 94);
            this.optComic.Name = "optComic";
            this.optComic.Size = new System.Drawing.Size(260, 29);
            this.optComic.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(202, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 38);
            this.label6.TabIndex = 48;
            this.label6.Text = "Buscar";
            // 
            // Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 451);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.optComic);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Buscar";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Buscar_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cmdMin;
        private System.Windows.Forms.Label cmdClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button cmdLog;
        private System.Windows.Forms.ComboBox optComic;
        private System.Windows.Forms.Label label6;
    }
}