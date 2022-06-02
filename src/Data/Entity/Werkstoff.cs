using System;

namespace ProbenDatenbank.Data.Entity
{
    public class Werkstoff : BaseEntity
    {
        const String DatabaseTable = "Werkstoff";
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
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return Bezeichnung;
        }
    }
}