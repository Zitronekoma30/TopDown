using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;

namespace Races.Objects
{
    class Collider
    {
        public Rectangle rect;

        public Collider(Rectangle rect)
        {
            this.rect = rect;
        }
    }
}

