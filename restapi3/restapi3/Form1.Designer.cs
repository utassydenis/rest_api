namespace restapi3
{
    partial class Form1
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
            this.listAllBtn = new System.Windows.Forms.Button();
            this.listByIdBtn = new System.Windows.Forms.Button();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.createNewBtn = new System.Windows.Forms.Button();
            this.deleteByIdBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.salaryTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.tokenLbl = new System.Windows.Forms.Label();
            this.logoutBrn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listAllBtn
            // 
            this.listAllBtn.Location = new System.Drawing.Point(12, 25);
            this.listAllBtn.Name = "listAllBtn";
            this.listAllBtn.Size = new System.Drawing.Size(75, 23);
            this.listAllBtn.TabIndex = 1;
            this.listAllBtn.Text = "GET";
            this.listAllBtn.UseVisualStyleBackColor = true;
            this.listAllBtn.Click += new System.EventHandler(this.listAllBtn_Click);
            // 
            // listByIdBtn
            // 
            this.listByIdBtn.Location = new System.Drawing.Point(12, 70);
            this.listByIdBtn.Name = "listByIdBtn";
            this.listByIdBtn.Size = new System.Drawing.Size(75, 23);
            this.listByIdBtn.TabIndex = 2;
            this.listByIdBtn.Text = "GET + id";
            this.listByIdBtn.UseVisualStyleBackColor = true;
            this.listByIdBtn.Click += new System.EventHandler(this.listByIdBtn_Click);
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(226, 28);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 20);
            this.idTxtBox.TabIndex = 3;
            // 
            // createNewBtn
            // 
            this.createNewBtn.Location = new System.Drawing.Point(238, 138);
            this.createNewBtn.Name = "createNewBtn";
            this.createNewBtn.Size = new System.Drawing.Size(75, 23);
            this.createNewBtn.TabIndex = 5;
            this.createNewBtn.Text = "New";
            this.createNewBtn.UseVisualStyleBackColor = true;
            this.createNewBtn.Click += new System.EventHandler(this.createNewBtn_Click);
            // 
            // deleteByIdBtn
            // 
            this.deleteByIdBtn.Location = new System.Drawing.Point(12, 108);
            this.deleteByIdBtn.Name = "deleteByIdBtn";
            this.deleteByIdBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteByIdBtn.TabIndex = 6;
            this.deleteByIdBtn.Text = "DELETE";
            this.deleteByIdBtn.UseVisualStyleBackColor = true;
            this.deleteByIdBtn.Click += new System.EventHandler(this.deleteByIdBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(12, 148);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(89, 27);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Módosít (PUT)";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(345, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(226, 59);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 20);
            this.nameTxtBox.TabIndex = 10;
            // 
            // salaryTxtBox
            // 
            this.salaryTxtBox.Location = new System.Drawing.Point(226, 85);
            this.salaryTxtBox.Name = "salaryTxtBox";
            this.salaryTxtBox.Size = new System.Drawing.Size(100, 20);
            this.salaryTxtBox.TabIndex = 11;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(226, 112);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(100, 20);
            this.ageTxtBox.TabIndex = 12;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(187, 327);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTxtBox.TabIndex = 13;
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(187, 301);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userTxtBox.TabIndex = 14;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(12, 313);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 15;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // tokenLbl
            // 
            this.tokenLbl.AutoSize = true;
            this.tokenLbl.Location = new System.Drawing.Point(454, 375);
            this.tokenLbl.Name = "tokenLbl";
            this.tokenLbl.Size = new System.Drawing.Size(35, 13);
            this.tokenLbl.TabIndex = 16;
            this.tokenLbl.Text = "label1";
            // 
            // logoutBrn
            // 
            this.logoutBrn.Location = new System.Drawing.Point(12, 362);
            this.logoutBrn.Name = "logoutBrn";
            this.logoutBrn.Size = new System.Drawing.Size(75, 23);
            this.logoutBrn.TabIndex = 17;
            this.logoutBrn.Text = "Logout";
            this.logoutBrn.UseVisualStyleBackColor = true;
            this.logoutBrn.Click += new System.EventHandler(this.logoutBrn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 397);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutBrn);
            this.Controls.Add(this.tokenLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.salaryTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteByIdBtn);
            this.Controls.Add(this.createNewBtn);
            this.Controls.Add(this.idTxtBox);
            this.Controls.Add(this.listByIdBtn);
            this.Controls.Add(this.listAllBtn);
            this.Name = "Form1";
            this.Text = "REST client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listAllBtn;
        private System.Windows.Forms.Button listByIdBtn;
        private System.Windows.Forms.TextBox idTxtBox;
        private System.Windows.Forms.Button createNewBtn;
        private System.Windows.Forms.Button deleteByIdBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox salaryTxtBox;
        private System.Windows.Forms.TextBox ageTxtBox;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label tokenLbl;
        private System.Windows.Forms.Button logoutBrn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

