using System;
using System.Diagnostics;
using System.IO;
using System.Security;
using Renci.SshNet;
using static ProbenDatenbank.Service.CryptStringProvider;

namespace ProbenDatenbank.Service
{
    public static class FileUploader
    {
        private const string dataBaseDir = "/data/PVD_Probendatenbank";
        
        public static void FileUpload(string oldFilePath, string newFilePath, string fileName)
        {
            // Convert to absolute linux file path.
            newFilePath = Path.Combine(dataBaseDir, newFilePath);
            newFilePath = newFilePath.Replace('\\', '/');
            
            try
            {
                SecureString host = ToSecureString(Properties.Settings.Default.NetworkDriveHost);
                SecureString port = ToSecureString(Properties.Settings.Default.NetworkDrivePort);
                SecureString username = ToSecureString(Properties.Settings.Default.NetworkDriveUsername);
                SecureString password = ToSecureString(Properties.Settings.Default.NetworkDrivePassword);

                // Setup Credentials and Server Information
                ConnectionInfo ConnNfo = new ConnectionInfo(
                    ToInsecureString(host), 
                    int.Parse(ToInsecureString(port)),
                    ToInsecureString(username),
                    new AuthenticationMethod[]
                    {
                        // Pasword based Authentication
                        new PasswordAuthenticationMethod(
                            ToInsecureString(username),
                            ToInsecureString(password)
                            ),

                        // Key Based Authentication (using keys in OpenSSH Format)
                        /*
                        new PrivateKeyAuthenticationMethod("username",new PrivateKeyFile[]{ 
                            new PrivateKeyFile(@"..\openssh.key","passphrase")
                        }),
                        */
                    }
                );
                
                // Execute a (SHELL) Command - prepare upload directory
                using (var sshclient = new SshClient(ConnNfo)){
                    sshclient.Connect();
                    // Create new folder and add read & write rights.
                    using(var cmd = sshclient.CreateCommand("cd && mkdir -p " + newFilePath + " && chmod +rw " + newFilePath)){
                        cmd.Execute();
                        Console.WriteLine("Command>" + cmd.CommandText);
                        Console.WriteLine("Return Value = {0}", cmd.ExitStatus);
                    }            
                    sshclient.Disconnect();
                }

                // Upload A File
                using (var sftp = new SftpClient(ConnNfo)){
                    string uploadFileName = Path.Combine(oldFilePath, fileName);

                    sftp.Connect();
                    sftp.ChangeDirectory(newFilePath);
                    using (var uploadFileStream = File.OpenRead(uploadFileName)){
                        sftp.UploadFile(uploadFileStream, Path.GetFileName(uploadFileName), true);
                    }
                    sftp.Disconnect();
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}