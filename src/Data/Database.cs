using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using ProbenDatenbank.Forms;

namespace ProbenDatenbank.Data
{
    public class Database
    {
        private MySqlConnection Connection;
        public Database()
        {
            Connection = new MySqlConnection(GetConnectionString());
        }
        
        private void UpdateConnectionString()
        {
            Connection = new MySqlConnection(GetConnectionString());
        }

        private String GetConnectionString()
        {
            return  "SERVER=" + Properties.Settings.Default.DBConnectionServer + ";" +
                    "DATABASE=" + Properties.Settings.Default.DBConnectionDatabase + ";" +
                    "UID=" + Properties.Settings.Default.DBConnectionUID + ";" +
                    "PASSWORD=" + Properties.Settings.Default.DBConnectionPassword + ";";
        }

        private bool OpenConnection()
        {
            bool connectionSuccessful = false;
            while (!connectionSuccessful)
            {
                try
                {
                    Connection.Open();
                    connectionSuccessful = true;
                }
                catch (MySqlException e)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    switch (e.Number)
                    {
                        case 0:
                            MessageBox.Show(@"Server ist nicht erreichbar.");
                            break;
                        
                        case 1045:
                            MessageBox.Show(@"Falscher Nutzername oder Passwort.");
                            break;
                    }
                    
                    // Open Credentials form.
                    Form credentialsForm = new DatabaseCredentials();
                    credentialsForm.ShowDialog();
                    UpdateConnectionString();
                }
            }
            return true;
        }

        private bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Run INSERT query on database. Returns ID of created entry.
        /// </summary>
        /// <param name="query">INSERT query. Example "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')"</param>
        /// <returns></returns>
        public int RunInsertQuery(string query)
        {
            int id = 0;
            try
            {
                //open connection
                if (OpenConnection())
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, Connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    
                    //Get ID of created entry.
                    id = Convert.ToInt32(cmd.LastInsertedId);

                    //close connection
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(@"Query konnte nicht ausgeführt werden: " + e.Message);
            }

            return id;
        }
        
        /// <summary>
        /// Run INSERT query on database. Returns ID of created entry.
        /// </summary>
        /// <param name="query">INSERT query. Example "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')"</param>
        /// <returns></returns>
        public int RunInsertParamQuery(string queryTemplate, Dictionary<string, string> sqlParams)
        {
            int id = 0;
            try
            {
                //open connection
                if (OpenConnection())
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(queryTemplate, Connection);
                    foreach (KeyValuePair<string, string> entry in sqlParams)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    cmd.ExecuteNonQuery();
                    
                    //Get ID of created entry.
                    id = Convert.ToInt32(cmd.LastInsertedId);

                    //close connection
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(@"Query konnte nicht ausgeführt werden: " + e.Message);
            }

            return id;
        }
        
        /// <summary>
        /// Run UPDATE query on database.
        /// </summary>
        /// <param name="query">INSERT query. Example "UPDATE customer SET ContactName = 'Alfred Schmidt', City= 'Frankfurt' WHERE CustomerID = 1;
        /// <returns></returns>
        public void RunUpdateQuery(string query)
        {
            try
            {
                //open connection
                if (OpenConnection())
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, Connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    
                    //close connection
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(@"Query konnte nicht ausgeführt werden: " + e.Message);
            }
        }
        
        /// <summary>
        /// Run UPDATE query on database.
        /// </summary>
        /// <param name="query">INSERT query. Example "UPDATE customer SET ContactName=@ContactName, City=@City WHERE CustomerID=@CustomerID;
        /// <returns></returns>
        public void RunUpdateParamQuery(string queryTemplate, Dictionary<string, string> sqlParams)
        {
            try
            {
                //open connection
                if (OpenConnection())
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(queryTemplate, Connection);
                    foreach (KeyValuePair<string, string> entry in sqlParams)
                    {
                        cmd.Parameters.AddWithValue(entry.Key, entry.Value);
                    }
                    
                    //Execute command
                    cmd.ExecuteNonQuery();
                    
                    //close connection
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(@"Query konnte nicht ausgeführt werden: " + e.Message);
            }
        }
        /// <summary>
        /// Run DELETE query on database.
        /// </summary>
        /// <param name="query">DELETE query. Example "DELETE FROM customer WHERE CustomerID = 1;
        /// <returns></returns>
        public void RunDeleteQuery(string query)
        {
            try
            {
                //open connection
                if (OpenConnection())
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, Connection);

                    //Execute command
                    cmd.ExecuteNonQuery();
                    
                    //close connection
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(@"Query konnte nicht ausgeführt werden: " + e.Message);
            }
        }

        public List<Dictionary<string, string>> Select(string query)
        {
            List<string> columnNames = new List<string>();
            List<Dictionary<string, string>> items = new List<Dictionary<string, string>>();
            
            try
            {
                if (OpenConnection())
                {
                    // Initialize DataReader
                    MySqlCommand cmd = new MySqlCommand(query, Connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
        
                    while (dataReader.Read())
                    {
                        // Get list of all column names once.
                        if (columnNames.Count < 1)
                        {
                            columnNames = GetColumnNames(dataReader);
                        }

                        // Read data from row and save as Dictionary item into List items. 
                        Dictionary<string, string> item = new Dictionary<string, string>(); 
                        foreach (string columnName in columnNames)
                        {
                            item[columnName] = dataReader[columnName].ToString();
                        }
                        
                        items.Add(item);
                    }
                        
                    // Close DataReader and Connection
                    dataReader.Close();
                    CloseConnection();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(@"Query konnte nicht ausgeführt werden: " + e.Message);
            }
            
            return items;

        }

        public List<string> GetColumnNames(MySqlDataReader dataReader)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < dataReader.FieldCount; i++) 
            {
                list.Add((dataReader.GetName(i)));
            }

            return list;
        }
    }
}