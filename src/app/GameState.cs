using System;
using System.Collections.Generic;
using System.Linq;
using WorldWarBass.Game.CountryAbstractions;

namespace WorldWarBass.Game.GameState;

/// <summary>
///  The game state class, a data abstraction to represent the state of the game.
/// </summary>
public class GameState {

    private PlayerCountry _playerCountry;

    public GameState(CountryName playerCountryName) {
        this._playerCountry = new PlayerCountry(playerCountryName);
    }

    /// <summary>
    /// The start method, called when the game starts, used to initialize the game state.
    /// </summary>
    public void Start() {

        // 

    }

    public PlayerCountry GetPlayerCountry() {
        return this._playerCountry;
    }
}