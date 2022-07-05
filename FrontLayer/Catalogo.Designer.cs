namespace FrontLayer
{
    partial class Catalogo
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
            this.optComic = new System.Windows.Forms.ComboBox();
            this.cmdLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optComic
            // 
            this.optComic.BackColor = System.Drawing.SystemColors.Control;
            this.optComic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optComic.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComic.FormattingEnabled = true;
            this.optComic.Location = new System.Drawing.Point(168, 163);
            this.optComic.Name = "optComic";
            this.optComic.Size = new System.Drawing.Size(260, 29);
            this.optComic.TabIndex = 50;
            // 
            // cmdLog
            // 
            this.cmdLog.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdLog.FlatAppearance.BorderSize = 0;
            this.cmdLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLog.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdLog.Location = new System.Drawing.Point(148, 267);
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.Size = new System.Drawing.Size(234, 53);
            this.cmdLog.TabIndex = 49;
            this.cmdLog.Text = "Ver Comic";
            this.cmdLog.UseVisualStyleBackColor = false;
            this.cmdLog.Click += new System.EventHandler(this.cmdLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(83, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre: ";
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 490);
            this.Controls.Add(this.optComic);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox optComic;
        private System.Windows.Forms.Button cmdLog;
        private System.Windows.Forms.Label label1;
    }
}