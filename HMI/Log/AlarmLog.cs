using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiemensTools.HMI.Log;
public class AlarmLog
{
    public EnumLogType LogType { get
        {
            return EnumLogType.AlarmLog;
        }
    }

    public static Dictionary<string, string> Structure = new Dictionary<string, string>
    {
        ["Time_ms"] = "DOUBLE",
        ["MsgProc"] = "INT",
        ["StateAfter"] = "INT",
        ["MsgClass"] = "INT",
        ["MsgNumber"] = "INT",
        ["Var1"] = "TEXT",
        ["Var2"] = "TEXT",
        ["Var3"] = "TEXT",
        ["Var4"] = "TEXT",
        ["Var5"] = "TEXT",
        ["Var6"] = "TEXT",
        ["Var7"] = "TEXT",
        ["Var8"] = "TEXT",
        ["TimeString"] = "TEXT",
        ["MsgText"] = "TEXT",
        ["PLC"] = "TEXT"
    };

    public List<AlarmLogEntry> LogEntries { get; set; } = new List<AlarmLogEntry>();

}

