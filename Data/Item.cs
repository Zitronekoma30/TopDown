using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;

namespace Races.Data
{
    class Item
    {
        public string name;
        public int rarity;
        public Texture2D texture;
        public SpriteManager spriteManager;

        public void Initialize(string name, int rarity, Texture2D texture, SpriteManager spriteManager)
        {
            this.name = name;
            this.rarity = rarity;
            this.texture = texture;
            this.spriteManager = spriteManager;
        }

    }
}
