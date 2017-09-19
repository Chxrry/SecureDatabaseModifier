namespace SecureDatabaseModifier
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtSQLAddress = new System.Windows.Forms.TextBox();
            this.txtSQLDataBase = new System.Windows.Forms.TextBox();
            this.txtSQLUser = new System.Windows.Forms.TextBox();
            this.txtSQLPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSQLAddress
            // 
            this.txtSQLAddress.Location = new System.Drawing.Point(153, 28);
            this.txtSQLAddress.Name = "txtSQLAddress";
            this.txtSQLAddress.Size = new System.Drawing.Size(100, 25);
            this.txtSQLAddress.TabIndex = 1;
            // 
            // txtSQLDataBase
            // 
            this.txtSQLDataBase.Location = new System.Drawing.Point(153, 59);
            this.txtSQLDataBase.Name = "txtSQLDataBase";
            this.txtSQLDataBase.Size = new System.Drawing.Size(100, 25);
            this.txtSQLDataBase.TabIndex = 2;
            // 
            // txtSQLUser
            // 
            this.txtSQLUser.Location = new System.Drawing.Point(153, 90);
            this.txtSQLUser.Name = "txtSQLUser";
            this.txtSQLUser.Size = new System.Drawing.Size(100, 25);
            this.txtSQLUser.TabIndex = 3;
            // 
            // txtSQLPwd
            // 
            this.txtSQLPwd.Location = new System.Drawing.Point(153, 121);
            this.txtSQLPwd.Name = "txtSQLPwd";
            this.txtSQLPwd.Size = new System.Drawing.Size(100, 25);
            this.txtSQLPwd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 160);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSQLPwd);
            this.Controls.Add(this.txtSQLUser);
            this.Controls.Add(this.txtSQLDataBase);
            this.Controls.Add(this.txtSQLAddress);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtSQLAddress;
        public System.Windows.Forms.TextBox txtSQLDataBase;
        public System.Windows.Forms.TextBox txtSQLUser;
        public System.Windows.Forms.TextBox txtSQLPwd;
    }
}