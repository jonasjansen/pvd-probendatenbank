using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class ProzessdatenCollection : BaseCollection
    {
        public ProzessdatenCollection(bool canLoadItemsFromDatabase = true) : base(canLoadItemsFromDatabase)
        {
            // Used to pass canLoadItemsFromDatabase to parent.
        }

        const String DatabaseTable = "PVD_Prozessdatensatz";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Prozessdatensatz()
                    {
                        Id = int.Parse(item["ID"]),
                        Prozess_ID = int.Parse(item["Prozess_ID"]),
                        Rotation_ID = int.Parse(item["Rotation_ID"]),
                        Reihennummer = item["Reihennummer"],
                        LogdatenLink = item["LogdatenLink"],
                        ProzessLink = item["ProzessLink"],
                        ChargenLink = item["ChargenLink"]
                    }
                );
            }
        }
        
        public void SaveItems(int prozessId, int beschichtungId)
        {
            foreach (Prozessdatensatz item in GetItems())
            {
                item.Prozess_ID = prozessId;
                item.Beschichtung_ID = beschichtungId;
                item.Save();
            }
        }

        public void LoadByProzess(int id)
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable + " WHERE Prozess_ID = " + id);

            foreach (var item in items)
            {
                Rotation rotation = new Rotation();
                rotation.Load(int.Parse(item["Rotation_ID"]));
                
                //TODO: Load Rotation Bezeichnung
                AddItem(new Prozessdatensatz()
                {
                    Id = int.Parse(item["ID"]),
                    Prozess_ID = int.Parse(item["Prozess_ID"]),
                    Rotation_ID = rotation.Id,
                    Rotation_Bezeichnung = rotation.Bezeichnung,
                    Reihennummer = item["Reihennummer"],
                    LogdatenLink = item["LogdatenLink"],
                    ProzessLink = item["ProzessLink"],
                    ChargenLink = item["ChargenLink"]
                });
            }
        }
    }
}
