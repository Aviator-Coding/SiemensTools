using SiemensTools.Database;

namespace SiemensTools.HMI.Log;

public interface IDatabase
{
  Schema GetSchema();
  void ReadData();
}

