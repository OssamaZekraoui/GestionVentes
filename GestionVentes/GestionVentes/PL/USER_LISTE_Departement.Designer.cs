﻿namespace GestionVentes.PL
{
    partial class USER_LISTE_Departement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dvgdep = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textrecherche = new System.Windows.Forms.TextBox();
            this.btnsupprimercat = new System.Windows.Forms.Button();
            this.btnmodifiercat = new System.Windows.Forms.Button();
            this.btnajouterCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdep)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgdep
            // 
            this.dvgdep.AllowUserToAddRows = false;
            this.dvgdep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgdep.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgdep.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(16)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgdep.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Column2});
            this.dvgdep.EnableHeadersVisualStyles = false;
            this.dvgdep.Location = new System.Drawing.Point(18, 168);
            this.dvgdep.Name = "dvgdep";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgdep.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgdep.RowHeadersVisible = false;
            this.dvgdep.RowHeadersWidth = 51;
            this.dvgdep.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dvgdep.RowTemplate.Height = 24;
            this.dvgdep.Size = new System.Drawing.Size(1002, 357);
            this.dvgdep.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(16)))), ((int)(((byte)(27)))));
            this.panel3.Location = new System.Drawing.Point(71, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(791, 3);
            this.panel3.TabIndex = 28;
            // 
            // textrecherche
            // 
            this.textrecherche.BackColor = System.Drawing.SystemColors.Control;
            this.textrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textrecherche.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textrecherche.ForeColor = System.Drawing.Color.Gray;
            this.textrecherche.Location = new System.Drawing.Point(71, 84);
            this.textrecherche.Multiline = true;
            this.textrecherche.Name = "textrecherche";
            this.textrecherche.Size = new System.Drawing.Size(791, 41);
            this.textrecherche.TabIndex = 27;
            this.textrecherche.Text = "Rechercher";
            this.textrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textrecherche.Enter += new System.EventHandler(this.textrecherche_Enter);
            // 
            // btnsupprimercat
            // 
            this.btnsupprimercat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimercat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(16)))), ((int)(((byte)(27)))));
            this.btnsupprimercat.FlatAppearance.BorderSize = 0;
            this.btnsupprimercat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimercat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimercat.ForeColor = System.Drawing.Color.Snow;
            this.btnsupprimercat.Image = global::GestionVentes.Properties.Resources.Close_2_icon1;
            this.btnsupprimercat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimercat.Location = new System.Drawing.Point(737, 14);
            this.btnsupprimercat.Name = "btnsupprimercat";
            this.btnsupprimercat.Size = new System.Drawing.Size(258, 53);
            this.btnsupprimercat.TabIndex = 32;
            this.btnsupprimercat.Text = "Supprimer";
            this.btnsupprimercat.UseVisualStyleBackColor = false;
            // 
            // btnmodifiercat
            // 
            this.btnmodifiercat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnmodifiercat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(16)))), ((int)(((byte)(27)))));
            this.btnmodifiercat.FlatAppearance.BorderSize = 0;
            this.btnmodifiercat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifiercat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifiercat.ForeColor = System.Drawing.Color.Snow;
            this.btnmodifiercat.Image = global::GestionVentes.Properties.Resources.Recycle_iconaaa1;
            this.btnmodifiercat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifiercat.Location = new System.Drawing.Point(381, 14);
            this.btnmodifiercat.Name = "btnmodifiercat";
            this.btnmodifiercat.Size = new System.Drawing.Size(253, 53);
            this.btnmodifiercat.TabIndex = 31;
            this.btnmodifiercat.Text = "Modifier";
            this.btnmodifiercat.UseVisualStyleBackColor = false;
            this.btnmodifiercat.Click += new System.EventHandler(this.btnmodifiercat_Click);
            // 
            // btnajouterCat
            // 
            this.btnajouterCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(16)))), ((int)(((byte)(27)))));
            this.btnajouterCat.FlatAppearance.BorderSize = 0;
            this.btnajouterCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouterCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouterCat.ForeColor = System.Drawing.Color.Snow;
            this.btnajouterCat.Image = global::GestionVentes.Properties.Resources.Actions_list_add_icon1;
            this.btnajouterCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouterCat.Location = new System.Drawing.Point(18, 14);
            this.btnajouterCat.Name = "btnajouterCat";
            this.btnajouterCat.Size = new System.Drawing.Size(251, 53);
            this.btnajouterCat.TabIndex = 30;
            this.btnajouterCat.Text = "Ajouter";
            this.btnajouterCat.UseVisualStyleBackColor = false;
            this.btnajouterCat.Click += new System.EventHandler(this.btnajouterCat_Click);
            // 
            // USER_LISTE_Departement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsupprimercat);
            this.Controls.Add(this.btnmodifiercat);
            this.Controls.Add(this.btnajouterCat);
            this.Controls.Add(this.dvgdep);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textrecherche);
            this.Name = "USER_LISTE_Departement";
            this.Size = new System.Drawing.Size(1222, 720);
            this.Load += new System.EventHandler(this.USER_LISTE_Departement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsupprimercat;
        private System.Windows.Forms.Button btnmodifiercat;
        private System.Windows.Forms.Button btnajouterCat;
        private System.Windows.Forms.DataGridView dvgdep;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textrecherche;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
