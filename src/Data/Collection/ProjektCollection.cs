using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class ProjektCollection : BaseCollection
    {
        const String DatabaseTable = "Projekt";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Projekt
                    {
                        Id = int.Parse(item["ID"]),
                        Foedermittelgeber = item["Foerdermittelgeber"],
                        Foerderkennziffer = item["Foerderkennziffer"],
                        Laufzeit = item["Laufzeit"],
                        Status = item["Status"],
                        BezeichnungAkronym = item["BezeichnungAkronym"],
                        ProjektordnerLink = item["ProjektordnerLink"]
                    }
                );
            }
        }
    }
}