using Xunit;
using SiemensTools.HMI.Log.Type.Alarm;

namespace UnitTest.HMI.Log.Type;
public class AlarmTests {

  [Fact]
  public void GetSchema_ReturnsExpectedColumns() {
    // Arrange
    var alarm = new Alarm();
    
    // Act
    var schema = alarm.GetSchema();
    
    // Assert
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
  public void GetSchema_ReturnsExpectedNumberOfColumns() {
    // Arrange
    var alarm = new Alarm();
      
    // Act  
    var schema = alarm.GetSchema();
    
    // Assert
    Assert.Equal(16, schema.Columns.Count); 
  }
}