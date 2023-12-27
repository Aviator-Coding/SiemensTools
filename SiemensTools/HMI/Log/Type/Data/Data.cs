using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using SiemensTools.Database;
using SiemensTools.HMI.Log.Enum;

namespace SiemensTools.HMI.Log.Type.Data;

public class Data : IDatabase
{
    private List<DataEntry> entries;

    public Data()
    {
        entries = new List<DataEntry>();
    }

    public DatabaseSchema GetSchema()
    {
        return new DatabaseSchema(){
                {"VarName", "TEXT"},
                {"TimeString", "TEXT"},
                {"VarValue", "TEXT"},
                {"Validity", "INT"},
                {"Time_ms", "DOUBLE"},
        };
    }

    public EnumType LogType
    {
        get
        {
            return EnumType.Data;
        }
    }

    public void ReadData()
    {
        throw new NotImplementedException();
    }


}





