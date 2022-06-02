using System;
using System.Collections.Generic;
using System.Linq;
using ProbenDatenbank.Data.Collection;

namespace ProbenDatenbank.Data.Entity
{
    public class Schichtlage : BaseEntity
    {
        const String DatabaseTable = "Schichtlage";

        public int  Beschichtung_ID { get; set; }
        
        public Prozess Prozess { get; set; }
        public int  Prozess_ID { get; set; }
        public string Prozess_Bezeichnung { get; set; }        
        public int  Schichtarchitektur_ID { get; set; }
        public string Schichtarchitektur_Bezeichnung { get; set; }
        public int  Schichtwerkstoff_ID { get; set; }
        public string Schichtwerkstoff_Bezeichnung { get; set; }
        public string Position { get; set; }
        //TODO: Change type into date. Here and in DB.
        public string Beschichtungsdatum { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,{1},{2},{3},{4},\"{5}\",\"{6}\")",
                DatabaseTable, Beschichtung_ID, Prozess.Id, Schichtarchitektur_ID, Schichtwerkstoff_ID, Position, Beschichtungsdatum
            );

            Id = Database.RunInsertQuery(sql);
        }

        
        protected override void Update()
        {
            string sql = string.Format(
                "UPDATE {0} SET Beschichtung_ID = {1}, Prozess_ID = {2}, Schichtarchitektur_ID = {3}, Schichtwerkstoff_ID = {4}, `Position` = \"{5}\", `Beschichtungsdatum` = \"{6}\" WHERE ID = {7} ",
                DatabaseTable, Beschichtung_ID, Prozess.Id, Schichtarchitektur_ID, Schichtwerkstoff_ID, Position, Beschichtungsdatum, Id
            );

            Database.RunUpdateQuery(sql);
        }

        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return "Schichtlage " + Position;
        }
    }
}