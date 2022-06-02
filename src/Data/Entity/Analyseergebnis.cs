using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using static ProbenDatenbank.Service.FileUploader;

namespace ProbenDatenbank.Data.Entity
{
    public class Analyseergebnis : BaseEntity
    {
        const String DatabaseTable = "Analyseergebnis";
        public int Beschichtung_ID { get; set; }

        public int Analysemethode_ID { get; set; }
        public String Analysemethode_Bezeichnung { get; set; }
        public int Eigenschaft_ID { get; set; }
        public String Eigenschaft_Bezeichnung { get; set; }
        public String Wert { get; set; }
        public String Einheit { get; set; }
        public String AnalysedatenLink { get; set; }

        protected override void Create()
        {
            // The AnalysedatenLink attribute contains the char ". Therefore the query fails in this case.
            // This leads to the fact, that the query construction has to be hardened against SQL Injection!
            string query = string.Format(
                "INSERT INTO {0} VALUES(NULL,@Beschichtung_ID,@Analysemethode_ID,@Eigenschaft_ID,@Wert,@Einheit,@AnalysedatenLink)",
                DatabaseTable
            );

            processAnalysedatenLinkFiles();

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Beschichtung_ID", Beschichtung_ID.ToString());
            sqlParams.Add("@Analysemethode_ID", Analysemethode_ID.ToString());
            sqlParams.Add("@Eigenschaft_ID", Eigenschaft_ID.ToString());
            sqlParams.Add("@Wert", Wert);
            sqlParams.Add("@Einheit", Einheit);
            sqlParams.Add("@AnalysedatenLink", AnalysedatenLink);
            
            Id = Database.RunInsertParamQuery(query, sqlParams);
        }
        
        protected override void Update()
        {
            string query = string.Format(
                "UPDATE {0} SET Beschichtung_ID=@Beschichtung_ID,Analysemethode_ID=@Analysemethode_ID,Eigenschaft_ID=@Eigenschaft_ID,Wert=@Wert,Einheit=@Einheit,AnalysedatenLink=@AnalysedatenLink WHERE ID=@ID",
                DatabaseTable
            );

            processAnalysedatenLinkFiles();

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Beschichtung_ID", Beschichtung_ID.ToString());
            sqlParams.Add("@Analysemethode_ID", Analysemethode_ID.ToString());
            sqlParams.Add("@Eigenschaft_ID", Eigenschaft_ID.ToString());
            sqlParams.Add("@Wert", Wert);
            sqlParams.Add("@Einheit", Einheit);
            sqlParams.Add("@AnalysedatenLink", AnalysedatenLink);
            sqlParams.Add("@Id", Id.ToString());
            
            Database.RunUpdateParamQuery(query, sqlParams);
        }

        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();

            this.Id =Id;
            Beschichtung_ID = int.Parse(item["Beschichtung_ID"]);
            Analysemethode_ID = int.Parse(item["Analysemethode_ID"]);
            Eigenschaft_ID = int.Parse(item["Eigenschaft_ID"]);
            Wert = item["Wert"];
            Einheit = item["Einheit"];
            AnalysedatenLink = item["AnalysedatenLink"];
        }

        private void processAnalysedatenLinkFiles()
        {
            Beschichtung beschichtung = new Beschichtung();
            beschichtung.Load(Beschichtung_ID);
            
            Projekt projekt = new Projekt();
            projekt.Load(beschichtung.Projekt_ID);
            
            string newFilePath = Path.Combine(
                projekt.BezeichnungAkronym,
                "Beschichtung_" + beschichtung.Id,
                "Analysedaten",
                "Methode_" + Analysemethode_Bezeichnung.Replace(" ", "_") + "_Eigenschaft_" + Eigenschaft_Bezeichnung.Replace(" ", "_")
            );
            newFilePath = newFilePath.Replace(' ', '_');
            
            List<string> files = JsonConvert.DeserializeObject<List<string>>(AnalysedatenLink);
            List<string> filesToSave = new List<string>();
            
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string oldFilePath = Path.GetDirectoryName(file);
                
                if (!File.Exists(file) || string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(oldFilePath) || string.IsNullOrEmpty(newFilePath))
                {
                    // no valid file or path.
                    continue;
                }
                if (oldFilePath != newFilePath)
                {
                    // copy file to new destination.
                    FileUpload(oldFilePath, newFilePath, fileName);
                }

                filesToSave.Add(Path.Combine(newFilePath, fileName));
            }
            
            // Save Json of saved files into AnalysedatenLink
            AnalysedatenLink = JsonConvert.SerializeObject(filesToSave, Formatting.Indented);
        }
        
        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString() 
        {
            return "Analyseergebnis";
        }

        /// <summary>
        /// Deletes entity from database. Be careful!
        /// </summary>
        /// <param name="Id"></param>
        public void Delete(int Id)
        {
            String query = "DELETE FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Db.RunDeleteQuery(query);
        }
    }
}