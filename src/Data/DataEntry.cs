using System;

namespace ProbenDatenbank.Data
{
    public class DataEntry
    {
        public const String TYPE_INT = "INT";
        public const String TYPE_VARCHAR = "VARCHAR";

        public string DataType { get; set; }
        public string Column { get; set; }
        public string Value { get; set; }
    }
}