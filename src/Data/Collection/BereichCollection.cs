using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class BereichCollection : BaseCollection
    {
        const String DatabaseTable = "Bereich";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Bereich
                    {
                        Id = int.Parse(item["ID"]),
                        Bezeichnung = item["Bezeichnung"]
                    }
                );
            }
        }
    }
}