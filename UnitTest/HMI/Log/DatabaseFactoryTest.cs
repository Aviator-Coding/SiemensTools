using System.Reflection;
using SiemensTools.Database;
using SiemensTools.HMI.Log;
using Xunit;

namespace UnitTest.HMI.Log;
public class DatabaseFactoryTest
{
  const string AlarmLog = "Data/Alarms/Alarms log1.db3";
  const string DataLog = "Data/Data/StabTest0.db3";

  private async Task<DatabaseSchema> GetDatabaseSchemaAsync(string dbFilename)
  {
    // Act
    var dbFactory = new DatabaseFactory(dbFilename);

    // Act
    var method = typeof(DatabaseFactory)
      .GetMethod("GetDatabaseSchemaAsync", BindingFlags.NonPublic | BindingFlags.Instance);

    // Use Task.Run to invoke method and wait for result
    var task = (Task<DatabaseSchema>)method.Invoke(dbFactory, null);
    return await task;

  }

  [Fact]
  public async Task GetDatabaseSchema_ReturnsSchema()
  {
    // Arrange
    var schema = await GetDatabaseSchemaAsync(AlarmLog);

    // Assert
    Assert.NotNull(schema);
    // var schema = dbFactory.GetDatabaseSchema();

    // Assert
    Assert.NotNull(schema);
    Assert.NotEmpty(schema.Columns);

    // Check schema contains expected columns
    Assert.Contains(schema.Columns, c => c.Name == "Time_ms");
    Assert.Contains(schema.Columns, c => c.Name == "StateAfter");
    Assert.Contains(schema.Columns, c => c.Name == "MsgClass");
    Assert.Contains(schema.Columns, c => c.Name == "MsgNumber");
    Assert.Contains(schema.Columns, c => c.Name == "Var1");
    Assert.Contains(schema.Columns, c => c.Name == "Var2");
    Assert.Contains(schema.Columns, c => c.Name == "Var3");
    Assert.Contains(schema.Columns, c => c.Name == "Var4");
    Assert.Contains(schema.Columns, c => c.Name == "Var5");
    Assert.Contains(schema.Columns, c => c.Name == "Var6");
    Assert.Contains(schema.Columns, c => c.Name == "Var7");
    Assert.Contains(schema.Columns, c => c.Name == "Var8");
    Assert.Contains(schema.Columns, c => c.Name == "TimeString");
    Assert.Contains(schema.Columns, c => c.Name == "MsgText");
    Assert.Contains(schema.Columns, c => c.Name == "PLC");
  }

  [Fact]
  public async Task GetDatabaseSchema_TypeAlarms_ReturnsCorrectSchema()
  {
    // Arrange
    var schema = await GetDatabaseSchemaAsync(AlarmLog);

    // Assert
    Assert.NotNull(schema);
    // var schema = dbFactory.GetDatabaseSchema();

    // Assert
    Assert.NotNull(schema);
    Assert.NotEmpty(schema.Columns);

    // Check schema contains expected columns
    Assert.Contains(schema.Columns, c => c.Name == "Time_ms");
    Assert.Contains(schema.Columns, c => c.Name == "StateAfter");
    Assert.Contains(schema.Columns, c => c.Name == "MsgClass");
    Assert.Contains(schema.Columns, c => c.Name == "MsgNumber");
    Assert.Contains(schema.Columns, c => c.Name == "Var1");
    Assert.Contains(schema.Columns, c => c.Name == "Var2");
    Assert.Contains(schema.Columns, c => c.Name == "Var3");
    Assert.Contains(schema.Columns, c => c.Name == "Var4");
    Assert.Contains(schema.Columns, c => c.Name == "Var5");
    Assert.Contains(schema.Columns, c => c.Name == "Var6");
    Assert.Contains(schema.Columns, c => c.Name == "Var7");
    Assert.Contains(schema.Columns, c => c.Name == "Var8");
    Assert.Contains(schema.Columns, c => c.Name == "TimeString");
    Assert.Contains(schema.Columns, c => c.Name == "MsgText");
    Assert.Contains(schema.Columns, c => c.Name == "PLC");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "VarName");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "VarValue");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Validity");
  }

  [Fact]
  public async Task GetDatabaseSchema_TypeData_ReturnsCorrectSchema()
  {
    // Arrange
    var schema = await GetDatabaseSchemaAsync(DataLog);

    // Assert
    Assert.NotNull(schema);
    // var schema = dbFactory.GetDatabaseSchema();

    // Assert
    Assert.NotNull(schema);
    Assert.NotEmpty(schema.Columns);

    // Check schema contains expected columns
    Assert.Contains(schema.Columns, c => c.Name == "VarName");
    Assert.Contains(schema.Columns, c => c.Name == "TimeString");
    Assert.Contains(schema.Columns, c => c.Name == "VarValue");
    Assert.Contains(schema.Columns, c => c.Name == "Validity");
    Assert.Contains(schema.Columns, c => c.Name == "Time_ms");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "StateAfter");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "MsgClass");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "MsgNumber");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var1");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var2");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var3");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var4");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var5");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var6");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var7");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "Var8");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "MsgText");
    Assert.DoesNotContain(schema.Columns, c => c.Name == "PLC");

  }
}


