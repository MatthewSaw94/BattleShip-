
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data;
using System.Diagnostics;

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
}