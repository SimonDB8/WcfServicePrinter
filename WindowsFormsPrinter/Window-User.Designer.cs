
namespace WindowsFormsPrinter
{
    partial class user
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
            this.AddAmountByUserIdButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UID = new System.Windows.Forms.Label();
            this.AmountBox = new System.Windows.Forms.TextBox();
            this.UserIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewAmountBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddAmountByUserIdButton
            // 
            this.AddAmountByUserIdButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddAmountByUserIdButton.Location = new System.Drawing.Point(430, 419);
            this.AddAmountByUserIdButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddAmountByUserIdButton.Name = "AddAmountByUserIdButton";
            this.AddAmountByUserIdButton.Size = new System.Drawing.Size(182, 80);
            this.AddAmountByUserIdButton.TabIndex = 10;
            this.AddAmountByUserIdButton.Text = "Ajouter";
            this.AddAmountByUserIdButton.UseVisualStyleBackColor = false;
            this.AddAmountByUserIdButton.Click += new System.EventHandler(this.AddAmountByUserIdButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 306);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Montant";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UID
            // 
            this.UID.AutoSize = true;
            this.UID.Location = new System.Drawing.Point(202, 171);
            this.UID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(53, 29);
            this.UID.TabIndex = 8;
            this.UID.Text = "UID";
            this.UID.Click += new System.EventHandler(this.label2_Click);
            // 
            // AmountBox
            // 
            this.AmountBox.Location = new System.Drawing.Point(207, 340);
            this.AmountBox.Margin = new System.Windows.Forms.Padding(5);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(405, 35);
            this.AmountBox.TabIndex = 7;
            this.AmountBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserIdBox
            // 
            this.UserIdBox.Location = new System.Drawing.Point(207, 205);
            this.UserIdBox.Margin = new System.Windows.Forms.Padding(5);
            this.UserIdBox.Name = "UserIdBox";
            this.UserIdBox.Size = new System.Drawing.Size(405, 35);
            this.UserIdBox.TabIndex = 6;
            this.UserIdBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nouveau montant disponible";
            // 
            // NewAmountBox
            // 
            this.NewAmountBox.Location = new System.Drawing.Point(207, 583);
            this.NewAmountBox.Name = "NewAmountBox";
            this.NewAmountBox.Size = new System.Drawing.Size(405, 35);
            this.NewAmountBox.TabIndex = 12;
            this.NewAmountBox.TextChanged += new System.EventHandler(this.NewAmountBox_TextChanged);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 654);
            this.Controls.Add(this.NewAmountBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAmountByUserIdButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.AmountBox);
            this.Controls.Add(this.UserIdBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddAmountByUserIdButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UID;
        private System.Windows.Forms.TextBox AmountBox;
        private System.Windows.Forms.TextBox UserIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewAmountBox;
    }
}