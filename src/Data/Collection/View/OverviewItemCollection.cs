using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class OverviewItemCollection : BaseCollection
    {
        public string ID { get; set; }
        public Projekt Projekt { get; set; }
        public Anlage Anlage { get; set; }
        public Substratwerkstoff Substratwerkstoff { get; set; }
        public Schichtwerkstoff Schichtwerkstoff { get; set; }
        const String DatabaseTable = "Beschichtung";

        public override void LoadItemList()
        {
            BeschichtungCollection beschichtungCollection = new BeschichtungCollection();
            Database Db = new Database();

            HashSet<string> fromStatements = new HashSet<string>();
            HashSet<string> andStatements = new HashSet<string>();

            fromStatements.Add(DatabaseTable);

            if (ID.Length > 0)
            {
                andStatements.Add("Beschichtung.ID = " + ID);
            }
            
            if (Projekt != null)
            {
                andStatements.Add("Beschichtung.Projekt_ID = " + Projekt.Id);
            }

            if (Anlage != null)
            {
                fromStatements.Add("Schichtlage");
                fromStatements.Add("Prozess");
                fromStatements.Add("Anlage");

                andStatements.Add("Beschichtung.ID = Schichtlage.Beschichtung_ID");
                andStatements.Add("Prozess.ID = Schichtlage.Prozess_ID");
                andStatements.Add("Anlage.ID = Prozess.Anlage_ID");
                andStatements.Add("Anlage.ID = " + Anlage.Id);
            }

            if (Substratwerkstoff != null)
            {
                fromStatements.Add("Vorbehandlungsschritt");
                fromStatements.Add("Substratwerkstoff");

                andStatements.Add("Beschichtung.ID = Vorbehandlungsschritt.Beschichtung_ID");
                andStatements.Add("Beschichtung.ID = Vorbehandlungsschritt.Beschichtung_ID");
                andStatements.Add("Substratwerkstoff.ID = Vorbehandlungsschritt.Substratwerkstoff_ID");
                andStatements.Add("Substratwerkstoff.ID = " + Substratwerkstoff.Id);
            }

            if (Schichtwerkstoff != null)
            {
                fromStatements.Add("Schichtlage");
                fromStatements.Add("Schichtwerkstoff");

                andStatements.Add("Beschichtung.ID = Schichtlage.Beschichtung_ID");
                andStatements.Add("Schichtwerkstoff.ID = Schichtlage.Schichtwerkstoff_ID");
                andStatements.Add("Schichtwerkstoff.ID = " + Schichtwerkstoff.Id);
            }

            String query = "SELECT " + DatabaseTable + ".* FROM ";
            foreach (string fromStatement in fromStatements)
            {
                query += fromStatement + ", ";
            }

            query = query.Trim(' ', ',');
            query += " WHERE 1 ";

            foreach (string andStatement in andStatements)
            {
                query += "AND " + andStatement + " ";
            }

            query += " GROUP BY Beschichtung.ID";

            List<Dictionary<string, string>> items = Db.Select(query);

            foreach (var item in items)
            {
                AddItem( new OverviewItem {
                        Beschichtung = new Beschichtung
                            {
                                Id = int.Parse(item["ID"]),
                                Projekt_ID = int.Parse(item["Projekt_ID"])
                            }
                    }
                );
            }
        }
    }
}