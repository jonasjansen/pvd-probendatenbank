using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbenDatenbank.Data.Entity
{
    public class Analysemethode : BaseEntity
    {
        const String DatabaseTable = "Analysemethode";
        public string Bezeichnung { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,\"{1}\")",
                DatabaseTable, Bezeichnung
            );

            Id = Database.RunInsertQuery(sql);
        }

        /// <summary>
        /// Load item from database
        /// </summary>
        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();
            
            this.Id = Id;
            Bezeichnung = item["Bezeichnung"];
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