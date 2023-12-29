using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SiemensTools.Database;
using SiemensTools.HMI.Log.Enum;

namespace SiemensTools.HMI.Log.Type.Alarm;
public class Alarm : IDatabase
{
    private List<AlarmEntry> entries;

    public Alarm()
    {
        entries = new List<AlarmEntry>();
    }

    public Schema GetSchema()
    {
        return new Schema(){
                {"Time_ms" , "DOUBLE"},
                {"MsgProc" , "INT"},
                {"StateAfter" , "INT"},
                {"MsgClass" , "INT"},
                {"MsgNumber" , "INT"},
                {"Var1" , "TEXT"},
                {"Var2" , "TEXT"},
                {"Var3" , "TEXT"},
                {"Var4" , "TEXT"},
                {"Var5" , "TEXT"},
                {"Var6" , "TEXT"},
                {"Var7" , "TEXT"},
                {"Var8" , "TEXT"},
                {"TimeString" , "TEXT"},
                {"MsgText" , "TEXT"},
                {"PLC" , "TEXT"}
        };
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

