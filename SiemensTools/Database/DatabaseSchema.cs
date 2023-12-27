namespace SiemensTools.Database;

public class DatabaseSchema
{
    public List<Column> Columns { get; } = new List<Column>();

    public class Column
    {
        public string Name { get; set; }
        public string DataType { get; set; }
    }


}
