using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SiemensTools;
public class Utils
{
    public static void ExportToCsv<T>(IEnumerable<T> records, string filePath)
    {
        var csv = new StringBuilder();

        // Use reflection to get property names
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var headerLine = string.Join(",", properties.Select(p => p.Name));
        csv.AppendLine(headerLine);

        // Data rows
        foreach (var record in records)
        {
            var line = string.Join(",", properties.Select(p =>
            {
                var value = p.GetValue(record, null) ?? String.Empty;
                return value.ToString().Contains(",") ? $"\"{value}\"" : value;
            }));
            csv.AppendLine(line);
        }

        // Write to file
        File.WriteAllText(filePath, csv.ToString());
    }

    public static string ExportToCsv<T>(IEnumerable<T> records)
    {
        var csv = new StringBuilder();

        // Use reflection to get property names
        var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var headerLine = string.Join(",", properties.Select(p => p.Name));
        csv.AppendLine(headerLine);

        // Data rows
        foreach (var record in records)
        {
            var line = string.Join(",", properties.Select(p =>
            {
                var value = p.GetValue(record, null) ?? "";
                return value.ToString().Contains(",") ? $"\"{value}\"" : value;
            }));
            csv.AppendLine(line);
        }

        // Write to file
        return csv.ToString();
    }
}

