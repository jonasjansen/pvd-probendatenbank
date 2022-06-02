using System.Windows.Forms;

namespace ProbenDatenbank.Forms
{
    public partial class DatabaseCredentials : Form
    {
        public DatabaseCredentials()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            Properties.Settings.Default.DBConnectionServer = textBoxDbServer.Text;
            Properties.Settings.Default.DBConnectionUID = textBoxDbUser.Text;
            Properties.Settings.Default.DBConnectionPassword = textBoxDbPassword.Text;
            Properties.Settings.Default.DBConnectionDatabase = textBoxDbDatabase.Text;
            Close();
        }

        private void buttonStop_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}