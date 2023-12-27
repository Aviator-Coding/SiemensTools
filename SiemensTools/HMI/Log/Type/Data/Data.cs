using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiemensTools.HMI.Log.Enum;

namespace SiemensTools.HMI.Log.Type.Data;

public class Data : IDatabase
{
    public string[] GetSchema()
    {
        return ["VarName", "TimeString", "VarValue", "Validity", "Time_ms"];
    }

    public EnumType LogType
    {
        get
        {
            return EnumType.Data;
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

    public List<DataEntry> LogEntries { get; set; } = new List<DataEntry>();

    public Dictionary<string, string> GetStructure()
    {
        throw new NotImplementedException();
    }

    public void ReadData()
    {
        throw new NotImplementedException();
    }


}





