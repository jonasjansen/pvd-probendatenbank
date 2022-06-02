using System;
using System.Collections.Generic;
using ProbenDatenbank.Data.Entity;

namespace ProbenDatenbank.Data.Collection
{
    /// <summary>
    /// This collection is a helper class for displaying Vorbehandlung entities in the form IDAnlegen.
    /// It does not represent actual database entities.
    /// </summary>
    public class SubstratCollection : BaseCollection
    {
        public const String DatabaseTable = "Vorbehandlungsschritt";
        
        public SubstratCollection(bool canLoadItemsFromDatabase = true) : base(canLoadItemsFromDatabase)
        {
            // Use parent constructor only.
        }

        /// <summary>
        /// Pass Beschichtung_ID to Substrat entities and save them.
        /// </summary>
        /// <param name="beschichtungId"></param>
        public void SaveItems(int beschichtungId)
        {
            foreach (Substrat item in GetItems())
            {
                item.Save(beschichtungId);
            }
        }
        
        /// <summary>
        /// Load Substrat of given beschichtungId from database.
        /// </summary>
        /// <param name="beschichtungId"></param>
        public void LoadByBeschichtung(int beschichtungId)
        {
            Database Db = new Database();
            List<Dictionary<string, string>> items = Db.Select("SELECT * FROM " + DatabaseTable + " WHERE Beschichtung_ID = " + beschichtungId);
            
            foreach (var item in items)
            {
                // Load Substratwerkstoff and Vorbehandung from Database
                Substratwerkstoff substratwerkstoff = new Substratwerkstoff();
                substratwerkstoff.Load( int.Parse(item["Substratwerkstoff_ID"]));
                Vorbehandlung vorbehandlung = new Vorbehandlung();
                vorbehandlung.Load(int.Parse(item["Vorbehandlung_ID"]));

                //
                VorbehandlungsSchritt vorbehandlungsSchritt = new VorbehandlungsSchritt()
                {
                    Id = int.Parse(item["ID"]),
                    Beschichtung_ID = beschichtungId,
                    Substratwerkstoff_ID = substratwerkstoff.Id,
                    Substratwerkstoff_Bezeichnung = substratwerkstoff.Bezeichnung,
                    Vorbehandlung_ID = vorbehandlung.Id,
                    Vorbehandlung_Bezeichnung = vorbehandlung.Bezeichnung,
                    Position = item["Position"]
                };
                
                if(Items.ContainsKey(substratwerkstoff.Id))
                {
                    Substrat substrat = (Substrat) Items[substratwerkstoff.Id];
                    substrat.AddVorbehandungsSchritt(vorbehandlungsSchritt);
                }
                else
                {
                    Substrat substrat = new Substrat();
                    substrat.AddVorbehandungsSchritt(vorbehandlungsSchritt);
                    Items[substratwerkstoff.Id] = substrat;
                }
            }
        }
    }
}
