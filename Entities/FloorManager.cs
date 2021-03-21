using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Races.Entities;
using Races.Objects;
using Races.Data;
using System.Collections.Generic;

namespace Races.Entities
{
    class FloorManager
    {
        /* #####Tileset Drawing#####
         * Pattern: center -> bottom left to bottom middler clockwise
         * 
         * 1-9 Grass 
         * 
         * 
         * 
         */

        
        public int[][] currentLevel;
        private int gridSize;
        private ObjectManager objectManager;

        public void Initialize(ObjectManager objectManager, int gridSize)
        {
            this.objectManager = objectManager;
            this.gridSize = gridSize;

            SwitchLevel("template");

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int xOffset = 0;
            int yOffset = 0;

            for(int y = 0; y < currentLevel.Length; y++)
            {
                for(int x = 0; x < currentLevel[y].Length; x++)
                {
                    AssignGrassTiles(ref xOffset, ref yOffset, y, x);
                    AssignWaterTiles(ref xOffset, ref yOffset, y, x);
                    spriteBatch.Draw(SpriteManager.sprmapOutside, new Rectangle((x + 0) * gridSize, (y + 0) * gridSize, gridSize, gridSize), new Rectangle(0 + gridSize / 2 * xOffset, 0 + gridSize / 2 * yOffset, gridSize / 2, gridSize / 2), Color.White);
                    //TODO: Rectangle UUID System for Collision with Player
                    
                }
            }

            /*foreach(Collider collider in objectManager.colliders)
            {
                spriteBatch.Draw(spriteManager.whitePixel, collider.rect, Color.Red);
            }*/
        }

        public void SwitchLevel(string levelName)
        {
            switch (levelName)
            {
                case "template":
                    currentLevel = Level.template;
                    break;

                default:
                    currentLevel = Level.start;
                    break;

            }


            CreateColliders();
        }

        private void AssignGrassTiles(ref int xOffset, ref int yOffset, int y, int x)
        {
            switch (currentLevel[y][x])
            {
                case 0:
                    //Grass
                    xOffset = 0;
                    yOffset = 0;
                    break;

                case 1:
                    /*Path
                     *  x x x
                     *  x o x
                     *  x x x
                     */

                    xOffset = 1;
                    yOffset = 4;
                    break;
                case 2:
                    /*Path
                     *  x x x
                     *  x x x
                     *  o x x
                     */

                    xOffset = 0;
                    yOffset = 5;
                    break;
                case 3:
                    /*Path
                     *  x x x
                     *  o x x
                     *  x x x
                     */

                    xOffset = 0;
                    yOffset = 4;
                    break;
                case 4:
                    /*Path
                     *  o x x
                     *  x x x
                     *  x x x
                     */

                    xOffset = 0;
                    yOffset = 3;
                    break;
                case 5:
                    /*Path
                     *  x o x
                     *  x x x
                     *  x x x
                     */

                    xOffset = 1;
                    yOffset = 3;
                    break;
                case 6:
                    /*Path
                     *  x x o
                     *  x x x
                     *  x x x
                     */

                    xOffset = 2;
                    yOffset = 3;
                    break;
                case 7:
                    /*Path
                     *  x x x
                     *  x x o
                     *  x x x
                     */

                    xOffset = 2;
                    yOffset = 4;
                    break;
                case 8:
                    /*Path
                     *  x x x
                     *  x x x
                     *  x x o
                     */

                    xOffset = 2;
                    yOffset = 5;
                    break;
                case 9:
                    /*Path
                     *  x x x
                     *  x x x
                     *  x o x
                     */

                    xOffset = 1;
                    yOffset = 5;
                    break;


            }
        }
        private void AssignWaterTiles(ref int xOffset, ref int yOffset, int y, int x)
        {
            switch (currentLevel[y][x])
            {
                case 10:
                    /*Water
                     *  x x x
                     *  x o x
                     *  x x x
                     */
                    xOffset = 3;
                    yOffset = 7;
                    break;
                case 11:
                    /*Water
                     *  x x x
                     *  x x x
                     *  o x x
                     */
                    xOffset = 2;
                    yOffset = 8;
                    break;
                case 12:
                    /*Water
                     *  x x x
                     *  o x x
                     *  x x x
                     */
                    xOffset = 2;
                    yOffset = 7;
                    break;
                case 13:
                    /*Water
                     *  o x x
                     *  x x x
                     *  x x x
                     */
                    xOffset = 2;
                    yOffset = 6;
                    break;
                case 14:
                    /*Water
                     *  x o x
                     *  x x x
                     *  x x x
                     */
                    xOffset = 3;
                    yOffset = 6;
                    break;
                case 15:
                    /*Water
                     *  x x o
                     *  x x x
                     *  x x x
                     */
                    xOffset = 4;
                    yOffset = 6;
                    break;
                case 16:
                    /*Water
                     *  x x x
                     *  x x o
                     *  x x x
                     */
                    xOffset = 4;
                    yOffset = 7;
                    break;
                case 17:
                    /*Water
                     *  x x x
                     *  x x x
                     *  x x o
                     */
                    xOffset = 4;
                    yOffset = 8;
                    break;
                case 18:
                    /*Water
                     *  x x x
                     *  x x x
                     *  x o x
                     */
                    xOffset = 3;
                    yOffset = 8;
                    break;
            }
        }

        private void CreateColliders()
        {
            objectManager.colliders = new List<Collider>();

            for (int y = 0; y < currentLevel.Length; y++)
            {
                for (int x = 0; x < currentLevel[y].Length; x++)
                {
                    if(currentLevel[y][x] == 10){
                        objectManager.colliders.Add(new Collider(new Rectangle(x*gridSize, y*gridSize, gridSize, gridSize)));
                    }
                }
            }

        }
    }
}
