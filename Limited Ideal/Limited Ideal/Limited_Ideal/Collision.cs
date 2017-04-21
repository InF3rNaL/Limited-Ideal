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
    class Collision
    {
        Color[] colors1D;
        Color[,] colors2D;
        public void textureto2DArray(Texture2D texture)
        {
            colors1D = new Color[texture.Width * texture.Height];
            texture.GetData(colors1D);
            colors2D = new Color[texture.Width, texture.Height];
            for (int x = 0; x < texture.Width; x++)
                for (int y = 0; y < texture.Height; y++)
                    colors2D[x, y] = colors1D[x + y * texture.Width];
        }
        static bool IntersectPixels(Rectangle player, int R, int G, int B)
        {
            

            return false;
        }
    }
}
