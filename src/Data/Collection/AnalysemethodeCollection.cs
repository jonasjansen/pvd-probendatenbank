using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class AnalysemethodeCollection : BaseCollection
    {
        const String DatabaseTable = "Analysemethode";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Analysemethode()
                    {
                        Id = int.Parse(item["ID"]),
                        Bezeichnung = item["Bezeichnung"],
                    }
                );
            }
        }
    }
}
