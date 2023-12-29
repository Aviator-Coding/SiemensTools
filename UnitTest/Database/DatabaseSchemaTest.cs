using Xunit;
using SiemensTools.Database;
using static SiemensTools.Database.DatabaseSchema;

namespace UnitTest.Database;
public class DatabaseSchemaTests
{
  [Fact]
  public void GetEnumerator_ReturnsColumnsEnumerator()
  {
    // Arrange
    var schema = new DatabaseSchema
    {
        { "Id", "int" },
        { "Name", "string" }
    };

    // Act
    var result = schema.GetEnumerator();

    // Assert
    Assert.IsType<List<Column>.Enumerator>(result);
  }

  [Fact]
  public void Add_AddsColumnToList()
  {
    // Arrange
    var schema = new DatabaseSchema();

    // Act
    schema.Add(new DatabaseSchema.Column("Test", "string"));

    // Assert
    Assert.Single(schema);
    Assert.Contains(schema.Columns, c => c.Name == "Test");
  }

  [Fact]
  public void AddColumnOverload_CreatesAndAddsColumn()
  {
    // Arrange
    var schema = new DatabaseSchema
    {
        // Act
        { "Test", "string" }
    };

    // Assert
    Assert.Single(schema);
    Assert.Contains(schema.Columns, c => c.Name == "Test");
  }

  [Fact]
  public void ColumnClass_ConstructorAndPropertiesWork()
  {
    // Arrange & Act
    var column = new DatabaseSchema.Column("Test", "string");

    // Assert
    Assert.Equal("Test", column.Name);
    Assert.Equal("string", column.DataType);
  }

  [Fact]
  public void Equals_WithNull_ReturnsFalse()
  {
    // Arrange
    var schema1 = new DatabaseSchema();

    // Act
    var result = schema1.Equals(null);

    // Assert
    Assert.False(result);
  }

  [Fact]
  public void Equals_WithSameSchema_ReturnsTrue()
  {
    // Arrange
    var schema1 = new DatabaseSchema
    {
        { "Id", "int" },
        { "Name", "string" }
    };

    var schema2 = new DatabaseSchema
    {
        { "Id", "int" },
        { "Name", "string" }
    };

    // Act
    var result = schema1.Equals(schema2);

    // Assert
    Assert.True(result);
  }

  [Fact]
  public void Equals_WithDifferentSchema_ReturnsFalse()
  {
    // Arrange
    var schema1 = new DatabaseSchema
    {
        { "Id", "int" }
    };

    var schema2 = new DatabaseSchema
    {
        { "Name", "string" }
    };

    // Act
    var result = schema1.Equals(schema2);

    // Assert
    Assert.False(result);
  }
}
