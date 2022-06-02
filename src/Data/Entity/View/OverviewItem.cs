using System;

namespace ProbenDatenbank.Data.Entity
{
    //TODO: Find a better name. Maybe something with OverviewItem or similar.
    public class OverviewItem : BaseEntity
    {
        public Beschichtung Beschichtung { get; set; }
        public Projekt Projekt { get; set; }
        public Schichtlage Schichtlage { get; set; }

        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.
        /// </summary>
        public override string ToString()
        {
            return "Beschichtung_" + Id;
        }
    }
}