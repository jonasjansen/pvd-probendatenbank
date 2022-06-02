using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    public class SchichtlageCollection : BaseCollection
    {
        public SchichtlageCollection(bool canLoadItemsFromDatabase = true) : base(canLoadItemsFromDatabase)
        {
            // Use parent constructor only.
        }

        const String DatabaseTable = "Schichtlage";

        public override void LoadItemList()
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable);

            foreach (var item in items)
            {
                AddItem(new Schichtlage()
                    {
                        Id = int.Parse(item["ID"]),
                        Schichtarchitektur_ID = int.Parse(item["Schichtarchitektur_ID"]),
                        Schichtwerkstoff_ID = int.Parse(item["Schichtwerkstoff_ID"]),
                        Position = item["Position"],
                        Beschichtungsdatum = item["Beschichtungsdatum"]
                    }
                );
            }
        }
        
        public void SaveItems(int beschichtungId)
        {
            foreach (Schichtlage item in GetItems())
            {
                item.Beschichtung_ID = beschichtungId;
                item.Save();
            }
        }

        public void LoadByBeschichtung(int beschichtungId)
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable + " WHERE Beschichtung_ID = " + beschichtungId);

            foreach (var item in items)
            {
                Prozess prozess = new Prozess();
                prozess.Load(int.Parse(item["Prozess_ID"]));
                
                TargetbelegungCollection targetbelegungCollection = new TargetbelegungCollection();
                targetbelegungCollection.LoadByProzess(prozess.Id);
                
                prozess.TargetbelegungCollection = targetbelegungCollection;

                Schichtarchitektur schichtarchitektur = new Schichtarchitektur();
                schichtarchitektur.Load(int.Parse(item["Schichtarchitektur_ID"]));

                Schichtwerkstoff schichtwerkstoff = new Schichtwerkstoff();
                schichtwerkstoff.Load(int.Parse(item["Schichtwerkstoff_ID"]));
                
                AddItem(new Schichtlage()
                    {
                        Id = int.Parse(item["ID"]),
                        Beschichtung_ID = beschichtungId,
                        Prozess_ID = prozess.Id,
                        Prozess_Bezeichnung = prozess.Bezeichnung,
                        Prozess = prozess,
                        Schichtarchitektur_ID = schichtarchitektur.Id,
                        Schichtarchitektur_Bezeichnung = schichtarchitektur.Bezeichnung,
                        Schichtwerkstoff_ID =  schichtwerkstoff.Id,
                        Schichtwerkstoff_Bezeichnung = schichtwerkstoff.Bezeichnung,
                        Position = item["Position"],
                        Beschichtungsdatum = item["Beschichtungsdatum"]
                    }
                );
            }
        }
    }
}
