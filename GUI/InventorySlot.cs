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
    class InventorySlot
    {
        private Texture2D background;
        private Texture2D item;

        public InventorySlot(Texture2D background, Texture2D item)
        {
            this.background = background;
            this.item = item;
        }

        public void Draw(SpriteBatch spriteBatch, Rectangle rect)
        {
            spriteBatch.Draw(background, rect, Color.White);
            spriteBatch.Draw(item, rect, Color.White);

            
        }


    }
}
