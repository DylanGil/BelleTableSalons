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
            this.buttonSuppParticipant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Departement :";
            // 
            // tbDpt
            // 
            this.tbDpt.Location = new System.Drawing.Point(177, 141);
            this.tbDpt.Name = "tbDpt";
            this.tbDpt.Size = new System.Drawing.Size(198, 20);
            this.tbDpt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Email :";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(177, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(198, 20);
            this.tbEmail.TabIndex = 4;
            // 
            // buttonPDF
            // 
            this.buttonPDF.BackColor = System.Drawing.Color.MintCream;
            this.buttonPDF.Location = new System.Drawing.Point(188, 311);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(127, 27);
            this.buttonPDF.TabIndex = 6;
            this.buttonPDF.Text = "Generer un badge";
            this.buttonPDF.UseVisualStyleBackColor = false;
            this.buttonPDF.Visible = false;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(80, 91);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(87, 24);
            this.labelPrenom.TabIndex = 44;
            this.labelPrenom.Text = "Prenom :";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(177, 95);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(198, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MintCream;
            this.addButton.Location = new System.Drawing.Point(258, 263);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 28);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.Location = new System.Drawing.Point(106, 50);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(61, 24);
            this.nomLabel.TabIndex = 41;
            this.nomLabel.Text = "Nom :";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(177, 50);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(198, 20);
            this.tbNom.TabIndex = 1;
            // 
            // buttonSuppParticipant
            // 
            this.buttonSuppParticipant.BackColor = System.Drawing.Color.MintCream;
            this.buttonSuppParticipant.Location = new System.Drawing.Point(155, 263);
            this.buttonSuppParticipant.Name = "buttonSuppParticipant";
            this.buttonSuppParticipant.Size = new System.Drawing.Size(97, 28);
            this.buttonSuppParticipant.TabIndex = 48;
            this.buttonSuppParticipant.Text = "Supprimer";
            this.buttonSuppParticipant.UseVisualStyleBackColor = false;
            this.buttonSuppParticipant.Visible = false;
            this.buttonSuppParticipant.Click += new System.EventHandler(this.buttonSuppParticipant_Click);
            // 
            // AddParticipant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 378);
            this.Controls.Add(this.buttonSuppParticipant);
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
        private System.Windows.Forms.Button buttonSuppParticipant;
    }
}