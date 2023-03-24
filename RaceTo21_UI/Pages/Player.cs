using System;
using System.Collections.Generic;

namespace RaceTo21_UI.Pages
{
	public class Player
	{
		public string name { set; get; }
		public List<Card> cards { set; get; } = new List<Card>();
		public PlayerStatus status { set; get; } = PlayerStatus.active;
		public int score { set; get; }
		public int points { set; get; } = 0;

		public Player(string n)
		{
			name = n;
        }

		/* Introduces player by name
		 * Called by CardTable object
		 */
		public void Introduce(int playerNum)
		{
			Console.WriteLine("Hello, my name is " + name + " and I am player #" + playerNum);
		}
	}
}

