using System;
using System.Collections.Generic;
using System.Linq;

namespace ProbenDatenbank.Data.Entity
{
    public class AdminValidation : BaseEntity
    {
        const String DatabaseTable = "Admin";
        public string Hash { get; set; }
        
        public override void Load(int Id)
        {
            String query = "SELECT * FROM " + DatabaseTable + " WHERE ID =" + Id;
            Database Db = new Database();
            Dictionary<string, string> item = Db.Select(query).First();

            this.Id =Id;
            Hash = item["Hash"];
        }
        
        /// <summary>
        /// Returns string which represents this object.
        /// This is used in WindowsForms for example in ComboBox Dropdowns.  
        /// </summary>
        public override string ToString()
        {
            return "Password";
        }
    }
}