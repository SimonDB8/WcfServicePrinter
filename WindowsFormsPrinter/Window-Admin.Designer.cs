
namespace WindowsFormsPrinter
{
    partial class administration
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameAdminBox = new System.Windows.Forms.TextBox();
            this.AdminAmountBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddAmountByUsernameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminNewAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameAdminBox
            // 
            this.usernameAdminBox.Location = new System.Drawing.Point(207, 215);
            this.usernameAdminBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameAdminBox.Name = "usernameAdminBox";
            this.usernameAdminBox.Size = new System.Drawing.Size(405, 35);
            this.usernameAdminBox.TabIndex = 1;
            // 
            // AdminAmountBox
            // 
            this.AdminAmountBox.Location = new System.Drawing.Point(207, 359);
            this.AdminAmountBox.Margin = new System.Windows.Forms.Padding(5);
            this.AdminAmountBox.Name = "AdminAmountBox";
            this.AdminAmountBox.Size = new System.Drawing.Size(405, 35);
            this.AdminAmountBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 312);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Montant";
            // this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // AddAmountByUsernameButton
            // 
            this.AddAmountByUsernameButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddAmountByUsernameButton.Location = new System.Drawing.Point(430, 428);
            this.AddAmountByUsernameButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddAmountByUsernameButton.Name = "AddAmountByUsernameButton";
            this.AddAmountByUsernameButton.Size = new System.Drawing.Size(182, 80);
            this.AddAmountByUsernameButton.TabIndex = 5;
            this.AddAmountByUsernameButton.Text = "Ajouter";
            this.AddAmountByUsernameButton.UseVisualStyleBackColor = false;
            this.AddAmountByUsernameButton.Click += new System.EventHandler(this.AddAmountByUsernameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nouveau montant disponible";
            // 
            // AdminNewAmount
            // 
            this.AdminNewAmount.Location = new System.Drawing.Point(207, 589);
            this.AdminNewAmount.Name = "AdminNewAmount";
            this.AdminNewAmount.Size = new System.Drawing.Size(305, 35);
            this.AdminNewAmount.TabIndex = 7;
            // 
            // administration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(836, 654);
            this.Controls.Add(this.AdminNewAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddAmountByUsernameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdminAmountBox);
            this.Controls.Add(this.usernameAdminBox);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "administration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameAdminBox;
        private System.Windows.Forms.TextBox AdminAmountBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddAmountByUsernameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AdminNewAmount;
    }
}

