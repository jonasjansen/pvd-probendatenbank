using System;

namespace ProbenDatenbank.Data.Entity
{
    public class VorbehandlungsSchritt : BaseEntity
    {
        public const String DatabaseTable = "Vorbehandlungsschritt";
        public int Beschichtung_ID { get; set; }
        public int Substratwerkstoff_ID { get; set; }
        public String Substratwerkstoff_Bezeichnung { get; set; }
        public int Vorbehandlung_ID { get; set; }
        public String Vorbehandlung_Bezeichnung { get; set; }
        public string Position { get; set; }

        protected override void Create()
        {
            string sql = string.Format(
                "INSERT INTO {0} VALUES(NULL,{1},{2},{3},\"{4}\")",
                DatabaseTable, Beschichtung_ID, Substratwerkstoff_ID, Vorbehandlung_ID, Position
            );

            Id = Database.RunInsertQuery(sql);
        }
        
        protected override void Update()
        {
            string sql = string.Format(
                "UPDATE {0} SET Beschichtung_ID = {1}, Substratwerkstoff_ID = {2}, Vorbehandlung_ID = {3}, `Position` = \"{4}\" WHERE ID = {5} ",
                DatabaseTable, Beschichtung_ID, Substratwerkstoff_ID, Vorbehandlung_ID, Position, Id
            );

            Database.RunUpdateQuery(sql);
        }
    }
}