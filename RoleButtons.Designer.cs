namespace ppe1
{
    partial class RoleButtons
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
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonUtilisateur = new System.Windows.Forms.Button();
            this.buttonInvite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(30, 94);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(75, 23);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Visible = false;
            // 
            // buttonUtilisateur
            // 
            this.buttonUtilisateur.Location = new System.Drawing.Point(136, 94);
            this.buttonUtilisateur.Name = "buttonUtilisateur";
            this.buttonUtilisateur.Size = new System.Drawing.Size(75, 23);
            this.buttonUtilisateur.TabIndex = 1;
            this.buttonUtilisateur.Text = "Utilisateur";
            this.buttonUtilisateur.UseVisualStyleBackColor = true;
            this.buttonUtilisateur.Visible = false;
            // 
            // buttonInvite
            // 
            this.buttonInvite.Location = new System.Drawing.Point(246, 94);
            this.buttonInvite.Name = "buttonInvite";
            this.buttonInvite.Size = new System.Drawing.Size(75, 23);
            this.buttonInvite.TabIndex = 2;
            this.buttonInvite.Text = "Invité";
            this.buttonInvite.UseVisualStyleBackColor = true;
            this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // RoleButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 225);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonInvite);
            this.Controls.Add(this.buttonUtilisateur);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "RoleButtons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vos Boutons";
            this.Load += new System.EventHandler(this.RoleButtons_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonUtilisateur;
        private System.Windows.Forms.Button buttonInvite;
        private System.Windows.Forms.TextBox textBox1;
    }
}