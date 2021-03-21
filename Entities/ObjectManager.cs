using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;
using Races.Objects;
using Races.Data;



namespace Races.Entities
{
    class ObjectManager
    {
        private int gridSize;

        public List<Collider> colliders = new List<Collider>();
        public List<ItemObject> itemObjects = new List<ItemObject>();

        public void Initialize(int gridSize)
        {
            this.gridSize = gridSize;

        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach(ItemObject itemObj in itemObjects)
            {
                itemObj.Draw(spriteBatch);
            }
            
        }

        public void SpawnItem(Item item, Rectangle rect)
        {
            itemObjects.Add(new ItemObject(item, rect, true));
        }
    }
}
