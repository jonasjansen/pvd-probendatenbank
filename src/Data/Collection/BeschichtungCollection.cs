using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class BeschichtungCollection : BaseCollection
    {
        const String DatabaseTable = "Beschichtung";

        public override void LoadItemList()
        {
            Database Db = new Database();
            // TODO: Adjust query to get project_bezeichnung. Or Load Project by ID
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                Projekt projekt = new Projekt();
                projekt.Load(int.Parse(item["Projekt_ID"]));

                AddItem(new Beschichtung
                    {
                        Id = int.Parse(item["ID"]),
                        Projekt_ID = int.Parse(item["Projekt_ID"]),
                        Projekt_Bezeichnung = projekt.BezeichnungAkronym
                    }
                );
            }
        }
    }
}