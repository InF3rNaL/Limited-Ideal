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
        Rectangle playerBox, terrainSection1, terrainSection2, terrainSection3, terrainSection4, terrainSection5, terrainSection6, terrainSection7, terrainSection8, terrainSection9, terrainSection10, terrainSection11, terrainSection12, backgroundTwo, backgroundThree, backgroundFour, backgroundFive, backgroundSix, backgroundSeven, backgroundEight, backgroundNine, backgroundTen, backgroundEleven;
        private Color[] terrain, terrain2, terrain3, terrain4, terrain5, terrain6, terrain7, terrain8, terrain9, terrain10, terrain11, terrain12, background2, background3, background4, background5, background6, background7, background8, background9, background0, background1;

        public void createBoundingBox (Player a, Level2 b, Background c)
        {
            terrainSection1 = new Rectangle((int)(b.TerrainOne.X), (int)(b.TerrainOne.Y),(int) (b.Width),(int) (b.Height));
            terrainSection2 = new Rectangle((int)(b.TerrainTwo.X), (int)(b.TerrainTwo.Y), (int)(b.Width), (int)(b.Height));
            terrainSection3 = new Rectangle((int)(b.TerrainThree.X), (int)(b.TerrainThree.Y), (int)(b.Width), (int)(b.Height));
            terrainSection4 = new Rectangle((int)(b.TerrainFour.X), (int)(b.TerrainFour.Y), (int)(b.Width), (int)(b.Height));
            terrainSection5 = new Rectangle((int)(b.TerrainFive.X), (int)(b.TerrainFive.Y), (int)(b.Width), (int)(b.Height));
            terrainSection6 = new Rectangle((int)(b.TerrainSix.X), (int)(b.TerrainSix.Y), (int)(b.Width), (int)(b.Height));
            terrainSection7 = new Rectangle((int)(b.TerrainSeven.X), (int)(b.TerrainSeven.Y), (int)(b.Width), (int)(b.Height));
            terrainSection8 = new Rectangle((int)(b.TerrainEight.X), (int)(b.TerrainEight.Y), (int)(b.Width), (int)(b.Height));
            terrainSection9 = new Rectangle((int)(b.TerrainNine.X), (int)(b.TerrainNine.Y), (int)(b.Width), (int)(b.Height));
            terrainSection10 = new Rectangle((int)(b.TerrainTen.X), (int)(b.TerrainTen.Y), (int)(b.Width), (int)(b.Height));
            terrainSection11 = new Rectangle((int)(b.TerrainEleven.X), (int)(b.TerrainEleven.Y), (int)(b.Width), (int)(b.Height));
            terrainSection12 = new Rectangle((int)(b.TerrainTwelve.X), (int)(b.TerrainTwelve.Y), (int)(b.Width), (int)(b.Height));
            backgroundTwo = new Rectangle((int)(c.TerrainTwo.X), (int)(c.TerrainTwo.Y), (int)(c.Width), (int)(c.Height));
            backgroundThree = new Rectangle((int)(c.TerrainThree.X), (int)(c.TerrainThree.Y), (int)(c.Width), (int)(c.Height));
            backgroundFour = new Rectangle((int)(c.TerrainFour.X), (int)(c.TerrainFour.Y), (int)(c.Width), (int)(c.Height));
            backgroundFive = new Rectangle((int)(c.TerrainFive.X), (int)(c.TerrainFive.Y), (int)(c.Width), (int)(c.Height));
            backgroundSix = new Rectangle((int)(c.TerrainSix.X), (int)(c.TerrainSix.Y), (int)(c.Width), (int)(c.Height));
            backgroundSeven = new Rectangle((int)(c.TerrainSeven.X), (int)(c.TerrainSeven.Y), (int)(c.Width), (int)(c.Height));
            backgroundEight = new Rectangle((int)(c.TerrainEight.X), (int)(c.TerrainEight.Y), (int)(c.Width), (int)(c.Height));
            backgroundNine = new Rectangle((int)(c.TerrainNine.X), (int)(c.TerrainNine.Y), (int)(c.Width), (int)(c.Height));
            backgroundTen = new Rectangle((int)(c.TerrainTen.X), (int)(c.TerrainTen.Y), (int)(c.Width), (int)(c.Height));
            backgroundEleven = new Rectangle((int)(c.TerrainEleven.X), (int)(c.TerrainEleven.Y), (int)(c.Width), (int)(c.Height));
            
        }
        public void createPlayerBox(Player a)
        {
            playerBox = new Rectangle((int)a.getPosition.X, (int)a.getPosition.Y, (int)a.Width, (int)a.Height);
        }
        public void loadTextureData (Level2 A, Background B)
        {
            terrain = new Color[(int)(A.Width * A.Height)];
            A.terrain.GetData(terrain);
            terrain2 = new Color[(int) (A.Width * A.Height)];
            A.terrain2.GetData(terrain2);
            terrain3 = new Color[(int)(A.Width * A.Height)];
            A.terrain3.GetData(terrain3);
            terrain4 = new Color[(int)(A.Width * A.Height)];
            A.terrain4.GetData(terrain4);
            terrain5 = new Color[(int)(A.Width * A.Height)];
            A.terrain5.GetData(terrain5);
            terrain6 = new Color[(int)(A.Width * A.Height)];
            A.terrain6.GetData(terrain6);
            terrain7 = new Color[(int)(A.Width * A.Height)];
            A.terrain7.GetData(terrain7);
            terrain8 = new Color[(int)(A.Width * A.Height)];
            A.terrain8.GetData(terrain8);
            terrain9 = new Color[(int)(A.Width * A.Height)];
            A.terrain9.GetData(terrain9);
            terrain10 = new Color[(int)(A.Width * A.Height)];
            A.terrain10.GetData(terrain10);
            terrain11 = new Color[(int)(A.Width * A.Height)];
            A.terrain11.GetData(terrain11);
            terrain12 = new Color[(int)(A.Width * A.Height)];
            A.terrain12.GetData(terrain12);
            background2 = new Color[(int)(B.Width * B.Height)];
            B.terrain2.GetData(background2);
            background3 = new Color[(int)(B.Width * B.Height)];
            B.terrain3.GetData(background3);
            background4 = new Color[(int)(B.Width * B.Height)];
            B.terrain4.GetData(background4);
            background5 = new Color[(int)(B.Width * B.Height)];
            B.terrain5.GetData(background5);
            background6 = new Color[(int)(B.Width * B.Height)];
            B.terrain6.GetData(background6);
            background7 = new Color[(int)(B.Width * B.Height)];
            B.terrain7.GetData(background7);
            background8 = new Color[(int)(B.Width * B.Height)];
            B.terrain8.GetData(background8);
            background9 = new Color[(int)(B.Width * B.Height)];
            B.terrain9.GetData(background9);
            background0 = new Color[(int)(B.Width * B.Height)];
            B.terrain10.GetData(background0);
            background1 = new Color[(int)(B.Width * B.Height)];
            B.terrain11.GetData(background1);            
        }
        public bool foregroundCollision(Player A, Level2 B)
        {
            createPlayerBox(A);
            if (playerBox.Intersects(terrainSection1))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainOne.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainOne.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainOne.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainOne.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain[(x - terrainSection1.X) + (y - terrainSection1.Y) * terrainSection1.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection2))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainTwo.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainTwo.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainTwo.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainTwo.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain2[(x - terrainSection2.X) + (y - terrainSection2.Y) * terrainSection2.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection3))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainThree.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainThree.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainThree.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainThree.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain3[(x - terrainSection3.X) + (y - terrainSection3.Y) * terrainSection3.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection4))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainFour.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainFour.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainFour.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainFour.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain4[(x - terrainSection4.X) + (y - terrainSection4.Y) * terrainSection4.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection5))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainFive.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainFive.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainFive.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainFive.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain5[(x - terrainSection5.X) + (y - terrainSection5.Y) * terrainSection5.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection6))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainSix.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainSix.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainSix.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainSix.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain6[(x - terrainSection6.X) + (y - terrainSection6.Y) * terrainSection6.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection7))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainSeven.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainSeven.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainSeven.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainSeven.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain7[(x - terrainSection7.X) + (y - terrainSection7.Y) * terrainSection7.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection8))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainEight.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainEight.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainEight.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainEight.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain8[(x - terrainSection8.X) + (y - terrainSection8.Y) * terrainSection8.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection9))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainNine.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainNine.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainNine.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainNine.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain9[(x - terrainSection9.X) + (y - terrainSection9.Y) * terrainSection9.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection10))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainTen.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainTen.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainTen.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainTen.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain10[(x - terrainSection10.X) + (y - terrainSection10.Y) * terrainSection10.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection11))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainEleven.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainEleven.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainEleven.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainEleven.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain11[(x - terrainSection11.X) + (y - terrainSection11.Y) * terrainSection11.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(terrainSection12))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainTwelve.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainTwelve.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainTwelve.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainTwelve.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = terrain12[(x - terrainSection12.X) + (y - terrainSection12.Y) * terrainSection12.Width];
                        if (b.R == 68 || b.G == 69 || b.B == 72 || b.R == 55 || b.G == 62 || b.R == 76 || b.R == 52 || b.G == 58 || b.B == 71 || b.R == 83 || b.G == 88 || b.B == 84 || b.R == 53 || b.G == 59 || b.R == 75)
                        {
                            return true;
                        }
                    }
            }
            if (playerBox.Y + playerBox.Height >= terrainSection1.Y + terrainSection1.Height)
                return true;
            if (playerBox.Y <= terrainSection1.Y)
                return true;
            return false;
        }
        public bool backgroundCollision(Player A, Background B)
        {
            createPlayerBox(A);
            if (playerBox.Intersects(backgroundTwo))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainTwo.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainTwo.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainTwo.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainTwo.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background2[(x - backgroundTwo.X) + (y - backgroundTwo.Y) * backgroundTwo.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundThree))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainThree.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainThree.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainThree.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainThree.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background3[(x - backgroundThree.X) + (y - backgroundThree.Y) * backgroundThree.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundFour))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainFour.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainFour.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainFour.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainFour.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background4[(x - backgroundFour.X) + (y - backgroundFour.Y) * backgroundFour.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundFive))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainFive.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainFive.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainFive.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainFive.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background5[(x - backgroundFive.X) + (y - backgroundFive.Y) * backgroundFive.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundSix))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainTwo.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainSix.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainSix.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainSix.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background6[(x - backgroundSix.X) + (y - backgroundSix.Y) * backgroundSix.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundSeven))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainSeven.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainSeven.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainSeven.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainSeven.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background7[(x - backgroundSeven.X) + (y - backgroundSeven.Y) * backgroundSeven.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundEight))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainEight.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainEight.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainEight.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainEight.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background8[(x - backgroundEight.X) + (y - backgroundEight.Y) * backgroundEight.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundNine))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainNine.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainNine.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainNine.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainNine.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background9[(x - backgroundNine.X) + (y - backgroundNine.Y) * backgroundNine.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundTen))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainTen.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainTen.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainTen.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainTen.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background0[(x - backgroundTen.X) + (y - backgroundTen.Y) * backgroundTen.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            else if (playerBox.Intersects(backgroundEleven))
            {
                Color[] dataA = new Color[A.getTexture.Width * A.getTexture.Height];
                A.getTexture.GetData(dataA);
                var x1 = Math.Max(playerBox.X, (int)B.TerrainEleven.X);
                var x2 = Math.Min(playerBox.X + playerBox.Width, B.TerrainEleven.X + B.Width);

                var y1 = Math.Max(playerBox.Y, (int)B.TerrainEleven.Y);
                var y2 = Math.Min(playerBox.Y + playerBox.Height, B.TerrainEleven.Y + B.Height);
                for (int y = y1; y < y2; y++)
                    for (int x = x1; x < x2; x++)
                    {
                        Color a = dataA[(x - playerBox.X) + (y - playerBox.Y) * playerBox.Width];
                        Color b = background1[(x - backgroundEleven.X) + (y - backgroundEleven.Y) * backgroundEleven.Width];
                        if (b.R == 29 || b.G == 30 || b.B == 33)
                        {
                            return true;
                        }
                    }
            }
            if (playerBox.Y + playerBox.Height >= backgroundTwo.Y + backgroundTwo.Height)
                return true;
            if (playerBox.Y <= backgroundTwo.Y)
                return true;
            return false;
        }
    }
    
}
    