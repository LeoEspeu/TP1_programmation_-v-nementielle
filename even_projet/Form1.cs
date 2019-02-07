using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace even_projet
{
    public partial class frPersonne : Form
    {
        public Repertoire r;

        public frPersonne()
        {
            r = new Repertoire();
            InitializeComponent();
        }

        private void rdbFamille_CheckedChanged(object sender, EventArgs e)
        {
            txtNumBureau.Enabled = false;
            txtNote.Enabled = false;
            txtRelFam.Enabled = true;
        }

        private void rdbTravail_CheckedChanged(object sender, EventArgs e)
        {
            txtNumBureau.Enabled = true;
            txtNote.Enabled = false;
            txtRelFam.Enabled = false;
        }

        private void rdbAmis_CheckedChanged(object sender, EventArgs e)
        {
            txtNumBureau.Enabled = false;
            txtNote.Enabled = true;
            txtRelFam.Enabled = false;
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNom.Text == "" || txtPrenom.Text == "" || txtAdresse.Text == "" || txtNumTel.Text == "") throw new Exception("Information(s) incompléte(s) !");
                if (rdbAmis.Checked)
                {
                    if (txtNote.Text == "") throw new Exception("Note sur la relation travail incompléte !");
                    r.Ajouter(new Amis(txtNote.Text, txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtNumTel.Text));
                    cmbPersonnes.Items.Add(txtNom.Text + " - " + txtPrenom.Text);
                }
                else if (rdbFamille.Checked)
                {
                    if (txtRelFam.Text == "") throw new Exception("Information sur la relation familliale de la relation famille incompléte !");
                    r.Ajouter(new Famille(txtRelFam.Text, txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtNumTel.Text));
                    cmbPersonnes.Items.Add(txtNom.Text + " - " + txtPrenom.Text);
                }
                else
                {
                    r.Ajouter(new Travail(Convert.ToInt16(txtNumBureau.Value), txtNom.Text, txtPrenom.Text, txtAdresse.Text, txtNumTel.Text));
                    cmbPersonnes.Items.Add(txtNom.Text + " - " + txtPrenom.Text);
                }
                MessageBox.Show("Création de la personne réussite", "Information sur la création de la personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Information sur la création de la personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbPersonnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            personne unePersonne = r.LesPersonnes[cmbPersonnes.SelectedIndex];
            if (cmbPersonnes.Items.Count > 0) btnSupprimer.Enabled = true;
            if (unePersonne is Amis) unePersonne = (Amis)unePersonne;
            else if (unePersonne is Travail) unePersonne = (Travail)unePersonne;
            else unePersonne = (Famille)unePersonne;
            MessageBox.Show(unePersonne.ToString(), "Informations de la personne sélectionnées", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                r.Supprimmer(r.LesPersonnes[cmbPersonnes.SelectedIndex]);
                cmbPersonnes.Items.Remove(cmbPersonnes.SelectedItem);
                if (cmbPersonnes.Items.Count == 0) btnSupprimer.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Veuillez sélectionnez une personne avant toute suppression.", "Information à la suppression de la personne", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous quitter l'application ?", "Avertissement avant fermeture de l'application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes) Application.Exit();
        }
    }
}
