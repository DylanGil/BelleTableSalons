namespace ppe1
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.dtLog = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtUser = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgEchec = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgRemarques = new System.Windows.Forms.DataGridView();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonAddSalon = new System.Windows.Forms.Button();
            this.indexSalons = new System.Windows.Forms.TabPage();
            this.dtSalons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtLog)).BeginInit();
            this.tabPages.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEchec)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRemarques)).BeginInit();
            this.indexSalons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalons)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLog
            // 
            this.dtLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLog.Location = new System.Drawing.Point(0, 0);
            this.dtLog.Name = "dtLog";
            this.dtLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLog.Size = new System.Drawing.Size(775, 313);
            this.dtLog.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vos informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.tabPage3);
            this.tabPages.Controls.Add(this.tabPage1);
            this.tabPages.Controls.Add(this.tabPage2);
            this.tabPages.Controls.Add(this.tabPage4);
            this.tabPages.Controls.Add(this.indexSalons);
            this.tabPages.Location = new System.Drawing.Point(12, 41);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(785, 335);
            this.tabPages.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(777, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "User";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtUser
            // 
            this.dtUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUser.Location = new System.Drawing.Point(1, 0);
            this.dtUser.Name = "dtUser";
            this.dtUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtUser.Size = new System.Drawing.Size(776, 309);
            this.dtUser.TabIndex = 1;
            this.dtUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtUser_CellDoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgEchec);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Echec";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgEchec
            // 
            this.dgEchec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEchec.Location = new System.Drawing.Point(0, 0);
            this.dgEchec.Name = "dgEchec";
            this.dgEchec.Size = new System.Drawing.Size(719, 295);
            this.dgEchec.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgRemarques);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(777, 309);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Remarques";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgRemarques
            // 
            this.dgRemarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRemarques.Location = new System.Drawing.Point(2, 0);
            this.dgRemarques.Name = "dgRemarques";
            this.dgRemarques.Size = new System.Drawing.Size(719, 295);
            this.dgRemarques.TabIndex = 4;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(485, 12);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(124, 23);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = "Ajouter un utilisateur";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonAddSalon
            // 
            this.buttonAddSalon.Location = new System.Drawing.Point(144, 12);
            this.buttonAddSalon.Name = "buttonAddSalon";
            this.buttonAddSalon.Size = new System.Drawing.Size(124, 23);
            this.buttonAddSalon.TabIndex = 4;
            this.buttonAddSalon.Text = "Créer un salon";
            this.buttonAddSalon.UseVisualStyleBackColor = true;
            this.buttonAddSalon.Click += new System.EventHandler(this.buttonAddSalon_Click);
            // 
            // indexSalons
            // 
            this.indexSalons.Controls.Add(this.dtSalons);
            this.indexSalons.Location = new System.Drawing.Point(4, 22);
            this.indexSalons.Name = "indexSalons";
            this.indexSalons.Size = new System.Drawing.Size(777, 309);
            this.indexSalons.TabIndex = 3;
            this.indexSalons.Text = "Salons";
            this.indexSalons.UseVisualStyleBackColor = true;
            // 
            // dtSalons
            // 
            this.dtSalons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSalons.Location = new System.Drawing.Point(0, 0);
            this.dtSalons.Name = "dtSalons";
            this.dtSalons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSalons.Size = new System.Drawing.Size(776, 309);
            this.dtSalons.TabIndex = 2;
            this.dtSalons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSalons_CellDoubleClick);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 388);
            this.Controls.Add(this.buttonAddSalon);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dtLog)).EndInit();
            this.tabPages.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtUser)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEchec)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRemarques)).EndInit();
            this.indexSalons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSalons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgEchec;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dtUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgRemarques;
        private System.Windows.Forms.Button buttonAddSalon;
        private System.Windows.Forms.TabPage indexSalons;
        private System.Windows.Forms.DataGridView dtSalons;
    }
}