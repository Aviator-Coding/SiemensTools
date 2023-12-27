using System.Collections;

namespace SiemensTools.Database;

public class DatabaseSchema : IEnumerable
{
    public List<Column> Columns { get; } = new List<Column>();

    public IEnumerator GetEnumerator()
    {
        return Columns.GetEnumerator();
    }

    public void Add(Column column)
    {
        Columns.Add(column);
    }

    public void Add(string name, string dataType)
    {
        Columns.Add(new Column(name, dataType));
    }


    public class Column
    {
        public string Name { get; set; }
        public string DataType { get; set; }

        public Column()
        {
            Name = string.Empty;
            DataType = string.Empty;
        }

        public Column(string name, string dataType)
        {
            Name = name;
            DataType = dataType;
        }
    }

}
