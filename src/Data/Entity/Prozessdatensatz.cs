using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using static ProbenDatenbank.Service.FileUploader;

namespace ProbenDatenbank.Data.Entity
{
    public class Prozessdatensatz : BaseEntity
    {
        //TODO pass Beschichtung ID here. This is needed for naming
        const String DatabaseTable = "PVD_Prozessdatensatz";
        public int  Beschichtung_ID { get; set; }
        public int Prozess_ID { get; set; }
        public String Prozess_Bezeichnung { get; set; }
        public int Rotation_ID { get; set; }
        public String Rotation_Bezeichnung { get; set; }
        public String Reihennummer { get; set; }
        public String LogdatenLink { get; set; }
        public String ProzessLink { get; set; }
        public String ChargenLink { get; set; }

        protected override void Create()
        {
            // The AnalysedatenLink attribute contains the char ". Therefore the query fails in this case.
            // This leads to the fact, that the query construction has to be hardened against SQL Injection!
            string query = string.Format(
                "INSERT INTO {0} VALUES(NULL,@Prozess_ID,@Rotation_ID,@Reihennummer,@LogdatenLink,@ProzessLink,@ChargenLink)",
                DatabaseTable
            );

            processAllLinkFiles();

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Prozess_ID", Prozess_ID.ToString());
            sqlParams.Add("@Rotation_ID", Rotation_ID.ToString());
            sqlParams.Add("@Reihennummer", Reihennummer);
            sqlParams.Add("@LogdatenLink", LogdatenLink);
            sqlParams.Add("@ProzessLink", ProzessLink);
            sqlParams.Add("@ChargenLink", ChargenLink);
            
            Id = Database.RunInsertParamQuery(query, sqlParams);
        }
        
        protected override void Update()
        {
            string query = string.Format(
                "UPDATE {0} SET Prozess_ID=@Prozess_ID,Rotation_ID=@Rotation_ID,Reihennummer=@Reihennummer,LogdatenLink=@LogdatenLink,ProzessLink=@ProzessLink,ChargenLink=@ChargenLink WHERE ID=@ID",
                DatabaseTable
            );

            processAllLinkFiles();

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Prozess_ID", Prozess_ID.ToString());
            sqlParams.Add("@Rotation_ID", Rotation_ID.ToString());
            sqlParams.Add("@Reihennummer", Reihennummer);
            sqlParams.Add("@LogdatenLink", LogdatenLink);
            sqlParams.Add("@ProzessLink", ProzessLink);
            sqlParams.Add("@ChargenLink", ChargenLink);
            sqlParams.Add("@Id", Id.ToString());
            
            Database.RunUpdateParamQuery(query, sqlParams);
        }

        private void processAllLinkFiles()
        {
            string newFilePath = getNewFilePath();
            LogdatenLink = processFiles(LogdatenLink, Path.Combine(newFilePath,"Prozess_Daten"));
            ProzessLink = processFiles(ProzessLink, Path.Combine(newFilePath, "Log_Daten"));
            ChargenLink = processFiles(ChargenLink, Path.Combine(newFilePath, "Chargen_Daten"));
        }

        private string getNewFilePath()
        {
            Prozess prozess = new Prozess();
            prozess.Load(Prozess_ID);

            // Needs to be passed to item.
            Beschichtung beschichtung = new Beschichtung();
            beschichtung.Load(Beschichtung_ID);

            string newFilePath = Path.Combine(
                beschichtung.Projekt_Bezeichnung,
                "Beschichtung_" + beschichtung.Id,
                "Prozess_" + Prozess_Bezeichnung + "_Anlage_" + prozess.Anlage_Bezeichnung + "_Modus_" +  prozess.Modus_Bezeichnung
            );
            return newFilePath.Replace(' ', '_');
        }
        
        private string processFiles(string filesJson, string newFilePath)
        {
            List<string> files = JsonConvert.DeserializeObject<List<string>>(filesJson);
            List<string> filesToSave = new List<string>();
            foreach (string file in files)
            {
                string fileName = Path.GetFileName(file);
                string oldFilePath = Path.GetDirectoryName(file);
                
                if ((!File.Exists(file) && oldFilePath != newFilePath) || 
                     string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(oldFilePath) || string.IsNullOrEmpty(newFilePath))
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
            return JsonConvert.SerializeObject(filesToSave, Formatting.Indented);
        }

        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return "Prozess_" + Prozess_ID;
        }
    }
}