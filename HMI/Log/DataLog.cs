using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensTools.HMI.Log;

public class DataLog
{
    public EnumLogType LogType
    {
        get
        {
            return EnumLogType.DataLog;
        }
    }

    public static Dictionary<string, string> Structure = new Dictionary<string, string>
    {
        ["VarName"] = "TEXT",
        ["TimeString"] = "TEXT",
        ["VarValue"] = "DOUBLE",
        ["Validity"] = "INT",
        ["Time_ms"] = "DOUBLE"
    };

    public List<DataLogEntry> LogEntries { get; set; } = new List<DataLogEntry>();
}





