namespace ppe1
{
    partial class FormOperateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperateur));
            this.button1 = new System.Windows.Forms.Button();
            this.tabPages = new System.Windows.Forms.TabControl();
            this.salons = new System.Windows.Forms.TabPage();
            this.dtSalons = new System.Windows.Forms.DataGridView();
            this.tabPages.SuspendLayout();
            this.salons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtSalons)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vos informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.salons);
            this.tabPages.Location = new System.Drawing.Point(21, 75);
            this.tabPages.Name = "tabPages";
            this.tabPages.SelectedIndex = 0;
            this.tabPages.Size = new System.Drawing.Size(785, 335);
            this.tabPages.TabIndex = 3;
            // 
            // salons
            // 
            this.salons.Controls.Add(this.dtSalons);
            this.salons.Location = new System.Drawing.Point(4, 22);
            this.salons.Name = "salons";
            this.salons.Size = new System.Drawing.Size(777, 309);
            this.salons.TabIndex = 2;
            this.salons.Text = "Salons";
            this.salons.UseVisualStyleBackColor = true;
            // 
            // dtSalons
            // 
            this.dtSalons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtSalons.Location = new System.Drawing.Point(1, 0);
            this.dtSalons.Name = "dtSalons";
            this.dtSalons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtSalons.Size = new System.Drawing.Size(776, 309);
            this.dtSalons.TabIndex = 1;
            this.dtSalons.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtSalons_CellDoubleClick);
            // 
            // FormOperateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 460);
            this.Controls.Add(this.tabPages);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOperateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpérateur";
            this.tabPages.ResumeLayout(false);
            this.salons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtSalons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabPages;
        private System.Windows.Forms.TabPage salons;
        private System.Windows.Forms.DataGridView dtSalons;
    }
}