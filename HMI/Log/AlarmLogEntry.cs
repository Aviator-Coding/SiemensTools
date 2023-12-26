namespace SiemensTools.HMI.Log;

//-------------------------------
// AlarmDB Sqlite Structure
//-------------------------------
//["Time_ms"] = "DOUBLE",
//["MsgProc"] = "INT",
//["StateAfter"] = "INT",
//["MsgClass"] = "INT",
//["MsgNumber"] = "INT",
//["Var1"] = "TEXT",
//["Var2"] = "TEXT",
//["Var3"] = "TEXT",
//["Var4"] = "TEXT",
//["Var5"] = "TEXT",
//["Var6"] = "TEXT",
//["Var7"] = "TEXT",
//["Var8"] = "TEXT",
//["TimeString"] = "TEXT",
//["MsgText"] = "TEXT",
//["PLC"] = "TEXT"

public class AlarmLogEntry : LogEntryBaseClass
{
    public double TimeInMs { get; set; }
    public DateTime Time
    {
        get
        {
            return ConvertMillisecondsToDateTime(TimeInMs);
        }
    }
    public int MsgProc { get; set; }
    public EnumState StateAfter { get; set; }
    public int MsgClass { get; set; }
    public int MsgNumber { get; set; }
    public string Var1 { get; set; } = string.Empty;
    public string Var2 { get; set; } = string.Empty;
    public string Var3 { get; set; } = string.Empty;
    public string Var4 { get; set; } = string.Empty;
    public string Var5 { get; set; } = string.Empty;
    public string Var6 { get; set; } = string.Empty;
    public string Var7 { get; set; } = string.Empty;
    public string Var8 { get; set; } = string.Empty;
    public string TimeString { get; set; } = string.Empty;
    public string MsgText { get; set; } = string.Empty;
    public string PLC { get; set; } = string.Empty;
}

