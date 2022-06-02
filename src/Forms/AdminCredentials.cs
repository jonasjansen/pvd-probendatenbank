using System;
using System.Windows.Forms;
using ProbenDatenbank.Data.Entity;
using ProbenDatenbank.Service;


namespace ProbenDatenbank.Forms
{
    public partial class AdminCredentials : Form
    {
        private Main parentForm;
        
        public AdminCredentials(Main parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, System.EventArgs e)
        {
            // !Important: The only way to get a new password/hash combination for the database is to use the debugger!
            // run something like this and replace YOUR_NEW_SALT and YOUR_NEW_PASSWORD:
            //
            // string password = "YOUR_NEW_PASSWORD";
            // string saltString = "YOUR_NEW_SALT";
            // byte[] saltByte = Convert.FromBase64String(saltString);
            // string passwordHash = PasswordHelper.ComputeHash(password, "SHA512", saltByte);
            // bool isValid = PasswordHelper.VerifyHash(password, "SHA512", passwordHash);
            //
            // And save the result into the database manually.
            // Note: saltString needs to have a length which can be divided by 4.

            AdminValidation adminValidation = new AdminValidation();
            adminValidation.Load(1);

            bool isValid = false;
            parentForm.setAdmin(isValid);
            try
            {
                isValid = PasswordHelper.VerifyHash(textBoxAdminPassword.Text, "SHA512", adminValidation.Hash);
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Es gab einen Fehler bei der Validierung: " + ex.Message);
            }
            parentForm.setAdmin(isValid);
            Close();
        }

        private void buttonStop_Click(object sender, System.EventArgs e)
        {
            parentForm.setAdmin(false);
            Close();
        }
    }
}