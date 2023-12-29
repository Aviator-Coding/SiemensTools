using Xunit;
using SiemensTools.HMI.Log.Type.Data;

namespace UnitTest.HMI.Log.Type;
public class DataTests {

  [Fact]
  public void GetSchema_ReturnsExpectedColumns() {
    // Arrange
    var data = new Data();
    
    // Act
    var schema = data.GetSchema();

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

  [Fact]
  public void GetSchema_ReturnsExpectedNumberOfColumns() {
    // Arrange
    var data = new Data();
    
    // Act
    var schema = data.GetSchema();
    
    // Assert
    Assert.Equal(5, schema.Columns.Count); 
  }
}