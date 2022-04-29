
namespace WindowsFormsPrinter
{
    partial class payOnline
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
            this.label2 = new System.Windows.Forms.Label();
            this.PayOnlineUsernameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PayOnlineAmountBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PayOnlineNewAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // PayOnlineUsernameBox
            // 
            this.PayOnlineUsernameBox.Location = new System.Drawing.Point(263, 179);
            this.PayOnlineUsernameBox.Name = "PayOnlineUsernameBox";
            this.PayOnlineUsernameBox.Size = new System.Drawing.Size(405, 35);
            this.PayOnlineUsernameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Montant";
            // 
            // PayOnlineAmountBox
            // 
            this.PayOnlineAmountBox.Location = new System.Drawing.Point(263, 256);
            this.PayOnlineAmountBox.Name = "PayOnlineAmountBox";
            this.PayOnlineAmountBox.Size = new System.Drawing.Size(405, 35);
            this.PayOnlineAmountBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(472, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 80);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 49);
            this.label6.TabIndex = 17;
            this.label6.Text = "PayOnline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nouveau montant disponible";
            // 
            // PayOnlineNewAmount
            // 
            this.PayOnlineNewAmount.Location = new System.Drawing.Point(458, 499);
            this.PayOnlineNewAmount.Name = "PayOnlineNewAmount";
            this.PayOnlineNewAmount.Size = new System.Drawing.Size(196, 35);
            this.PayOnlineNewAmount.TabIndex = 19;
            // 
            // payOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 654);
            this.Controls.Add(this.PayOnlineNewAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PayOnlineAmountBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayOnlineUsernameBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "payOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayOnline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PayOnlineUsernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PayOnlineAmountBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PayOnlineNewAmount;
    }
}