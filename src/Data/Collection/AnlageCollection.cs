using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class AnlageCollection : BaseCollection
    {
        const String DatabaseTable = "Anlage";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Anlage()
                    {
                        Id = int.Parse(item["ID"]),
                        Technologie_ID = int.Parse(item["Technologie_ID"]),
                        Bezeichnung = item["Bezeichnung"],
                        Anlagen_Schema = item["AnlagenSchema"],
                        Target_Anzahl = item["TargetAnzahl"]
                    }
                );
            }
        }
    }
}
