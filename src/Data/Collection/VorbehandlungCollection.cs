using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class VorbehandlungCollection : BaseCollection
    {
        const String DatabaseTable = "Vorbehandlung";
        
        public override void LoadItemList()
        {
            Database db = new Database();
            List<Dictionary<string, string>> items = db.Select("SELECT * FROM " + Vorbehandlung.DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Vorbehandlung
                    {
                        Id = int.Parse(item["ID"]),
                        Bezeichnung = item["Bezeichnung"]
                    }
                );
            }
        }
    }
}
