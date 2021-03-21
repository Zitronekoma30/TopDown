using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;
using Races.Data;

namespace Races.Objects
{
    class ItemObject
    {
        public Item item;
        public Rectangle rect;

        public bool active;
        
        public ItemObject(Item item, Rectangle rect, bool active)
        {
            this.item = item;
            this.rect = rect;
            this.active = active;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (active)
            {
                spriteBatch.Draw(item.texture, rect, Color.White);
            }
            
        }
    
    }
}
