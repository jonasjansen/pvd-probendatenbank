using System;
using System.Windows.Forms;
using ProbenDatenbank.Forms;
using ProbenDatenbank.Forms.IDAnlegen;
using ProbenDatenbank.Forms.Verwaltung;

namespace ProbenDatenbank
{
    public partial class Main : Form
    {
        private bool isAdmin;
        
        public Main()
        {
            isAdmin = false;
            InitializeComponent();
        }

        private void buttonIdAnlegen_Click(object sender, EventArgs e)
        {
            Form idAnlegenForm = new IDAnlegen();
            idAnlegenForm.ShowDialog();
        }

        private void buttonBearbeiten_Click(object sender, EventArgs e)
        {
            Form BearbeitenForm = new Bearbeiten();
            BearbeitenForm.ShowDialog();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            AdminCredentials adminCredentialsForm = new AdminCredentials(this);
            adminCredentialsForm.ShowDialog();
            
            if (isAdmin)
            {
                Form VerwaltungForm = new Verwaltung();
                VerwaltungForm.Show();
            }
            else
            {
                MessageBox.Show(@"Sie haben keinen Zugriff auf den Verwaltungsbereich.");
            }
        }

        public void setAdmin(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }
    }
}