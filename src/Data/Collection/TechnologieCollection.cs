using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class Technologien : BaseCollection
    {
        const String DatabaseTable = "Technologie";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Technologie()
                    {
                        Id = int.Parse(item["ID"]),
                        Bereich_ID = int.Parse(item["Bereich_ID"]),
                        Bezeichnung = item["Bezeichnung"]
                    }
                );
            }
        }
    }
}