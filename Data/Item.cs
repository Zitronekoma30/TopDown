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

        public Item(string name, int rarity, Texture2D texture)
        {
            this.name = name;
            this.rarity = rarity;
            this.texture = texture;
        }

    }
}
