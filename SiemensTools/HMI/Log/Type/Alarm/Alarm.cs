using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiemensTools.HMI.Log.Enum;

namespace SiemensTools.HMI.Log.Type.Alarm;
public class Alarm : IDatabase
{

    public string[] GetSchema()
    {
        return ["Time_ms", "MsgProc", "StateAfter", "MsgClass", "MsgNumber", "Var1", "Var2", "Var3", "Var4", "Var5", "Var6", "Var7", "Var8", "TimeString", "MsgText", "PLC"];
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

    private List<AlarmEntry> entries;

    public Alarm()
    {
        entries = new List<AlarmEntry>();
    }

    public EnumType LogType
    {
        get
        {
            return EnumType.Alarm;
        }
    }



    public Dictionary<string, string> GetStructure()
    {
        throw new NotImplementedException();
    }

    public void ReadData()
    {
        throw new NotImplementedException();
    }
}

