namespace SiemensTools.HMI.Log;

public class LogEntryBaseClass
{
    public static DateTime ConvertMillisecondsToDateTime(double timeInMilliseconds)
    {
        return DateTime.FromOADate(timeInMilliseconds / 1000000.0);
    }
}

