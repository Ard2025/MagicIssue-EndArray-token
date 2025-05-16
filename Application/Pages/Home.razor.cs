using Application.Models;
using Magic.IndexedDb;
using Microsoft.AspNetCore.Components;

namespace Application.Pages;

partial class Home
{
    public async Task ClearApplication()
    {
        await (await _MagicDb.Query<Event>()).ClearTable();
        await (await _MagicDb.Query<Game>()).ClearTable();
        await (await _MagicDb.Query<Player>()).ClearTable();
    }

    public async Task TestPlayer()
    {
        var player = new Player()
        {
            Elo = 1250,
            FirstName = "Jan",
            MiddleName = "",
            LastName = "Jansen",
            Id = 1,
        };
        var table = await _MagicDb.Query<Player>();
        await table.AddAsync(player);
    }

    public async Task TestEvent()
    {
        var myEvent = new Event()
        {
            EventType = "Add",
            DataType = "Player",
            Data = "{Elo:1250, FirstName:\"Jan\", MiddleName:\"\", LastName:\"Jansen\", Id:1}"
        };
        var table = await _MagicDb.Query<Event>();
        await table.AddAsync(myEvent);
    }

    public async Task TestGame()
    {
        var game = new Game()
        {
            BlackPlayer = 1,
            BoardNumber = 1,
            Result = GameResult.White,
            RoundId = 1,
            WhitePlayer = 2,
        };
        var table = await _MagicDb.Query<Game>();
        await table.AddAsync(game);
    }

}