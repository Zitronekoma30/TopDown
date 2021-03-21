using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Races.Entities;
using Races.Data;

namespace Races
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Player player = new Player();

        //Manager Classes
        private FloorManager floorManager = new FloorManager();
        private ObjectManager objectManager = new ObjectManager();

        

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            
            //Sprites 
            SpriteManager.whitePixel = Content.Load<Texture2D>("WhitePixel");
            SpriteManager.sprPlayer = Content.Load<Texture2D>("Sprites/character");

            SpriteManager.sprmapOutside = Content.Load<Texture2D>("Sprites/Outside");

            SpriteManager.inventorySlot = Content.Load<Texture2D>("Sprites/InventorySlot");

            #region ItemSprites
            SpriteManager.sprItems[0] = Content.Load<Texture2D>("Sprites/Crystal");
            #endregion

            //Sounds

            SoundManager.itemPickup[0] = Content.Load<SoundEffect>("Sounds/Glass").CreateInstance();

            //Entities
            objectManager.Initialize(32);
            floorManager.Initialize(objectManager, 32);

            player.Initialize(new Rectangle(1, 1, 32, 32*2), Color.White, 32, floorManager, objectManager);
        }

        protected override void Update(GameTime gameTime)
        {
            //KeyboardState keyboardState = Keyboard.GetState();
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player.Update();

            

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Green);

            // TODO: Add your drawing code here
            SpriteBatch spriteBatch = new SpriteBatch(GraphicsDevice);

            spriteBatch.Begin(SpriteSortMode.Deferred, null, SamplerState.PointClamp);

            floorManager.Draw(spriteBatch);
            objectManager.Draw(spriteBatch);
            player.Draw(spriteBatch);

            spriteBatch.End();
            
            
            base.Draw(gameTime);
        }
    }
}
