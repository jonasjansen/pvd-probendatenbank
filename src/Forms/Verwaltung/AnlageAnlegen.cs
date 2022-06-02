using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Collection;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.Verwaltung
{
    public partial class AnlageAnlegen : Form
    {
        public AnlageAnlegen()
        {
            InitializeComponent();
            
            Technologien technologien = new Technologien();
            foreach (Technologie item in technologien.GetItems())
            {
                comboBoxTechnologie.Items.Add(item);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBezeichnung.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Bezeichnung ein.");
            }
            else if(comboBoxTechnologie.SelectedIndex < 0)
            {
                MessageBox.Show(@"Wählen Sie eine Technologie aus.");
            }
            else if(String.IsNullOrEmpty(textBoxTargetAnzahl.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Target Anzahl ein.");
            }
            else
            {
                Technologie selectedTechnologie = (Technologie) comboBoxTechnologie.SelectedItem;
                Anlage item = new Anlage
                {
                    Bezeichnung = textBoxBezeichnung.Text,
                    Technologie_ID = selectedTechnologie.Id,
                    Technologie_Bezeichnung = selectedTechnologie.Bezeichnung,
                    Target_Anzahl = textBoxTargetAnzahl.Text,
                    Anlagen_Schema = textBoxAnlagenSchema.Text
                };
                item.Save();
                MessageBox.Show(@"Neue Technologie wurde erfolgreich angelegt.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
