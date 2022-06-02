using System;
using System.Collections.Generic;
using System.Linq;
using ProbenDatenbank.Data.Collection;

namespace ProbenDatenbank.Data.Entity
{
    public class Prozess : BaseEntity
    {
        const String DatabaseTable = "Prozess";

        public int  Anlage_ID { get; set; }
        public string Anlage_Bezeichnung { get; set; }
        public int  Modus_ID { get; set; }
        public string Modus_Bezeichnung { get; set; }
        public string Bezeichnung { get; set; }
        
        public ProzessdatenCollection ProzessdatenCollection { get; set; }
        public TargetbelegungCollection TargetbelegungCollection { get; set; }

        public void Save(int beschichtungId)
        {
            base.Save();
            ProzessdatenCollection.SaveItems(Id, beschichtungId);
            TargetbelegungCollection.SaveItems(Id);
        }
        protected override void Create()
        {
            string query = string.Format(
                "INSERT INTO {0} VALUES(NULL,@Anlage_ID,@Modus_ID,@Bezeichnung)",
                DatabaseTable
            );

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Anlage_ID", Anlage_ID.ToString());
            sqlParams.Add("@Modus_ID", Modus_ID.ToString());
            sqlParams.Add("@Bezeichnung", Bezeichnung);
            
            Id = Database.RunInsertParamQuery(query, sqlParams);
        }
        
        protected override void Update()
        {
            string query = string.Format(
                "UPDATE {0} SET Anlage_ID=@Anlage_ID,Modus_ID=@Modus_ID,Bezeichnung=@Bezeichnung WHERE ID=@ID",
                DatabaseTable
            );

            Dictionary<string, string> sqlParams = new Dictionary<string, string>();
            sqlParams.Add("@Anlage_ID", Anlage_ID.ToString());
            sqlParams.Add("@Modus_ID", Modus_ID.ToString());
            sqlParams.Add("@Bezeichnung", Bezeichnung);
            sqlParams.Add("@Id", Id.ToString());
            
            Database.RunUpdateParamQuery(query, sqlParams);
        }
        
        /// <summary>
        /// Load item from database
        /// </summary>
        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();
            
            Anlage anlage = new Anlage();
            anlage.Load(int.Parse(item["Anlage_ID"]));

            Modus modus = new Modus();
            modus.Load(int.Parse(item["Modus_ID"]));

            ProzessdatenCollection = new ProzessdatenCollection();
            ProzessdatenCollection.LoadByProzess(Id);
            
            this.Id = Id;
            Anlage_ID = anlage.Id;
            Anlage_Bezeichnung = anlage.Bezeichnung;
            Modus_ID = modus.Id;
            Modus_Bezeichnung = modus.Bezeichnung;
            Bezeichnung = item["Bezeichnung"];
        }
        
        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return Bezeichnung + " - " + Anlage_Bezeichnung + " - " + Modus_Bezeichnung;
        }

        public string GetAnlageBezeichnung()
        {
            return this.Anlage_Bezeichnung;
        }

        public string GetModusBezeichnung()
        {
            return this.Modus_Bezeichnung;
        }
    }
}