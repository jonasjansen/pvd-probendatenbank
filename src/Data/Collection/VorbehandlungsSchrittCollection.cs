using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    /// <summary>
    /// TODO: Think about moving the logic from the classes Substrat and SubstratCollection into this class.
    /// </summary>
    public class VorbehandlungSchrittCollection : BaseCollection
    {
        const String DatabaseTable = "Vorbehandlungsschritt";
        
        public override void LoadItemList()
        {
            Database db = new Database();
            List<Dictionary<string, string>> items = db.Select("SELECT * FROM " + Vorbehandlung.DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new VorbehandlungsSchritt
                    {
                        Id = int.Parse(item["ID"]),
                        Substratwerkstoff_ID = int.Parse(item["Substratwerkstoff_ID"]),
                        Vorbehandlung_ID = int.Parse(item["Vorbehandlung_ID"]),
                        Position = item["Position"]
                    }
                );
            }
        }
    }
}
