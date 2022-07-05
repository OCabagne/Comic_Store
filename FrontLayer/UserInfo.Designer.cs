namespace FrontLayer
{
    partial class UserInfo
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
            this.label6 = new System.Windows.Forms.Label();
            this.cmdMin = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.optName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(57, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(402, 38);
            this.label6.TabIndex = 35;
            this.label6.Text = "Información de Usuario";
            // 
            // cmdMin
            // 
            this.cmdMin.AutoSize = true;
            this.cmdMin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdMin.Location = new System.Drawing.Point(438, 9);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(21, 18);
            this.cmdMin.TabIndex = 34;
            this.cmdMin.Text = "_";
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.AutoSize = true;
            this.cmdClose.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdClose.Location = new System.Drawing.Point(465, 9);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(21, 18);
            this.cmdClose.TabIndex = 33;
            this.cmdClose.Text = "X";
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 115);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // optName
            // 
            this.optName.BackColor = System.Drawing.SystemColors.Control;
            this.optName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.optName.FormattingEnabled = true;
            this.optName.Location = new System.Drawing.Point(189, 142);
            this.optName.Name = "optName";
            this.optName.Size = new System.Drawing.Size(250, 29);
            this.optName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(92, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Nombre";
            // 
            // cmdLog
            // 
            this.cmdLog.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdLog.FlatAppearance.BorderSize = 0;
            this.cmdLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLog.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmdLog.Location = new System.Drawing.Point(145, 206);
            this.cmdLog.Name = "cmdLog";
            this.cmdLog.Size = new System.Drawing.Size(234, 53);
            this.cmdLog.TabIndex = 39;
            this.cmdLog.Text = "Buscar";
            this.cmdLog.UseVisualStyleBackColor = false;
            this.cmdLog.Click += new System.EventHandler(this.cmdLog_Click);
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 412);
            this.Controls.Add(this.cmdLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfo";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfo";
            this.Load += new System.EventHandler(this.UserInfo_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserInfo_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cmdMin;
        private System.Windows.Forms.Label cmdClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox optName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdLog;
    }
}