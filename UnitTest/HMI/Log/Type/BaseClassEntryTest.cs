using Xunit;
using SiemensTools.HMI.Log.Type;

namespace UnitTest.HMI.Log.Type;
public class BaseClassEntryTests
{

  [Fact]
  public void ConvertMillisecondsToDateTime_ConvertsToDateTime()
  {
    // arrange
    var date = DateTime.Now;

    // Act
    var result = BaseClassEntry.ConvertMillisecondsToDateTime(date.ToOADate() * 1000000.0);

    //12/28/2023 1:41:42 AM
    // Assert 
    Assert.Equal(DateTime.FromOADate(date.ToOADate()), result);
  }

}