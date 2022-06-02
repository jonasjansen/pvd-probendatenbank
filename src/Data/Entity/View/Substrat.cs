using System;
using System.Collections.Generic;

namespace ProbenDatenbank.Data.Entity
{
    public class Substrat : BaseEntity
    {
        public const String DatabaseTable = "Vorbehandlungsschritt";

        private String substratwerkstoffBezeichnung;
        private Dictionary<int, VorbehandlungsSchritt> vorbehandlungsSchrittPositionList;

        /// <summary>
        /// Initialize class attributes.
        /// </summary>
        public Substrat()
        {
            vorbehandlungsSchrittPositionList = new Dictionary<int, VorbehandlungsSchritt>();
        }

        /// <summary>
        /// Add item of type Vorbehandlunggsschritt to dictionary. The item's position attribute is used as key.
        /// </summary>
        /// <param name="item"></param>
        public void AddVorbehandungsSchritt(VorbehandlungsSchritt item)
        {
            vorbehandlungsSchrittPositionList[Int32.Parse(item.Position)] = item;
            substratwerkstoffBezeichnung = item.Substratwerkstoff_Bezeichnung;
        }

        public String GetSubstratwerkstoffBezeichnung()
        {
            return this.substratwerkstoffBezeichnung;
        }

        /// <summary>
        /// Get Vorbehandlung Bezeichnung at given position.
        /// Returns empty string if position is not set in dictionary.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public String GetVorbehandlungBezeichnung(int position)
        {
            return vorbehandlungsSchrittPositionList.ContainsKey(position)
                ? vorbehandlungsSchrittPositionList[position].Vorbehandlung_Bezeichnung
                : "";
        }
        

        /// <summary>
        /// Add Beschichtung_ID to Vorbehandlungsschritt entities and save them.
        /// </summary>
        /// <param name="beschichtungId"></param>
        public void Save(int beschichtungId)
        {
            foreach (VorbehandlungsSchritt item in vorbehandlungsSchrittPositionList.Values)
            {
                item.Beschichtung_ID = beschichtungId;
                item.Save();
            }
        }

        
        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return "Substrat auf Basis von " + substratwerkstoffBezeichnung;
        }
    }
}
