using Microsoft.Data.Sqlite;
using SiemensTools.Database;

namespace SiemensTools.HMI.Log;

public class DatabaseFactory
{
  const string tableName = "logdata";
  private readonly SqliteConnection _connection;

  public DatabaseFactory(string databaseFilename)
  {
    var connectionString = $"Data Source={databaseFilename}";

    _connection = new SqliteConnection(connectionString);
  }

  private DatabaseSchema GetDatabaseSchema()
  {
    // Query sqlite_master table for schema info
    var command = _connection.CreateCommand();
    command.CommandText =
      $@"SELECT name, type FROM sqlite_master 
       WHERE type='table' AND name='{tableName}'";

    var schema = new DatabaseSchema();
    using (var reader = command.ExecuteReader())
    {
      while (reader.Read())
      {
        schema.Columns.Add(new DatabaseSchema.Column
        {
          Name = reader.GetString(0),
          DataType = reader.GetString(1)
        });
      }
    }

    return schema;
  }
}
