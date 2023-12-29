namespace SiemensTools.Database;

/// <summary>
/// Represents a database column.
/// </summary>
public sealed class Column : IEquatable<Column>
{
  /// <summary>
  /// The column name.
  /// </summary>
  public string Name { get; } = string.Empty;

  /// <summary>
  /// The column data type. 
  /// </summary>
  public string DataType { get; } = string.Empty;

  /// <summary>
  /// Initializes a new instance of the <see cref="Column"/> class.
  /// </summary>
  /// <param name="name">The name of the column.</param>
  /// <param name="dataType">The data type of the column.</param>
  /// <exception cref="ArgumentNullException">If name or dataType is null.</exception>  
  public Column(string name, string dataType)
  {
    Name = name ?? throw new ArgumentNullException(nameof(name));
    DataType = dataType ?? throw new ArgumentNullException(nameof(dataType));
  }

  /// <summary>
  /// Indicates whether the current object is equal to another object of the same type.
  /// </summary>
  /// <param name="other">An object to compare with this object.</param>
  /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
  public bool Equals(Column? other)
  {
    if (other is null)
      return false;

    return Name == other.Name &&
           DataType == other.DataType;
  }
}