using System;
using System.Collections.Generic;
using System.Text;
using Races.Entities;

namespace Races.Data
{
    [System.Serializable]
    class PlayerSave
    {
        public int[] position = new int[2];
        public SerItem[] serInventory;

        public PlayerSave(Player player)
        {
            position[0] = player.rect.X;
            position[1] = player.rect.Y;

            serInventory = player.serInventory;
        }
    }
}
