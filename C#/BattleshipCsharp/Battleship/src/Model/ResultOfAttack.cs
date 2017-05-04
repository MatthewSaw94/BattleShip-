/// <summary>
/// Player has its own _PlayerGrid, and can see an _EnemyGrid, it can also check if
/// all ships are deployed and if all ships are detroyed. A Player can also attach.
/// </summary>
namespace Battleship
{
    public enum ResultOfAttack
    {
        /// <summary>
        /// The player hit something
        /// </summary>
        Hit,

        /// <summary>
        /// The player missed
        /// </summary>
        Miss,

        /// <summary>
        /// The player destroyed a ship
        /// </summary>
        Destroyed,

        /// <summary>
        /// That location was already shot.
        /// </summary>
        ShotAlready,

        /// <summary>
        /// The player killed all of the opponents ships
        /// </summary>
        GameOver
    }
    //Tip #1 - You can drag .vb files here
    //from Windows Explorer.

    //Tip #2 - Use the project converter
    //for improved accuracy.
}