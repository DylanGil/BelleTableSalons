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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.addButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbInvite = new System.Windows.Forms.RadioButton();
            this.rbOperateur = new System.Windows.Forms.RadioButton();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDpt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(354, 344);
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
            this.passwordLabel.Location = new System.Drawing.Point(270, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(77, 13);
            this.passwordLabel.TabIndex = 11;
            this.passwordLabel.Text = "Mot de passe :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(309, 67);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(35, 13);
            this.nomLabel.TabIndex = 10;
            this.nomLabel.Text = "Nom :";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(369, 239);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(198, 20);
            this.tbPassword.TabIndex = 5;
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
            this.rbAdmin.Location = new System.Drawing.Point(290, 288);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 6;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbInvite
            // 
            this.rbInvite.AutoSize = true;
            this.rbInvite.Checked = true;
            this.rbInvite.Location = new System.Drawing.Point(460, 288);
            this.rbInvite.Name = "rbInvite";
            this.rbInvite.Size = new System.Drawing.Size(51, 17);
            this.rbInvite.TabIndex = 6;
            this.rbInvite.TabStop = true;
            this.rbInvite.Text = "Invite";
            this.rbInvite.UseVisualStyleBackColor = true;
            // 
            // rbOperateur
            // 
            this.rbOperateur.AutoSize = true;
            this.rbOperateur.Location = new System.Drawing.Point(369, 288);
            this.rbOperateur.Name = "rbOperateur";
            this.rbOperateur.Size = new System.Drawing.Size(72, 17);
            this.rbOperateur.TabIndex = 5;
            this.rbOperateur.Text = "Opérateur";
            this.rbOperateur.UseVisualStyleBackColor = true;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(295, 115);
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
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(343, 388);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(97, 23);
            this.buttonPDF.TabIndex = 28;
            this.buttonPDF.Text = "Generer PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Email :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(369, 155);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(198, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Departement :";
            // 
            // tbDpt
            // 
            this.tbDpt.Location = new System.Drawing.Point(370, 199);
            this.tbDpt.Name = "tbDpt";
            this.tbDpt.Size = new System.Drawing.Size(198, 20);
            this.tbDpt.TabIndex = 4;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDpt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbInvite);
            this.Controls.Add(this.rbOperateur);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.RadioButton rbOperateur;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDpt;
    }
}