namespace SiemensTools.HMI.Log.Type;

public class BaseClassEntry
{
    public static DateTime ConvertMillisecondsToDateTime(double timeInMilliseconds)
    {
        return DateTime.FromOADate(timeInMilliseconds / 1000000.0);
    }
}

