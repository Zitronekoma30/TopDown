using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Races.Entities;
using Races.Data;

namespace Races.GUI
{
    static class GUIManager
    {

        static public void DrawInventory(SpriteBatch spriteBatch, Player player)
        {
            InventorySlot[] inventorySlots = new InventorySlot[player.inventory.Length];
            for(int i=0; i < player.inventory.Length; i++)
            {
                if(player.inventory[i] != null)
                {
                    inventorySlots[i] = new InventorySlot(SpriteManager.inventorySlot, player.inventory[i].texture);
                }
                else
                {
                    inventorySlots[i] = new InventorySlot(SpriteManager.inventorySlot, SpriteManager.inventorySlot);
                }
                
            }

            inventorySlots[0].Draw(spriteBatch, new Rectangle(10, 10, 64, 64));
            inventorySlots[0].Draw(spriteBatch, new Rectangle(10, 85, 32, 32));
            inventorySlots[0].Draw(spriteBatch, new Rectangle(10, 130, 32, 32));
        }


    }
}
