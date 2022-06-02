using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.src.Forms.Verwaltung
{
    public partial class SchichtwerkstoffAnlegen : Form
    {
        public SchichtwerkstoffAnlegen()
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
                Schichtwerkstoff item = new Schichtwerkstoff
                {
                    Bezeichnung = textBoxBezeichnung.Text
                };
                item.Save();
                MessageBox.Show(@"Neuer Schichtwerkstoff wurde erfolgreich angelegt.");
            }
        }
    }
}
