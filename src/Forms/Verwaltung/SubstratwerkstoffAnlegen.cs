using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Forms.Verwaltung
{
    public partial class SubstratwerkstoffAnlegen : Form
    {
        public SubstratwerkstoffAnlegen()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBezeichnung.Text))
            {
                MessageBox.Show(@"Bitte geben Sie eine Bezeichnung ein.");
            }
            else
            {
                Substratwerkstoff item = new Substratwerkstoff
                {
                    Bezeichnung = textBoxBezeichnung.Text
                };
                item.Save();
                MessageBox.Show(@"Neuer Substratwerkstoff erfolgreich angelegt.");
            }
        }
    }
}
