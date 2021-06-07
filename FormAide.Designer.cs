namespace ppe1
{
    partial class FormAide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAide));
            this.rbEvolution = new System.Windows.Forms.RadioButton();
            this.rbDysfonctionnement = new System.Windows.Forms.RadioButton();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.rtbCommentaire = new System.Windows.Forms.RichTextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbEvolution
            // 
            this.rbEvolution.AutoSize = true;
            this.rbEvolution.Location = new System.Drawing.Point(325, 213);
            this.rbEvolution.Name = "rbEvolution";
            this.rbEvolution.Size = new System.Drawing.Size(69, 17);
            this.rbEvolution.TabIndex = 29;
            this.rbEvolution.Text = "Evolution";
            this.rbEvolution.UseVisualStyleBackColor = true;
            // 
            // rbDysfonctionnement
            // 
            this.rbDysfonctionnement.AutoSize = true;
            this.rbDysfonctionnement.Checked = true;
            this.rbDysfonctionnement.Location = new System.Drawing.Point(161, 213);
            this.rbDysfonctionnement.Name = "rbDysfonctionnement";
            this.rbDysfonctionnement.Size = new System.Drawing.Size(116, 17);
            this.rbDysfonctionnement.TabIndex = 28;
            this.rbDysfonctionnement.TabStop = true;
            this.rbDysfonctionnement.Text = "Dysfonctionnement";
            this.rbDysfonctionnement.UseVisualStyleBackColor = true;
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.AutoSize = true;
            this.labelCommentaire.Location = new System.Drawing.Point(12, 18);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(77, 13);
            this.labelCommentaire.TabIndex = 27;
            this.labelCommentaire.Text = "Commentaire : ";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(274, 278);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(82, 23);
            this.buttonOk.TabIndex = 24;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 213);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(102, 13);
            this.labelType.TabIndex = 30;
            this.labelType.Text = "Type de demande : ";
            // 
            // rtbCommentaire
            // 
            this.rtbCommentaire.Location = new System.Drawing.Point(15, 34);
            this.rtbCommentaire.Name = "rtbCommentaire";
            this.rtbCommentaire.Size = new System.Drawing.Size(455, 150);
            this.rtbCommentaire.TabIndex = 31;
            this.rtbCommentaire.Text = "";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(114, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(82, 23);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 354);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.rtbCommentaire);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.rbEvolution);
            this.Controls.Add(this.rbDysfonctionnement);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.buttonOk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbEvolution;
        private System.Windows.Forms.RadioButton rbDysfonctionnement;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RichTextBox rtbCommentaire;
        private System.Windows.Forms.Button buttonCancel;
    }
}