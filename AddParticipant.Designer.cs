namespace ppe1
{
    partial class AddParticipant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParticipant));
            this.label2 = new System.Windows.Forms.Label();
            this.tbDpt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.nomLabel = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Departement :";
            // 
            // tbDpt
            // 
            this.tbDpt.Location = new System.Drawing.Point(177, 141);
            this.tbDpt.Name = "tbDpt";
            this.tbDpt.Size = new System.Drawing.Size(198, 20);
            this.tbDpt.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Email :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(177, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(198, 20);
            this.tbEmail.TabIndex = 35;
            // 
            // buttonPDF
            // 
            this.buttonPDF.Location = new System.Drawing.Point(207, 311);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(97, 23);
            this.buttonPDF.TabIndex = 45;
            this.buttonPDF.Text = "Generer PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(102, 98);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPrenom.TabIndex = 44;
            this.labelPrenom.Text = "Prenom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(177, 95);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(198, 20);
            this.tbPrenom.TabIndex = 34;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(217, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 43;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.Location = new System.Drawing.Point(116, 50);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(35, 13);
            this.nomLabel.TabIndex = 41;
            this.nomLabel.Text = "Nom :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(177, 50);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(198, 20);
            this.tbNom.TabIndex = 33;
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 378);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDpt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.tbNom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddParticipant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddParticipant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDpt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox tbNom;
    }
}