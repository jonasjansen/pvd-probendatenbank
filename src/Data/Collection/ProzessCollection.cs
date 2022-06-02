using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class ProzessCollection : BaseCollection
    {
        public ProzessCollection(bool canLoadItemsFromDatabase = true) : base(canLoadItemsFromDatabase)
        {
            // Use parent constructor only.
        }

        const String DatabaseTable = "Prozess";

        public void SaveItems(int beschichtungId)
        {
            foreach (Prozess item in GetItems())
            {
                item.Save(beschichtungId);
            }
        }
        
        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Prozess()
                    {
                        Id = int.Parse(item["ID"]),
                        Anlage_ID = int.Parse(item["Anlage_ID"]),
                        Modus_ID = int.Parse(item["Modus_ID"]),
                        Bezeichnung = item["Bezeichnung"]
                    }
                );
            }
        }
    }
}
