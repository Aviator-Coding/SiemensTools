using SiemensTools.Database;

namespace SiemensTools.HMI.Log;

public interface IDatabase
{
  DatabaseSchema GetSchema();
  void ReadData();
}

