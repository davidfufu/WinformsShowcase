
namespace DatabaseProject
{
    partial class HomePage
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountryHome = new System.Windows.Forms.ComboBox();
            this.txtPasswordHome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmailHome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameHome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 31);
            this.label5.TabIndex = 16;
            this.label5.Text = "Country:";
            // 
            // txtCountryHome
            // 
            this.txtCountryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountryHome.FormattingEnabled = true;
            this.txtCountryHome.Items.AddRange(new object[] {
            "US",
            "Canada",
            "China",
            "Japan"});
            this.txtCountryHome.Location = new System.Drawing.Point(201, 394);
            this.txtCountryHome.Name = "txtCountryHome";
            this.txtCountryHome.Size = new System.Drawing.Size(287, 33);
            this.txtCountryHome.TabIndex = 15;
            // 
            // txtPasswordHome
            // 
            this.txtPasswordHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordHome.Location = new System.Drawing.Point(201, 341);
            this.txtPasswordHome.Name = "txtPasswordHome";
            this.txtPasswordHome.Size = new System.Drawing.Size(287, 30);
            this.txtPasswordHome.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password: ";
            // 
            // txtEmailHome
            // 
            this.txtEmailHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailHome.Location = new System.Drawing.Point(201, 287);
            this.txtEmailHome.Name = "txtEmailHome";
            this.txtEmailHome.Size = new System.Drawing.Size(287, 30);
            this.txtEmailHome.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email:";
            // 
            // txtNameHome
            // 
            this.txtNameHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameHome.Location = new System.Drawing.Point(201, 228);
            this.txtNameHome.Name = "txtNameHome";
            this.txtNameHome.Size = new System.Drawing.Size(287, 30);
            this.txtNameHome.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(201, 447);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(287, 42);
            this.btnUpdateInfo.TabIndex = 17;
            this.btnUpdateInfo.Text = "Update Account Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Change Account Settings";
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(569, 191);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(287, 222);
            this.btnDeleteAccount.TabIndex = 19;
            this.btnDeleteAccount.Text = "Delete My Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.Location = new System.Drawing.Point(272, 29);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(274, 31);
            this.lblWelcomeName.TabIndex = 20;
            this.lblWelcomeName.Text = "Welcome Username";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 527);
            this.Controls.Add(this.lblWelcomeName);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountryHome);
            this.Controls.Add(this.txtPasswordHome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmailHome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameHome);
            this.Controls.Add(this.label2);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtCountryHome;
        private System.Windows.Forms.TextBox txtPasswordHome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmailHome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Label lblWelcomeName;
    }
}