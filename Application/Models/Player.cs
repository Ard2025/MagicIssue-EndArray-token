namespace Application.Models;

using Magic.IndexedDb;
using Magic.IndexedDb.SchemaAnnotations;
using System.Collections.Generic;

public class Player : MagicTableTool<Player>, IMagicTable<DbSets>
{
    public int Id { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public int Elo { get; set; }

    [MagicNotMapped]
    public DbSets Databases => new();

    public List<IMagicCompoundIndex>? GetCompoundIndexes() => null;

    public IndexedDbSet GetDefaultDatabase() => IndexedDb.Boardplanner;

    public IMagicCompoundKey GetKeys() => CreatePrimaryKey(x => x.Id, false);

    public string GetTableName() => "Players";

    public string GetFullName() => $"{FirstName} {MiddleName} {LastName}";
}