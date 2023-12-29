using System.Collections;
namespace SiemensTools.Database;

/// <summary>
/// Represents a database schema.
/// </summary>
public class Schema : IEnumerable, IEquatable<Schema>
{
    /// <summary>
    /// The schema columns.
    /// </summary>
    public List<Column> Columns { get; } = new List<Column>();

    /// <summary>
    /// Initializes a new instance of the <see cref="Schema"/> class.
    /// </summary>
    public Schema()
    { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Schema"/> class.
    /// </summary>
    /// <param name="columns">The columns.</param>
    public Schema(List<Column> columns)
    {
        Columns = columns;
    }

    /// <inheritdoc/>
    public IEnumerator GetEnumerator()
    {
        return Columns.GetEnumerator();
    }

    /// <summary>
    /// Adds the specified column.
    /// </summary>
    /// <param name="column">The column.</param>
    public void Add(Column column)
    {
        if (column == null)
            throw new ArgumentNullException(nameof(column));

        Columns.Add(column);
    }

    /// <summary>
    /// Adds the specified column.
    /// </summary>
    /// <param name="name">The Name.</param>
    /// <param name="dataType">The dataType.</param>
    public void Add(string name, string dataType)
    {
        if (name == null || name == string.Empty)
            throw new ArgumentNullException(nameof(name));

        if (dataType == null || name == string.Empty)
            throw new ArgumentNullException(nameof(dataType));
        Columns.Add(new Column(name, dataType));
    }

    /// <summary>
    /// Determines whether this instance is equal to the specified schema.
    /// </summary>
    /// <param name="other">The schema to compare to.</param>
    /// <returns>True if the schemas are equal, false otherwise.</returns>
    public bool Equals(Schema? other)
    {
        if (other == null)
            return false;

        if (Columns.Count != other.Columns.Count)
            return false;

        for (int i = 0; i < Columns.Count; i++)
        {
            if (!Columns[i].Equals(other.Columns[i]))
                return false;
        }

        return true;
    }

}
