namespace SchoolLive
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginid = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.loginpass = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginid
            // 
            this.loginid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginid.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginid.Location = new System.Drawing.Point(336, 356);
            this.loginid.MaxLength = 20;
            this.loginid.Name = "loginid";
            this.loginid.Size = new System.Drawing.Size(230, 22);
            this.loginid.TabIndex = 0;
            this.loginid.Text = "아이디";
            this.loginid.Enter += new System.EventHandler(this.Loginid_Enter);
            this.loginid.Leave += new System.EventHandler(this.Loginid_Leave);
            // 
            // loginpass
            // 
            this.loginpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginpass.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.loginpass.Location = new System.Drawing.Point(336, 399);
            this.loginpass.MaxLength = 20;
            this.loginpass.Name = "loginpass";
            this.loginpass.Size = new System.Drawing.Size(230, 22);
            this.loginpass.TabIndex = 1;
            this.loginpass.Text = "비밀번호";
            this.loginpass.Enter += new System.EventHandler(this.Loginpass_Enter);
            this.loginpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loginpass_KeyDown);
            this.loginpass.Leave += new System.EventHandler(this.Loginpass_Leave);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(336, 443);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(230, 31);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "로그인";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(12, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 11);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copyright ⓒ 2019 최태운 all rights reserved.";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.loginpass);
            this.Controls.Add(this.loginid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox loginid;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox loginpass;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
    }
}