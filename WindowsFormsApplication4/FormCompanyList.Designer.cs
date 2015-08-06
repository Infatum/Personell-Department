namespace WindowsFormsApplication4
{
    partial class FormCompanyList
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
            this.lbCompanyList = new System.Windows.Forms.ListBox();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.btnDeleteCompany = new System.Windows.Forms.Button();
            this.btnAssignCompany = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDeps = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbCompanyList
            // 
            this.lbCompanyList.FormattingEnabled = true;
            this.lbCompanyList.Location = new System.Drawing.Point(12, 12);
            this.lbCompanyList.Name = "lbCompanyList";
            this.lbCompanyList.Size = new System.Drawing.Size(212, 212);
            this.lbCompanyList.TabIndex = 0;
            this.lbCompanyList.SelectedIndexChanged += new System.EventHandler(this.lbCompany_SelectedIndexChanged);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddCompany.Location = new System.Drawing.Point(230, 12);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(120, 31);
            this.btnAddCompany.TabIndex = 1;
            this.btnAddCompany.Text = "Add...";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnDeleteCompany
            // 
            this.btnDeleteCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDeleteCompany.Location = new System.Drawing.Point(230, 49);
            this.btnDeleteCompany.Name = "btnDeleteCompany";
            this.btnDeleteCompany.Size = new System.Drawing.Size(120, 31);
            this.btnDeleteCompany.TabIndex = 1;
            this.btnDeleteCompany.Text = "Delete...";
            this.btnDeleteCompany.UseVisualStyleBackColor = true;
            this.btnDeleteCompany.Click += new System.EventHandler(this.btnDeleteCompany_Click);
            // 
            // btnAssignCompany
            // 
            this.btnAssignCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssignCompany.Location = new System.Drawing.Point(230, 86);
            this.btnAssignCompany.Name = "btnAssignCompany";
            this.btnAssignCompany.Size = new System.Drawing.Size(120, 31);
            this.btnAssignCompany.TabIndex = 1;
            this.btnAssignCompany.Text = "Assign...";
            this.btnAssignCompany.UseVisualStyleBackColor = true;
            this.btnAssignCompany.Click += new System.EventHandler(this.btnAssignCompany_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lbDeps);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departments";
            // 
            // lbDeps
            // 
            this.lbDeps.FormattingEnabled = true;
            this.lbDeps.Location = new System.Drawing.Point(7, 20);
            this.lbDeps.Name = "lbDeps";
            this.lbDeps.Size = new System.Drawing.Size(205, 134);
            this.lbDeps.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(218, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button2.Location = new System.Drawing.Point(218, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(362, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAssignCompany);
            this.Controls.Add(this.btnDeleteCompany);
            this.Controls.Add(this.btnAddCompany);
            this.Controls.Add(this.lbCompanyList);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "FormCompanyList";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbCompanyList;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.Button btnDeleteCompany;
        private System.Windows.Forms.Button btnAssignCompany;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbDeps;
    }
}