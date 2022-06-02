using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbenDatenbank.Data.Entity
{
    public class Anlage : BaseEntity
    {
        const String DatabaseTable = "Anlage";
        public string Bezeichnung { get; set; }
        public int Technologie_ID { get; set; }
        public String Technologie_Bezeichnung { get; set; }
        public String Anlagen_Schema { get; set; }
        public String Target_Anzahl { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,{1},\"{2}\",\"{3}\",\"{4}\")",
                DatabaseTable, Technologie_ID, Bezeichnung, Anlagen_Schema, Target_Anzahl
            );

            Id = Database.RunInsertQuery(sql);
        }

        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();

            Technologie technologie = new Technologie();
            technologie.Load(int.Parse(item["Technologie_ID"]));
            
            this.Id =Id;
            Bezeichnung = item["Bezeichnung"];
            Technologie_ID = technologie.Id;
            Technologie_Bezeichnung = technologie.Bezeichnung;
            Anlagen_Schema = item["AnlagenSchema"];
            Target_Anzahl = item["TargetAnzahl"];
        }
        
        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return Bezeichnung;
        }
    }
}