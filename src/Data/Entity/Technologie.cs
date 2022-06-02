using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbenDatenbank.Data.Entity
{
    public class Technologie : BaseEntity
    {
        const String DatabaseTable = "Technologie";
        public string Bezeichnung { get; set; }
        public int Bereich_ID { get; set; }
        public String Bereich_Bezeichnung { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,{1},\"{2}\")",
                DatabaseTable, Bereich_ID, Bezeichnung
            );

            Id = Database.RunInsertQuery(sql);
        }

        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();

            Bereich bereich = new Bereich();
            bereich.Load(int.Parse(item["Bereich_ID"]));
            
            this.Id =Id;
            Bezeichnung = item["Bezeichnung"];
            Bereich_ID = bereich.Id;
            Bereich_Bezeichnung = bereich.Bezeichnung;
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