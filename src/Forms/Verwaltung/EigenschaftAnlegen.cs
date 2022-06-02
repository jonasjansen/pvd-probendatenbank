using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.Verwaltung
{
    public partial class EigenschaftAnlegen : Form
    {
        public EigenschaftAnlegen()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBezeichnung.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Bezeichnung ein.");
            }
            else
            {
                Eigenschaft item = new Eigenschaft
                {
                    Bezeichnung = textBoxBezeichnung.Text
                };
                item.Save();
                MessageBox.Show(@"Neue Eigenschaft wurde erfolgreich angelegt.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
