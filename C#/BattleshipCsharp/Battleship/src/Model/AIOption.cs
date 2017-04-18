/// <summary>
/// The AIMediumPlayer is a type of AIPlayer where it will try and destroy a ship
/// if it has found a ship
/// </summary>
/// 

namespace Battleship
{
    public enum AIOption
    {
        /// <summary>
        /// Easy, total random shooting
        /// </summary>
        Easy,

        /// <summary>
        /// Medium, marks squares around hits
        /// </summary>
        Medium,

        /// <summary>
        /// As medium, but removes shots once it misses
        /// </summary>
        Hard
    }

}