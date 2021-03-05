namespace ppe1
{
    partial class ChangeUser
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
            this.labelNom = new System.Windows.Forms.Label();
            this.buttonMAJ = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.dgUser = new System.Windows.Forms.DataGridView();
            this.rbUtilisateur = new System.Windows.Forms.RadioButton();
            this.rbInvite = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.buttonChangeMdp = new System.Windows.Forms.Button();
            this.tbChangeMdp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(66, 12);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(35, 13);
            this.labelNom.TabIndex = 15;
            this.labelNom.Text = "Nom :";
            // 
            // buttonMAJ
            // 
            this.buttonMAJ.Location = new System.Drawing.Point(233, 93);
            this.buttonMAJ.Name = "buttonMAJ";
            this.buttonMAJ.Size = new System.Drawing.Size(82, 23);
            this.buttonMAJ.TabIndex = 14;
            this.buttonMAJ.Text = "Mettre à jour";
            this.buttonMAJ.UseVisualStyleBackColor = true;
            this.buttonMAJ.Click += new System.EventHandler(this.buttonMAJ_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(117, 12);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(198, 20);
            this.tbNom.TabIndex = 12;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(52, 52);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 18;
            this.labelPrenom.Text = "Prenom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(117, 52);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(198, 20);
            this.tbPrenom.TabIndex = 17;
            // 
            // dgUser
            // 
            this.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUser.Location = new System.Drawing.Point(12, 199);
            this.dgUser.Name = "dgUser";
            this.dgUser.Size = new System.Drawing.Size(776, 239);
            this.dgUser.TabIndex = 19;
            // 
            // rbUtilisateur
            // 
            this.rbUtilisateur.AutoSize = true;
            this.rbUtilisateur.Location = new System.Drawing.Point(173, 140);
            this.rbUtilisateur.Name = "rbUtilisateur";
            this.rbUtilisateur.Size = new System.Drawing.Size(71, 17);
            this.rbUtilisateur.TabIndex = 20;
            this.rbUtilisateur.Text = "Utilisateur";
            this.rbUtilisateur.UseVisualStyleBackColor = true;
            // 
            // rbInvite
            // 
            this.rbInvite.AutoSize = true;
            this.rbInvite.Location = new System.Drawing.Point(264, 140);
            this.rbInvite.Name = "rbInvite";
            this.rbInvite.Size = new System.Drawing.Size(51, 17);
            this.rbInvite.TabIndex = 21;
            this.rbInvite.Text = "Invite";
            this.rbInvite.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(94, 140);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rbAdmin.TabIndex = 22;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonChangeMdp
            // 
            this.buttonChangeMdp.Location = new System.Drawing.Point(382, 53);
            this.buttonChangeMdp.Name = "buttonChangeMdp";
            this.buttonChangeMdp.Size = new System.Drawing.Size(131, 23);
            this.buttonChangeMdp.TabIndex = 23;
            this.buttonChangeMdp.Text = "Modifier le mdp";
            this.buttonChangeMdp.UseVisualStyleBackColor = true;
            this.buttonChangeMdp.Click += new System.EventHandler(this.buttonChangeMdp_Click);
            // 
            // tbChangeMdp
            // 
            this.tbChangeMdp.Location = new System.Drawing.Point(519, 53);
            this.tbChangeMdp.Name = "tbChangeMdp";
            this.tbChangeMdp.Size = new System.Drawing.Size(198, 20);
            this.tbChangeMdp.TabIndex = 24;
            this.tbChangeMdp.Visible = false;
            // 
            // ChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbChangeMdp);
            this.Controls.Add(this.buttonChangeMdp);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbInvite);
            this.Controls.Add(this.rbUtilisateur);
            this.Controls.Add(this.dgUser);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonMAJ);
            this.Controls.Add(this.tbNom);
            this.Name = "ChangeUser";
            this.Text = "ChangeUser";
            ((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Button buttonMAJ;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.RadioButton rbUtilisateur;
        private System.Windows.Forms.RadioButton rbInvite;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.Button buttonChangeMdp;
        private System.Windows.Forms.TextBox tbChangeMdp;
    }
}