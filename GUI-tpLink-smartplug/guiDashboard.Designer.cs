namespace GUI_tpLink_smartplug
{
    partial class guiDashboard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.turnOff_btn = new System.Windows.Forms.Button();
            this.turnOn_btn = new System.Windows.Forms.Button();
            this.tryConnection_btn = new System.Windows.Forms.Button();
            this.ipAddress_txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.infoDevice_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert IP address for smartplug";
            // 
            // turnOff_btn
            // 
            this.turnOff_btn.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.turnOff_btn.Location = new System.Drawing.Point(253, 359);
            this.turnOff_btn.Name = "turnOff_btn";
            this.turnOff_btn.Size = new System.Drawing.Size(212, 60);
            this.turnOff_btn.TabIndex = 1;
            this.turnOff_btn.Text = "Turn Off";
            this.turnOff_btn.UseVisualStyleBackColor = true;
            this.turnOff_btn.Click += new System.EventHandler(this.turnOff_btn_Click);
            // 
            // turnOn_btn
            // 
            this.turnOn_btn.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.turnOn_btn.Location = new System.Drawing.Point(30, 359);
            this.turnOn_btn.Name = "turnOn_btn";
            this.turnOn_btn.Size = new System.Drawing.Size(209, 60);
            this.turnOn_btn.TabIndex = 2;
            this.turnOn_btn.Text = "Turn On";
            this.turnOn_btn.UseVisualStyleBackColor = true;
            this.turnOn_btn.Click += new System.EventHandler(this.turnOn_btn_Click);
            // 
            // tryConnection_btn
            // 
            this.tryConnection_btn.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.tryConnection_btn.Location = new System.Drawing.Point(614, 81);
            this.tryConnection_btn.Name = "tryConnection_btn";
            this.tryConnection_btn.Size = new System.Drawing.Size(423, 56);
            this.tryConnection_btn.TabIndex = 3;
            this.tryConnection_btn.Text = "Try Connection to SmartPlug";
            this.tryConnection_btn.UseVisualStyleBackColor = true;
            this.tryConnection_btn.Click += new System.EventHandler(this.tryConnection_btn_Click);
            // 
            // ipAddress_txtb
            // 
            this.ipAddress_txtb.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ipAddress_txtb.Location = new System.Drawing.Point(18, 81);
            this.ipAddress_txtb.Name = "ipAddress_txtb";
            this.ipAddress_txtb.Size = new System.Drawing.Size(465, 39);
            this.ipAddress_txtb.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.label2.Location = new System.Drawing.Point(13, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "SmartPlug Info Device:";
            // 
            // infoDevice_lb
            // 
            this.infoDevice_lb.AutoSize = true;
            this.infoDevice_lb.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.infoDevice_lb.Location = new System.Drawing.Point(25, 236);
            this.infoDevice_lb.Name = "infoDevice_lb";
            this.infoDevice_lb.Size = new System.Drawing.Size(116, 27);
            this.infoDevice_lb.TabIndex = 6;
            this.infoDevice_lb.Text = "info device";
            // 
            // guiDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.infoDevice_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipAddress_txtb);
            this.Controls.Add(this.tryConnection_btn);
            this.Controls.Add(this.turnOn_btn);
            this.Controls.Add(this.turnOff_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "guiDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button turnOff_btn;
        private System.Windows.Forms.Button turnOn_btn;
        private System.Windows.Forms.Button tryConnection_btn;
        private System.Windows.Forms.TextBox ipAddress_txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label infoDevice_lb;
    }
}

