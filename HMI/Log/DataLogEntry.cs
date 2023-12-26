namespace SiemensTools.HMI.Log;
//-------------------------------
// Datalog Sqlite Structure
//-------------------------------
//["VarName"] = "TEXT",
//["TimeString"] = "TEXT",
//["VarValue"] = "DOUBLE",
//["Validity"] = "INT",
//["Time_ms"] = "DOUBLE"

public class DataLogEntry : LogEntryBaseClass
{
    public string VarName { get; set; } = string.Empty;
    public string TimeString {  get; set; } = string.Empty;
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

