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
        private SpriteManager spriteManager;

        public List<Collider> colliders = new List<Collider>();
        public List<ItemObject> itemObjects = new List<ItemObject>();
        public Item[] items = new Item[50];

        public void Initialize(SpriteManager spriteManager, int gridSize)
        {
            this.spriteManager = spriteManager;
            this.gridSize = gridSize;

            #region define Items
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = new Item();
                switch (i)
                {
                    case 0:
                        items[0].Initialize("Crystal", 2, spriteManager.sprItems[0]);
                        break;
                }
                
            }

            #endregion

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

        public void SpawnItem(int index, Rectangle rect)
        {
            itemObjects.Add(new ItemObject(items[index], rect, true));
        }
    }
}
