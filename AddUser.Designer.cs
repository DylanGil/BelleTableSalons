namespace ppe1
{
    partial class AddUser
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
            this.addButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbInvite = new System.Windows.Forms.RadioButton();
            this.rbUtilisateur = new System.Windows.Forms.RadioButton();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(354, 271);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(287, 159);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Mot de passe :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(289, 67);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(35, 13);
            this.nomLabel.TabIndex = 10;
            this.nomLabel.Text = "Nom :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(370, 156);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(198, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(370, 67);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(198, 20);
            this.tbNom.TabIndex = 1;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(290, 215);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 4;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbInvite
            // 
            this.rbInvite.AutoSize = true;
            this.rbInvite.Checked = true;
            this.rbInvite.Location = new System.Drawing.Point(460, 215);
            this.rbInvite.Name = "rbInvite";
            this.rbInvite.Size = new System.Drawing.Size(51, 17);
            this.rbInvite.TabIndex = 6;
            this.rbInvite.TabStop = true;
            this.rbInvite.Text = "Invite";
            this.rbInvite.UseVisualStyleBackColor = true;
            // 
            // rbUtilisateur
            // 
            this.rbUtilisateur.AutoSize = true;
            this.rbUtilisateur.Location = new System.Drawing.Point(369, 215);
            this.rbUtilisateur.Name = "rbUtilisateur";
            this.rbUtilisateur.Size = new System.Drawing.Size(71, 17);
            this.rbUtilisateur.TabIndex = 5;
            this.rbUtilisateur.Text = "Utilisateur";
            this.rbUtilisateur.UseVisualStyleBackColor = true;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(289, 112);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 27;
            this.labelPrenom.Text = "Prenom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(370, 112);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(198, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbInvite);
            this.Controls.Add(this.rbUtilisateur);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNom);
            this.Name = "AddUser";
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbInvite;
        private System.Windows.Forms.RadioButton rbUtilisateur;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
    }
}