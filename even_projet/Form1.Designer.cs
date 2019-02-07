namespace even_projet
{
    partial class frPersonne
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.txtRelFam = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtNumBureau = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbAmis = new System.Windows.Forms.RadioButton();
            this.rdbTravail = new System.Windows.Forms.RadioButton();
            this.rdbFamille = new System.Windows.Forms.RadioButton();
            this.txtNumTel = new System.Windows.Forms.MaskedTextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.cmbPersonnes = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBureau)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreer);
            this.groupBox1.Controls.Add(this.txtRelFam);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtNumBureau);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdbAmis);
            this.groupBox1.Controls.Add(this.rdbTravail);
            this.groupBox1.Controls.Add(this.rdbFamille);
            this.groupBox1.Controls.Add(this.txtNumTel);
            this.groupBox1.Controls.Add(this.txtAdresse);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(64, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création personne";
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(125, 264);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(164, 23);
            this.btnCreer.TabIndex = 18;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // txtRelFam
            // 
            this.txtRelFam.Location = new System.Drawing.Point(140, 238);
            this.txtRelFam.Name = "txtRelFam";
            this.txtRelFam.Size = new System.Drawing.Size(100, 20);
            this.txtRelFam.TabIndex = 17;
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(140, 198);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(261, 20);
            this.txtNote.TabIndex = 16;
            // 
            // txtNumBureau
            // 
            this.txtNumBureau.Enabled = false;
            this.txtNumBureau.Location = new System.Drawing.Point(140, 161);
            this.txtNumBureau.Name = "txtNumBureau";
            this.txtNumBureau.Size = new System.Drawing.Size(120, 20);
            this.txtNumBureau.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Relation familiale :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Note :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Numéro bureau :";
            // 
            // rdbAmis
            // 
            this.rdbAmis.AutoSize = true;
            this.rdbAmis.Location = new System.Drawing.Point(291, 89);
            this.rdbAmis.Name = "rdbAmis";
            this.rdbAmis.Size = new System.Drawing.Size(47, 17);
            this.rdbAmis.TabIndex = 11;
            this.rdbAmis.Text = "Amis";
            this.rdbAmis.UseVisualStyleBackColor = true;
            this.rdbAmis.CheckedChanged += new System.EventHandler(this.rdbAmis_CheckedChanged);
            // 
            // rdbTravail
            // 
            this.rdbTravail.AutoSize = true;
            this.rdbTravail.Location = new System.Drawing.Point(291, 58);
            this.rdbTravail.Name = "rdbTravail";
            this.rdbTravail.Size = new System.Drawing.Size(57, 17);
            this.rdbTravail.TabIndex = 10;
            this.rdbTravail.Text = "Travail";
            this.rdbTravail.UseVisualStyleBackColor = true;
            this.rdbTravail.CheckedChanged += new System.EventHandler(this.rdbTravail_CheckedChanged);
            // 
            // rdbFamille
            // 
            this.rdbFamille.AutoSize = true;
            this.rdbFamille.Checked = true;
            this.rdbFamille.Location = new System.Drawing.Point(291, 24);
            this.rdbFamille.Name = "rdbFamille";
            this.rdbFamille.Size = new System.Drawing.Size(57, 17);
            this.rdbFamille.TabIndex = 9;
            this.rdbFamille.TabStop = true;
            this.rdbFamille.Text = "Famille";
            this.rdbFamille.UseVisualStyleBackColor = true;
            this.rdbFamille.CheckedChanged += new System.EventHandler(this.rdbFamille_CheckedChanged);
            // 
            // txtNumTel
            // 
            this.txtNumTel.Location = new System.Drawing.Point(140, 121);
            this.txtNumTel.Mask = "00 00 00 00 00";
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(100, 20);
            this.txtNumTel.TabIndex = 8;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(140, 87);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(140, 55);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 6;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(140, 21);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Numéro de téléphone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitter);
            this.groupBox2.Controls.Add(this.btnSupprimer);
            this.groupBox2.Controls.Add(this.cmbPersonnes);
            this.groupBox2.Location = new System.Drawing.Point(535, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Affichez personne";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(81, 128);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(192, 34);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(81, 75);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(192, 31);
            this.btnSupprimer.TabIndex = 1;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // cmbPersonnes
            // 
            this.cmbPersonnes.FormattingEnabled = true;
            this.cmbPersonnes.Location = new System.Drawing.Point(48, 29);
            this.cmbPersonnes.Name = "cmbPersonnes";
            this.cmbPersonnes.Size = new System.Drawing.Size(253, 21);
            this.cmbPersonnes.TabIndex = 0;
            this.cmbPersonnes.SelectedIndexChanged += new System.EventHandler(this.cmbPersonnes_SelectedIndexChanged);
            // 
            // frPersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 368);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frPersonne";
            this.Text = "Gestion Personne";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumBureau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRelFam;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.NumericUpDown txtNumBureau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbAmis;
        private System.Windows.Forms.RadioButton rdbTravail;
        private System.Windows.Forms.RadioButton rdbFamille;
        private System.Windows.Forms.MaskedTextBox txtNumTel;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ComboBox cmbPersonnes;
        private System.Windows.Forms.Button btnQuitter;
    }
}

