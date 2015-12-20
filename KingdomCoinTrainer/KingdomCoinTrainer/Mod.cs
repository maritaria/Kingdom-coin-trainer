using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lean;
using UnityEngine;

namespace KingdomCoinTrainer
{
    public class Mod
    {
		public static void Load()
		{
			//It's nice that they have put all the important stuff in public static variables :D
			//That made this whole thing a lot easier
			Kingdom kingdomGame = Controllers.kingdom;

			Player player = kingdomGame.player;
			for(int i = 0; i < 100; i++)
			{
				GiveCoin(player);
			}
		}

		public static void Unload()
		{
		}

		private static void GiveCoin(Player player)
		{
			Coin coin = CreateCoin();
			//Make the coin drop from the player, and make sure only the player can pick it up the first time
			coin.Drop(player.gameObject, new Vector2(0, 5), new Vector2(), Droppable.PickUpPolicy.OnlyReceiver);
			coin.goodReceiver = player.gameObject;
			//In the end the player instantly picks up the coin, probably because some cooldown isnt set by us
		}

		private static Coin CreateCoin()
		{
			return LeanPool.Spawn<Coin>(Controllers.holder.coinPrefab);
		}
    }
}
