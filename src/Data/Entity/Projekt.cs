using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbenDatenbank.Data.Entity
{
    public class Projekt : BaseEntity
    {
        const String DatabaseTable = "Projekt";

        public string Foedermittelgeber { get; set; }
        public string Foerderkennziffer { get; set; }
        public string Laufzeit { get; set; }
        public string Status { get; set; }
        public string ProjektordnerLink { get; set; }
        public string BezeichnungAkronym { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,\"{1}\",\"{2}\",\"{3}\",\"{4}\",\"{5}\",\"{6}\")",
                DatabaseTable, Foedermittelgeber, Foerderkennziffer, Laufzeit, Status, ProjektordnerLink, BezeichnungAkronym
            );

            Id = Database.RunInsertQuery(sql);
        }

        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();
            
            this.Id =Id;
            Foedermittelgeber = item["Foerdermittelgeber"];
            Foerderkennziffer = item["Foerderkennziffer"];
            Laufzeit = item["Laufzeit"];
            Status = item["Status"];
            BezeichnungAkronym = item["BezeichnungAkronym"];
            ProjektordnerLink = item["ProjektordnerLink"];
        }

        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return BezeichnungAkronym;
        }
    }
}