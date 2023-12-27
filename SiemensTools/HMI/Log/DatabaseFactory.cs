using Microsoft.Data.Sqlite;
using SiemensTools.Database;
using static SiemensTools.Database.DatabaseSchema;

namespace SiemensTools.HMI.Log;

public class DatabaseFactory
{
  const string tableName = "logdata";
  private readonly SqliteConnection _connection;

  public DatabaseFactory(string databaseFilename)
  {
    var connectionString = $"Data Source={databaseFilename}";

    _connection = new SqliteConnection(connectionString);
    SQLitePCL.Batteries_V2.Init();
  }

  private async Task OpenConnectionAsync()
  {
    if (_connection.State == System.Data.ConnectionState.Closed)
      await _connection.OpenAsync();
    return;
  }


  private async Task<DatabaseSchema> GetDatabaseSchemaAsync()
  {
    await OpenConnectionAsync();

    // Query sqlite_master table for schema info
    var command = _connection.CreateCommand();
    command.CommandText = $@"PRAGMA table_info('{tableName}')";

    var schema = new DatabaseSchema();
    using (var reader = await command.ExecuteReaderAsync())
    {
      while (await reader.ReadAsync())
      {
        schema.Add(new Column()
        {
          Name = reader.GetString(1),
          DataType = reader.GetString(2)
        });

      }
    }

    return schema;
  }
}
