namespace ppe1
{
    partial class AddSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSalon));
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbLieu = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nomLabel = new System.Windows.Forms.Label();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbDateSalon = new System.Windows.Forms.DateTimePicker();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.indexParticipants = new System.Windows.Forms.TabPage();
            this.addParticipantButton = new System.Windows.Forms.Button();
            this.dtParticipants = new System.Windows.Forms.DataGridView();
            this.tabPages.SuspendLayout();
            this.indexParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtParticipants)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.BackColor = System.Drawing.Color.Transparent;
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(318, 101);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(56, 24);
            this.labelPrenom.TabIndex = 38;
            this.labelPrenom.Text = "Lieu :";
            // 
            // tbLieu
            // 
            this.tbLieu.Location = new System.Drawing.Point(397, 101);
            this.tbLieu.Name = "tbLieu";
            this.tbLieu.Size = new System.Drawing.Size(198, 20);
            this.tbLieu.TabIndex = 30;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MintCream;
            this.addButton.Location = new System.Drawing.Point(430, 224);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(102, 34);
            this.addButton.TabIndex = 37;
            this.addButton.Text = "Ajouter";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(316, 146);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(58, 24);
            this.passwordLabel.TabIndex = 36;
            this.passwordLabel.Text = "Date :";
            // 
            // nomLabel
            // 
            this.nomLabel.AutoSize = true;
            this.nomLabel.BackColor = System.Drawing.Color.Transparent;
            this.nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomLabel.Location = new System.Drawing.Point(299, 56);
            this.nomLabel.Name = "nomLabel";
            this.nomLabel.Size = new System.Drawing.Size(75, 24);
            this.nomLabel.TabIndex = 35;
            this.nomLabel.Text = "Libelle :";
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(397, 56);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(198, 20);
            this.tbLibelle.TabIndex = 29;
            // 
            // tbDateSalon
            // 
            this.tbDateSalon.Location = new System.Drawing.Point(395, 148);
            this.tbDateSalon.Name = "tbDateSalon";
            this.tbDateSalon.Size = new System.Drawing.Size(200, 20);
            this.tbDateSalon.TabIndex = 39;
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.indexParticipants);
            this.tabPages.Location = new System.Drawing.Point(12, 291);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(955, 298);
            this.tabPages.TabIndex = 40;
            // 
            // indexParticipants
            // 
            this.indexParticipants.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("indexParticipants.BackgroundImage")));
            this.indexParticipants.Controls.Add(this.addParticipantButton);
            this.indexParticipants.Controls.Add(this.dtParticipants);
            this.indexParticipants.Location = new System.Drawing.Point(4, 22);
            this.indexParticipants.Name = "indexParticipants";
            this.indexParticipants.Size = new System.Drawing.Size(947, 272);
            this.indexParticipants.TabIndex = 2;
            this.indexParticipants.Text = "Participants";
            this.indexParticipants.UseVisualStyleBackColor = true;
            // 
            // addParticipantButton
            // 
            this.addParticipantButton.BackColor = System.Drawing.Color.MintCream;
            this.addParticipantButton.Location = new System.Drawing.Point(3, 3);
            this.addParticipantButton.Name = "addParticipantButton";
            this.addParticipantButton.Size = new System.Drawing.Size(128, 23);
            this.addParticipantButton.TabIndex = 41;
            this.addParticipantButton.Text = "Ajouter un participant";
            this.addParticipantButton.UseVisualStyleBackColor = false;
            this.addParticipantButton.Click += new System.EventHandler(this.addParticipantButton_Click);
            // 
            // dtParticipants
            // 
            this.dtParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtParticipants.Location = new System.Drawing.Point(1, 28);
            this.dtParticipants.Name = "dtParticipants";
            this.dtParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtParticipants.Size = new System.Drawing.Size(943, 244);
            this.dtParticipants.TabIndex = 1;
            this.dtParticipants.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtParticipants_CellDoubleClick);
            // 
            // AddSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(979, 601);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.tbDateSalon);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.tbLieu);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nomLabel);
            this.Controls.Add(this.tbLibelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddSalon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSalon";
            this.tabPages.ResumeLayout(false);
            this.indexParticipants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtParticipants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbLieu;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label nomLabel;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.DateTimePicker tbDateSalon;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage indexParticipants;
        private System.Windows.Forms.DataGridView dtParticipants;
        private System.Windows.Forms.Button addParticipantButton;
    }
}