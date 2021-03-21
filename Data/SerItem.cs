using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;

namespace Races.Data
{
    [System.Serializable]
    class SerItem
    {
        public string name;
        public int rarity;
        public int texture;

        public SerItem(string name, int rarity, int texture)
        {
            this.name = name;
            this.rarity = rarity;
            this.texture = texture;
        }

    }
}
