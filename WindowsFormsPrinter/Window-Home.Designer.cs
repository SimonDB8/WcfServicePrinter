
namespace WindowsFormsPrinter
{
    partial class homeUser
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
            this.userIdBox = new System.Windows.Forms.TextBox();
            this.resultAmount = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.userPage = new System.Windows.Forms.Button();
            this.adminPage = new System.Windows.Forms.Button();
            this.payOnlinePage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreImperssionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.getAmountByUsernameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userIdBox
            // 
            this.userIdBox.Location = new System.Drawing.Point(137, 75);
            this.userIdBox.Name = "userIdBox";
            this.userIdBox.Size = new System.Drawing.Size(262, 35);
            this.userIdBox.TabIndex = 2;
            // 
            // resultAmount
            // 
            this.resultAmount.Location = new System.Drawing.Point(267, 180);
            this.resultAmount.Name = "resultAmount";
            this.resultAmount.Size = new System.Drawing.Size(132, 35);
            this.resultAmount.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchButton.Location = new System.Drawing.Point(466, 67);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(180, 51);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Chercher";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // userPage
            // 
            this.userPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userPage.Location = new System.Drawing.Point(39, 556);
            this.userPage.Name = "userPage";
            this.userPage.Size = new System.Drawing.Size(211, 78);
            this.userPage.TabIndex = 5;
            this.userPage.Text = "User";
            this.userPage.UseVisualStyleBackColor = false;
            this.userPage.Click += new System.EventHandler(this.userPage_Click);
            // 
            // adminPage
            // 
            this.adminPage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.adminPage.Location = new System.Drawing.Point(314, 556);
            this.adminPage.Name = "adminPage";
            this.adminPage.Size = new System.Drawing.Size(211, 78);
            this.adminPage.TabIndex = 6;
            this.adminPage.Text = "Administration";
            this.adminPage.UseVisualStyleBackColor = false;
            this.adminPage.Click += new System.EventHandler(this.adminPage_Click);
            // 
            // payOnlinePage
            // 
            this.payOnlinePage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.payOnlinePage.Location = new System.Drawing.Point(587, 556);
            this.payOnlinePage.Name = "payOnlinePage";
            this.payOnlinePage.Size = new System.Drawing.Size(211, 78);
            this.payOnlinePage.TabIndex = 7;
            this.payOnlinePage.Text = "PayOnline";
            this.payOnlinePage.UseVisualStyleBackColor = false;
            this.payOnlinePage.Click += new System.EventHandler(this.payOnlinePage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "UID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Crédit disponible";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre d\'impression";
            // 
            // nombreImperssionBox
            // 
            this.nombreImperssionBox.Location = new System.Drawing.Point(314, 254);
            this.nombreImperssionBox.Name = "nombreImperssionBox";
            this.nombreImperssionBox.Size = new System.Drawing.Size(85, 35);
            this.nombreImperssionBox.TabIndex = 11;
            this.nombreImperssionBox.TextChanged += new System.EventHandler(this.nombreImperssionBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "UserName";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // getAmountByUsernameBox
            // 
            this.getAmountByUsernameBox.Location = new System.Drawing.Point(211, 128);
            this.getAmountByUsernameBox.Name = "getAmountByUsernameBox";
            this.getAmountByUsernameBox.Size = new System.Drawing.Size(167, 35);
            this.getAmountByUsernameBox.TabIndex = 13;
            // 
            // homeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 654);
            this.Controls.Add(this.getAmountByUsernameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nombreImperssionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payOnlinePage);
            this.Controls.Add(this.adminPage);
            this.Controls.Add(this.userPage);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.resultAmount);
            this.Controls.Add(this.userIdBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "homeUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.homeUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userIdBox;
        private System.Windows.Forms.TextBox resultAmount;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button userPage;
        private System.Windows.Forms.Button adminPage;
        private System.Windows.Forms.Button payOnlinePage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreImperssionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox getAmountByUsernameBox;
    }
}