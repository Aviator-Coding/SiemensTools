namespace SiemensTools.HMI.Log;

public interface IDatabase
{
  Dictionary<string, string> GetStructure();

  string[] GetSchema();
  void ReadData();
}

