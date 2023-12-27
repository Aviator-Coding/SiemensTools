namespace SiemensTools.HMI.Log.Type.Data;
//-------------------------------
// Datalog Sqlite Structure
//-------------------------------
//["VarName"] = "TEXT",
//["TimeString"] = "TEXT",
//["VarValue"] = "DOUBLE",
//["Validity"] = "INT",
//["Time_ms"] = "DOUBLE"

public class DataEntry : BaseClassEntry
{
    public string VarName { get; set; } = string.Empty;
    public string TimeString { get; set; } = string.Empty;
    public double VarValue { get; set; }
    public int Validity { get; set; }
    public double TimeInMs { get; set; }
    public DateTime Time
    {
        get
        {
            return ConvertMillisecondsToDateTime(TimeInMs);
        }
    }
}

