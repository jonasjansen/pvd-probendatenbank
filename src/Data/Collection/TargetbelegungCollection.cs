using System;
using System.Collections.Generic;
using System.Management.Instrumentation;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class TargetbelegungCollection : BaseCollection
    {
        const String DatabaseTable = "Targetbelegung";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Targetbelegung()
                    {
                        Id = int.Parse(item["ID"]),
                        Prozess_ID = int.Parse(item["Prozess_ID"]),
                        Targetwerkstoff_ID = int.Parse(item["Targetwerkstoff_ID"]),
                        Position = item["Position"]
                    }
                );
            }
        }
        
        public void SaveItems(int prozessId)
        {
            foreach (Targetbelegung item in GetItems())
            {
                item.Prozess_ID = prozessId;
                item.Save();
            }
        }

        public Targetbelegung GetTargetbelegungByPosition(string Position)
        {
            foreach (Targetbelegung item in GetItems())
            {
                if (item.Position == Position)
                {
                    return item;
                }
            }

            throw new InstanceNotFoundException();
        }

        public void LoadByProzess(int prozessId)
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable + " WHERE Prozess_ID = " + prozessId);

            foreach (var item in items)
            {
                Targetwerkstoff targetwerkstoff = new Targetwerkstoff();
                targetwerkstoff.Load(int.Parse(item["Targetwerkstoff_ID"]));
                
                AddItem(new Targetbelegung()
                    {
                        Id = int.Parse(item["ID"]),
                        Prozess_ID = prozessId,
                        Targetwerkstoff_ID = targetwerkstoff.Id,
                        Targetwerkstoff_Bezeichnung = targetwerkstoff.Bezeichnung,
                        Position = item["Position"]
                    }
                );
            }
        }
    }
}
