namespace WindowsFormsApplication4
{
    partial class WelcomeForm
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
            this.lbWelcomeText = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbEnterData = new System.Windows.Forms.Label();
            this.lbWarningWrongData = new System.Windows.Forms.Label();
            this.lbCautionLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btEnter = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWelcomeText
            // 
            this.lbWelcomeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWelcomeText.ForeColor = System.Drawing.Color.Turquoise;
            this.lbWelcomeText.Location = new System.Drawing.Point(93, 31);
            this.lbWelcomeText.Name = "lbWelcomeText";
            this.lbWelcomeText.Size = new System.Drawing.Size(296, 71);
            this.lbWelcomeText.TabIndex = 0;
            this.lbWelcomeText.Text = "Welcome to Windows Personnel                     Department";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbLogin.Location = new System.Drawing.Point(122, 156);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(228, 26);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "Login";
            this.tbLogin.Click += new System.EventHandler(this.tbLogin_TextChanged);
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            this.tbLogin.Enter += new System.EventHandler(this.tbLogin_Enter);
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLogin_KeyDown);
            this.tbLogin.Leave += new System.EventHandler(this.tbLogin_Leave);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbPassword.Location = new System.Drawing.Point(122, 189);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(228, 26);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Password";
            this.tbPassword.Click += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            this.tbPassword.Leave += new System.EventHandler(this.ttbPassword_Leave);
            // 
            // lbEnterData
            // 
            this.lbEnterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEnterData.Location = new System.Drawing.Point(119, 136);
            this.lbEnterData.Name = "lbEnterData";
            this.lbEnterData.Size = new System.Drawing.Size(231, 21);
            this.lbEnterData.TabIndex = 2;
            this.lbEnterData.Text = "Please, enter your personal data:";
            // 
            // lbWarningWrongData
            // 
            this.lbWarningWrongData.ForeColor = System.Drawing.Color.Red;
            this.lbWarningWrongData.Location = new System.Drawing.Point(119, 218);
            this.lbWarningWrongData.Name = "lbWarningWrongData";
            this.lbWarningWrongData.Size = new System.Drawing.Size(231, 18);
            this.lbWarningWrongData.TabIndex = 3;
            this.lbWarningWrongData.Text = "Invalid login or password, please try again later";
            this.lbWarningWrongData.Visible = false;
            // 
            // lbCautionLogin
            // 
            this.lbCautionLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCautionLogin.ForeColor = System.Drawing.Color.Red;
            this.lbCautionLogin.Location = new System.Drawing.Point(356, 168);
            this.lbCautionLogin.Name = "lbCautionLogin";
            this.lbCautionLogin.Size = new System.Drawing.Size(14, 14);
            this.lbCautionLogin.TabIndex = 4;
            this.lbCautionLogin.Text = "!";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(356, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "!";
            // 
            // btEnter
            // 
            this.btEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnter.Location = new System.Drawing.Point(165, 269);
            this.btEnter.Name = "btEnter";
            this.btEnter.Size = new System.Drawing.Size(115, 36);
            this.btEnter.TabIndex = 3;
            this.btEnter.Text = "Enter";
            this.btEnter.UseVisualStyleBackColor = true;
            this.btEnter.Click += new System.EventHandler(this.btEnter_Click);
            // 
            // btExit
            // 
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(165, 311);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(115, 36);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(457, 377);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCautionLogin);
            this.Controls.Add(this.lbWarningWrongData);
            this.Controls.Add(this.lbEnterData);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lbWelcomeText);
            this.Name = "WelcomeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWelcomeText;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbEnterData;
        private System.Windows.Forms.Label lbWarningWrongData;
        private System.Windows.Forms.Label lbCautionLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btEnter;
        private System.Windows.Forms.Button btExit;
    }
}

