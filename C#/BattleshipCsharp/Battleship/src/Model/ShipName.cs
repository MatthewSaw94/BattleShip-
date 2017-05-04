/// <summary>
/// A Ship has all the details about itself. For example the shipname,
/// size, number of hits taken and the location. Its able to add tiles,
/// remove, hits taken and if its deployed and destroyed.
/// </summary>
/// <remarks>
/// Deployment information is supplied to allow ships to be drawn.
/// </remarks>
namespace Battleship
{
    public enum ShipName
    {
        None = 0,
        Tug = 1,
        Submarine = 2,
        Destroyer = 3,
        Battleship = 4,
        AircraftCarrier = 5
    }
}