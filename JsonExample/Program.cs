using System.Text.Json;
using System.Text.Json.Serialization;
using JsonExample;

var json = File.ReadAllText("tables.json");
var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = true};
var tables = JsonSerializer.Deserialize<Table[]>(json, options);
foreach (var table in tables)
{
    Console.WriteLine(table.Name);
}