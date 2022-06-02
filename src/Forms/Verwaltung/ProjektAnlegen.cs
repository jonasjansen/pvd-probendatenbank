using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.Verwaltung
{
    public partial class ProjektAnlegen : Form
    {
        public ProjektAnlegen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Projekt item = new Projekt
            {
                Foedermittelgeber = textBoxFoerdermittelgeber.Text,
                Foerderkennziffer = textBoxFoerderkennziffer.Text,
                Laufzeit = textBoxLaufzeit.Text,
                Status = textBoxStatus.Text,
                BezeichnungAkronym = textBoxAkronym.Text,
                ProjektordnerLink = textBoxProjektordnerLink.Text
            };
            item.Save();
            MessageBox.Show(@"Neues Projekt erfolgreich angelegt.");
            //Optional: Reset form.
        }
    }
}
