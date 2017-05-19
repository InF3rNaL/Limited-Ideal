using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Limited_Ideal
{
    class Background
    {
        private Texture2D Terrain2, Terrain3, Terrain4, Terrain5, Terrain6, Terrain7, Terrain8, Terrain9, Terrain10, Terrain11;
        private Vector2 terrainTwo, terrainThree, terrainFour, terrainFive, terrainSix, terrainSeven, terrainEight, terrainNine, terrainTen, terrainEleven;
        private float scale;

        public float Scale
        {
            get { return scale; }
            set { scale = value; }
        }
        
        public Texture2D terrain2
        {
            get { return Terrain2; }
            set { Terrain2 = value; }
        }
        public Vector2 TerrainTwo
        {
            get { return terrainTwo; }
            set { terrainTwo = value; }
        }
        public Texture2D terrain3
        {
            get { return Terrain3; }
            set { Terrain3 = value; }
        }
        public Vector2 TerrainThree
        {
            get { return terrainThree; }
            set { terrainThree = value; }
        }
        public Texture2D terrain4
        {
            get { return Terrain4; }
            set { Terrain4 = value; }
        }
        public Vector2 TerrainFour
        {
            get { return terrainFour; }
            set { terrainFour = value; }
        }
        public Texture2D terrain5
        {
            get { return Terrain5; }
            set { Terrain5 = value; }
        }
        public Vector2 TerrainFive
        {
            get { return terrainFive; }
            set { terrainFive = value; }
        }
        public Texture2D terrain6
        {
            get { return Terrain6; }
            set { Terrain6 = value; }
        }
        public Vector2 TerrainSix
        {
            get { return terrainSix; }
            set { terrainSix = value; }
        }
        public Texture2D terrain7
        {
            get { return Terrain7; }
            set { Terrain7 = value; }
        }
        public Vector2 TerrainSeven
        {
            get { return terrainSeven; }
            set { terrainSeven = value; }
        }
        public Texture2D terrain8
        {
            get { return Terrain8; }
            set { Terrain8 = value; }
        }
        public Vector2 TerrainEight
        {
            get { return terrainEight; }
            set { terrainEight = value; }
        }
        public Texture2D terrain9
        {
            get { return Terrain9; }
            set { Terrain9 = value; }
        }
        public Vector2 TerrainNine
        {
            get { return terrainNine; }
            set { terrainNine = value; }
        }
        public Texture2D terrain10
        {
            get { return Terrain10; }
            set { Terrain10 = value; }
        }
        public Vector2 TerrainTen
        {
            get { return terrainTen; }
            set { terrainTen = value; }
        }
        public Texture2D terrain11
        {
            get { return Terrain11; }
            set { Terrain11 = value; }
        }
        public Vector2 TerrainEleven
        {
            get { return terrainEleven; }
            set { terrainEleven = value; }
        }
        public float Height
        {
            get { return terrain2.Height * scale; }
        }
        public float Width
        {
            get { return terrain2.Width * scale; }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(terrain2, TerrainTwo, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain3, TerrainThree, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain4, TerrainFour, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain5, TerrainFive, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain6, TerrainSix, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain7, TerrainSeven, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain8, TerrainEight, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain9, TerrainNine, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain10, TerrainTen, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain11, TerrainEleven, null, Color.White, 0, Vector2.Zero, scale, SpriteEffects.None, 0);
        }

    }
}

