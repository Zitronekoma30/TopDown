using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Races.Objects;
using Races.Data;
using System.Xml;


namespace Races.Entities
{
    class Player
    {
        public Rectangle rect;
        private Color color;
        private int gridSize;
        private FloorManager floorManager;
        private ObjectManager objectManager;


        private Rectangle srcRect;

        private bool active = true;

        public Item[] inventory = new Item[3] {null, null, null};

        #region animation
        private int atlasX;
        private int atlasY;
        private int spriteSizeX;
        private int spriteSizeY;

        private int animationFrame = 0;
        private int animationTime;

        private int animationX = 0;
        private int animationY = 0;
        #endregion

        #region positioning
        private int positionX;
        private int positionY;

        private int hsp;
        private int vsp;

        private string currentLevelName = "template";

        private int walkSpeed = 3;
        #endregion

        private enum State
        {
            Idle,
            Carrying,
            Attacking
        }

        private State state;

        public void Initialize(Rectangle rect, Color color, int gridSize, FloorManager floorManager, ObjectManager objectManager)
        {
            this.rect = rect;
            this.color = color;
            this.gridSize = gridSize;
            this.floorManager = floorManager;
            this.objectManager = objectManager;

            this.positionX = rect.X;
            this.positionY = rect.Y;

            this.atlasX = 0;
            this.atlasY = 0;

            this.spriteSizeX = gridSize/2;
            this.spriteSizeY = gridSize;

            this.srcRect = new Rectangle(0, 0, 16 * atlasX, 32 * atlasY);

            this.floorManager.SwitchLevel(currentLevelName);

            

        }

        public void Update()
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (active)
            {
                HandleMovement(keyboardState);
                HandleInput(keyboardState);


                rect = new Rectangle(positionX, positionY, rect.Width, rect.Height);
            }
        }

        private void HandleInput(KeyboardState keyboardState)
        {
            if (keyboardState.IsKeyDown(Keys.V))
            {
                SaveSystem.SavePlayer(this);
            }
            if (keyboardState.IsKeyDown(Keys.B))
            {
                PlayerSave data = SaveSystem.LoadPlayer();
                positionX = data.position[0];
                positionY = data.position[1];
            }
            if (keyboardState.IsKeyDown(Keys.C))
            {
                objectManager.SpawnItem(new Item("Crystal", 2, SpriteManager.sprItems[0]), new Rectangle(positionX + 50, positionY, gridSize, gridSize));
            }
        }

        private void HandleMovement(KeyboardState keyboardState)
        {
            

            if (keyboardState.IsKeyDown(Keys.D))
            {
                hsp = 1;
            }
            if (keyboardState.IsKeyDown(Keys.A))
            {
                hsp = -1;
            }
            if(keyboardState.IsKeyDown(Keys.D) && keyboardState.IsKeyDown(Keys.A))
            {
                hsp = 0;
            }

            if (keyboardState.IsKeyDown(Keys.W))
            {
               vsp = -1; 
            }
            if (keyboardState.IsKeyDown(Keys.S))
            {
                vsp = 1;
            }
            if (keyboardState.IsKeyDown(Keys.W) && keyboardState.IsKeyDown(Keys.S))
            {
                vsp = 0;
            }

            if(hsp != 0 && vsp != 0)
            {
                walkSpeed = 2;
            }
            else
            {
                walkSpeed = 3;
            }


            Collision();

            positionX += hsp * walkSpeed;
            positionY += vsp * walkSpeed;

            Animate();

            hsp = 0;
            vsp = 0;




        }

        private void Collision()
        {
            
            foreach(Collider collider in objectManager.colliders)
            {
                if (new Rectangle(rect.X + hsp * 2, rect.Y, rect.Width, rect.Height).Intersects(collider.rect))
                {
                    hsp = 0;
                }
                if (new Rectangle(rect.X, rect.Y + vsp*2, rect.Width, rect.Height).Intersects(collider.rect))
                {
                    vsp = 0;
                }
            }

            foreach(ItemObject itemObj in objectManager.itemObjects)
            {
                if (rect.Intersects(itemObj.rect) && itemObj.active && itemObj.item.name == "Crystal")
                {
                    AddItemToInventory(itemObj, SoundManager.itemPickup[0]);

                }
            }

        }

        private void AddItemToInventory(ItemObject itemObj, SoundEffectInstance sfxInst)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] == null)
                {
                    itemObj.active = !active;
                    inventory[i] = itemObj.item;
                    SoundManager.PlaySound(sfxInst);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (active)
            {
                this.srcRect = new Rectangle(0 + atlasX, 0 + atlasY, spriteSizeX, spriteSizeY);

                spriteBatch.Draw(SpriteManager.sprPlayer, rect, srcRect, color);

                //debug drawing
                //spriteBatch.Draw(spriteManager.whitePixel, new Rectangle(positionX, positionY, 5, 5), Color.Red);
                //spriteBatch.Draw(spriteManager.whitePixel, new Rectangle(collisionPointX, positionY, 5, 5), Color.Blue);
                //spriteBatch.Draw(spriteManager.whitePixel, new Rectangle(positionX, collisionPointY, 5, 5), Color.Violet);
            }

        }

        private void Animate()
        {

            if(hsp == 0 && vsp == 0 && state != State.Attacking && state != State.Carrying)
            {
                animationX = 0;
                if (animationY > 3) animationY = 0;
                animationFrame = 0;
                animationTime = 0;
                state = State.Idle;
            }

            if (vsp > 0 && state != State.Attacking && state != State.Carrying)
            {
                animationX = 0;
                animationY = 0;

            }
            else if (vsp < 0 && state != State.Attacking && state != State.Carrying)
            {
                animationX = 0;
                animationY = 2;
            }
            
            if (hsp > 0 && state != State.Attacking && state != State.Carrying)
            {
                animationX = 0;
                animationY = 1;
            }
            else if (hsp < 0 && state != State.Attacking && state != State.Carrying)
            {
                animationX = 0;
                animationY = 3;
            }


            
            animationTime++;
            if (animationTime > 10)
            {
                animationTime = 0;
                animationFrame++;
            }
            if (animationFrame >= 4) animationFrame = 0;

            atlasX = animationX*gridSize/2 + animationFrame * gridSize/2;
            atlasY = animationY*gridSize;

        }

        public void ToggleActive() {active = !active;}
    }
}
