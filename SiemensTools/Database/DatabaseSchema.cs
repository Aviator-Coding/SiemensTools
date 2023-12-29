using System.Collections;

namespace SiemensTools.Database;

public class DatabaseSchema : IEnumerable, IEquatable<DatabaseSchema>
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

    public bool Equals(DatabaseSchema? other)
    {
        if (other == null) return false;
        for (int i = 0; i < Columns.Count; i++)
        {
            if (!Columns[i].Equals(other.Columns[i])) return false;
        }

        return true;
    }

    public class Column : IEquatable<Column>
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

        public bool Equals(Column? other)
        {
            if (other == null) return false;

            if (Name != other.Name) return false;
            if (DataType != other.DataType) return false;

            return true;
        }
    }


}
