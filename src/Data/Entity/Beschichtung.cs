using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbenDatenbank.Data.Entity
{
    public class Beschichtung : BaseEntity
    {
        const String DatabaseTable = "Beschichtung";
        public int  Projekt_ID { get; set; }
        public string Projekt_Bezeichnung { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,{1})",
                DatabaseTable, Projekt_ID
            );

            Id = Database.RunInsertQuery(sql);
        }

        protected override void Update()
        {
            string sql = string.Format(
                "UPDATE {0} SET Projekt_ID = \"{1}\" WHERE ID = {2} ",
                DatabaseTable, Projekt_ID, Id
            );

            Database.RunUpdateQuery(sql);
        }
        
        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();
            
            this.Id = Id;
            Projekt_ID = int.Parse(item["Projekt_ID"]);

            // Projekt_Bezeichnung has to be loaded from Projekt table. 
            Projekt projekt = new Projekt();
            projekt.Load(Projekt_ID);
            Projekt_Bezeichnung = projekt.BezeichnungAkronym;
        }

        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.
        /// </summary>
        public override string ToString()
        {
            return "Beschichtung_" + Id;
        }
    }
}