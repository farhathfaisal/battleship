/// <summary>
/// The AIEasyPlayer is a type of AIPlayer where it will just randomly shoot always
/// </summary>
using System;
using System.Collections.Generic;

public class AIEasyPlayer : AIPlayer
{
    /// <summary>
    /// Private enumarator for AI states. currently there are two states,
    /// the AI can be searching for a ship, or if it has found a ship it will
    /// target the same ship
    /// </summary>

    // private AIStates _CurrentState = AIStates.Searching;
    //private Stack<Location> _Targets = new Stack<Location>();

    public AIEasyPlayer(BattleShipsGame controller) : base(controller) { }

    /// <summary>
    /// GenerateCoordinates should generate random shooting coordinates
    /// only when it has not found a ship, or has destroyed a ship and
    /// needs new shooting coordinates
    /// </summary>
    /// <param name="row">the generated row</param>
    /// <param name="column">the generated column</param>
    protected override void GenerateCoords(ref int row, ref int column)
    {
        do
        {
            SearchCoords(ref row, ref column);
        }
        while ((row < 0 || column < 0 || row >= EnemyGrid.Height || column >= EnemyGrid.Width || EnemyGrid[row, column] != TileView.Sea));
        // while inside the grid and not a sea tile do the search
    }

    /// <summary>
    /// SearchCoords will randomly generate shots within the grid as long as its not hit that tile already
    /// </summary>
    /// <param name="row">the generated row</param>
    /// <param name="column">the generated column</param>
    private void SearchCoords(ref int row, ref int column)
    {
        row = _Random.Next(0, EnemyGrid.Height);
        column = _Random.Next(0, EnemyGrid.Width);
    }

    /// <summary>
    /// ProcessShot will be called uppon when a ship is found.
    /// It will create a stack with targets it will try to hit. These targets
    /// will be around the tile that has been hit.
    /// </summary>
    /// <param name="row">the row it needs to process</param>
    /// <param name="col">the column it needs to process</param>
    /// <param name="result">the result og the last shot (should be hit)</param>
    protected override void ProcessShot(int row, int col, AttackResult result) { }
}
