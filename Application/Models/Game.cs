using Magic.IndexedDb;
using Magic.IndexedDb.SchemaAnnotations;

namespace Application.Models;

public class Game : MagicTableTool<Game>, IMagicTable<DbSets>
{
    public int RoundId { get; set; }

    public int BoardNumber { get; set; }

    public int WhitePlayer { get; set; }

    public int BlackPlayer { get; set; }

    public GameResult Result { get; set; }

    [MagicNotMapped]
    public DbSets Databases => new();

    public List<IMagicCompoundIndex>? GetCompoundIndexes() => null;

    public IndexedDbSet GetDefaultDatabase() => IndexedDb.Boardplanner;

    public IMagicCompoundKey GetKeys() => CreateCompoundKey(x => x.RoundId, x => x.BoardNumber);

    public string GetTableName() => "Games";
}

public enum GameResult
{
    None,
    White,
    Draw,
    Black,
    WhiteRegulatory,
    BlackRegulatory
}