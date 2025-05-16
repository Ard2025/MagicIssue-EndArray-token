using Magic.IndexedDb;
using Magic.IndexedDb.Interfaces;

namespace Application.Models;

public class IndexedDb : IMagicRepository
{
    public static readonly IndexedDbSet Boardplanner = new("Boardplanner");
}
