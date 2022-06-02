using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class SubstratwerkstoffCollection : BaseCollection
    {
        public override void LoadItemList()
        {
            Database db = new Database();
            List<Dictionary<string, string>> items = db.Select("SELECT * FROM " + Substratwerkstoff.DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Substratwerkstoff
                    {
                        Id = int.Parse(item["ID"]),
                        Bezeichnung = item["Bezeichnung"]
                    }
                );
            }
        }
    }
}
