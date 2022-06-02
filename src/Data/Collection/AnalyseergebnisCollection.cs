using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class AnalyseergebnisCollection : BaseCollection
    {
        public Analysemethode Analysemethode { get; set; }
        public Beschichtung Beschichtung { get; set; }
        public Eigenschaft Eigenschaft { get; set; }
        
        
        public AnalyseergebnisCollection(bool canLoadItemsFromDatabase = true) : base(canLoadItemsFromDatabase)
        {
            // Use parent constructor only.
        }

        const String DatabaseTable = "Analyseergebnis";

        /// <summary>
        /// Load Item list from database. Filter result by foreign entities if they are set in this class.
        /// </summary>
        public override void LoadItemList()
        {
            HashSet<string> andStatements = new HashSet<string>();
            
            if (Beschichtung != null)
            {
                andStatements.Add("Beschichtung_ID = " + Beschichtung.Id);
            }
            
            if (Analysemethode != null)
            {
                andStatements.Add("Analysemethode_ID = " + Analysemethode.Id);
            }

            if (Eigenschaft != null)
            {
                andStatements.Add("Eigenschaft_ID = " + Eigenschaft.Id);
            }
            
            Database Db = new Database();
            String query = "SELECT * FROM " + DatabaseTable + " WHERE 1 ";
            foreach (string andStatement in andStatements)
            {
                query += "AND " + andStatement + " ";
            }
            List<Dictionary<string, string>> items = Db.Select(query);

            foreach (var item in items)
            {
                if (Beschichtung == null)
                {
                    Beschichtung = new Beschichtung();
                    Beschichtung.Load(int.Parse(item["Beschichtung_ID"]));
                }

                if (Analysemethode == null)
                {
                    Analysemethode = new Analysemethode();
                    Analysemethode.Load(int.Parse(item["Analysemethode_ID"]));
                }

                if (Eigenschaft == null)
                {
                    Eigenschaft = new Eigenschaft();
                    Eigenschaft.Load(int.Parse(item["Eigenschaft_ID"]));
                }
                
                AddItem(new Analyseergebnis()
                    {
                        Id = int.Parse(item["ID"]),
                        Beschichtung_ID = Beschichtung.Id,
                        Analysemethode_ID = Analysemethode.Id,
                        Analysemethode_Bezeichnung = Analysemethode.Bezeichnung,
                        Eigenschaft_ID = Eigenschaft.Id,
                        Eigenschaft_Bezeichnung = Eigenschaft.Bezeichnung,
                        Wert = item["Wert"],
                        Einheit = item["Einheit"],
                        AnalysedatenLink = item["AnalysedatenLink"]
                    }
                );
            }
        }
    }
}
