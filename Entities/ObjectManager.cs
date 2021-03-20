using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;
using Races.Objects;



namespace Races.Entities
{
    class ObjectManager
    {
        private int gridSize;
        private SpriteManager spriteManager;

        public List<Collider> colliders = new List<Collider>();
        public List<ItemObject> itemObjects = new List<ItemObject>();

        public void Initialize(SpriteManager spriteManager, int gridSize)
        {
            this.spriteManager = spriteManager;
            this.gridSize = gridSize;

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(ItemObject itemObj in itemObjects)
            {
                spriteBatch.Draw(itemObj.item.texture, itemObj.rect, Color.White);
            }
            
        }
    }
}
