using System;
using System.Collections.Generic;
using System.Linq;
using ProbenDatenbank.Data.Collection;

namespace ProbenDatenbank.Data.Entity
{
    public class Targetbelegung : BaseEntity
    {
        const String DatabaseTable = "Targetbelegung";
        public int Prozess_ID { get; set; }
        public string Prozess_Bezeichnung { get; set; }
        public int Targetwerkstoff_ID { get; set; }
        public string Targetwerkstoff_Bezeichnung { get; set; }
        public string Position { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,{1},{2},\"{3}\")",
                DatabaseTable, Prozess_ID, Targetwerkstoff_ID, Position
            );

            Id = Database.RunInsertQuery(sql);
            
            string query = string.Format(
                "INSERT INTO {0} VALUES(NULL,@Prozess_ID,@Targetwerkstoff_ID,@Position)",
                DatabaseTable
            );

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Prozess_ID", Prozess_ID.ToString());
            sqlParams.Add("@Targetwerkstoff_ID", Targetwerkstoff_ID.ToString());
            sqlParams.Add("@Position", Position);
            
            Id = Database.RunInsertParamQuery(query, sqlParams);
        }
        
        protected override void Update()
        {
            string query = string.Format(
                "UPDATE {0} SET Prozess_ID=@Prozess_ID,Targetwerkstoff_ID=@Targetwerkstoff_ID,Position=@Position WHERE ID=@ID",
                DatabaseTable
            );

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Prozess_ID", Prozess_ID.ToString());
            sqlParams.Add("@Targetwerkstoff_ID", Targetwerkstoff_ID.ToString());
            sqlParams.Add("@Position", Position);
            sqlParams.Add("@Id", Id.ToString());
            
            Database.RunUpdateParamQuery(query, sqlParams);
        }

        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return "Targetbelegung_" + Position;
        }
    }
}