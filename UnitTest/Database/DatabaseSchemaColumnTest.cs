using SiemensTools.Database;
namespace UnitTest.Database;
public class DatabaseSchemaColumnTests
{
  // Test constructor and properties 
  [Fact]
  public void Constructor_SetsProperties()
  {
    // Arrange
    string name = "Test";
    string dataType = "string";

    // Act
    var column = new Column(name, dataType);

    // Assert
    Assert.Equal(name, column.Name);
    Assert.Equal(dataType, column.DataType);
  }

  // Test Equals method
  [Fact]
  public void Equals_ReturnsTrueForSameProperties()
  {
    // Arrange
    var column1 = new Column("Test", "string");
    var column2 = new Column("Test", "string");

    // Act
    var result = column1.Equals(column2);

    // Assert
    Assert.True(result);
  }

  [Fact]
  public void Equals_ReturnsFalseForDifferentProperties()
  {
    // Arrange
    var column1 = new Column("Test1", "string");
    var column2 = new Column("Test2", "int");

    // Act
    var result = column1.Equals(column2);

    // Assert
    Assert.False(result);
  }

  // Summary:
  // - Added XUnit tests for Column constructor, properties and Equals method
  // - Validates expected functionality
  // - Uses same XUnit import and static class import as existing tests
  // - No new frameworks or libraries needed
}