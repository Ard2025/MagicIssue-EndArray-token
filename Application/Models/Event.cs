using Magic.IndexedDb;
using Magic.IndexedDb.SchemaAnnotations;

namespace Application.Models;

public class Event : MagicTableTool<Event>, IMagicTable<DbSets>
{
    public string DataType { get; set; }

    public string EventType { get; set; }

    public string Data { get; set; }

    [MagicNotMapped]
    public DbSets Databases => new();

    public List<IMagicCompoundIndex>? GetCompoundIndexes() => null;

    public IndexedDbSet GetDefaultDatabase() => IndexedDb.Boardplanner;

    public IMagicCompoundKey GetKeys() => CreateCompoundKey(x => x.DataType, x => x.EventType, x => x.Data);

    public string GetTableName() => "Events";
}
