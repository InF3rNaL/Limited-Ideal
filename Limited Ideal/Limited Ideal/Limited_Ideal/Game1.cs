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
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Vector2 Velocity;
        GameState gameState, previousgameState;
        terrainLevel level;
        Player player;
        Camera camera;
        Level2 level2;
        Collision collides;
        bool isJumping;
        float jumpSpeed;
        Background background;
        KeyboardState previouskeyState;
        Texture2D backlight1, backlight2, backlight3, backlight4, backlight5; 

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            graphics.PreferredBackBufferHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            graphics.IsFullScreen = true;
        }
        enum GameState
        {
            mainMenu,
            newGame,
            levelSelect,
            Playing,
            Paused
        }
        enum terrainLevel
        {
            Foreground,
            Background
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            Velocity = Vector2.Zero;
            player = new Player();
            level2 = new Level2();
            background = new Background();
            collides = new Collision();
            camera = new Camera(new Rectangle (GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height));
            player.getPosition = new Vector2(10, 400);
            camera.Pos = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
            gameState = GameState.Playing;
            level = terrainLevel.Foreground;
            isJumping = false;
            jumpSpeed = 0;
            previouskeyState = Keyboard.GetState();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            level2.terrain = Content.Load<Texture2D>("1_ForegroundAlt");
            level2.terrain2 = Content.Load<Texture2D>("2_ForegroundAlt");
            level2.terrain3 = Content.Load<Texture2D>("3_ForegroundAlt");
            level2.terrain4 = Content.Load<Texture2D>("4_ForegroundAlt");
            level2.terrain5 = Content.Load<Texture2D>("5_ForegroundAlt");
            level2.terrain6 = Content.Load<Texture2D>("6_ForegroundAlt");
            level2.terrain7 = Content.Load<Texture2D>("7_ForegroundAlt");
            level2.terrain8 = Content.Load<Texture2D>("8_ForegroundAlt");
            level2.terrain9 = Content.Load<Texture2D>("9_ForegroundAlt");
            level2.terrain10 = Content.Load<Texture2D>("10_ForegroundAlt");
            level2.terrain11 = Content.Load<Texture2D>("11_ForegroundAlt");
            level2.terrain12 = Content.Load<Texture2D>("12_Foreground");
            background.terrain2 = Content.Load<Texture2D>("2_Background");
            background.terrain3 = Content.Load<Texture2D>("3_Background");
            background.terrain4 = Content.Load<Texture2D>("4_Background");
            background.terrain5 = Content.Load<Texture2D>("5_Background");
            background.terrain6 = Content.Load<Texture2D>("6_Background");
            background.terrain7 = Content.Load<Texture2D>("7_Background");
            background.terrain8 = Content.Load<Texture2D>("8_Background");
            background.terrain9 = Content.Load<Texture2D>("9_Background");
            background.terrain10 = Content.Load<Texture2D>("10_Background");
            background.terrain11 = Content.Load<Texture2D>("11_Background");
            player.getTexture = Content.Load<Texture2D>("PlayerModel");
            backlight1 = Content.Load<Texture2D>("1_Backlight");
            backlight2 = Content.Load<Texture2D>("2_Backlight");
            backlight3 = Content.Load<Texture2D>("3_Backlight");
            backlight4 = Content.Load<Texture2D>("10_Backlight");
            backlight5 = Content.Load<Texture2D>("11_Backlight");

            
            level2.Scale = level2.terrain.Height / GraphicsDevice.Viewport.Height;
            background.Scale = level2.Scale;
            player.Scale = .07f * (level2.terrain.Height / GraphicsDevice.Viewport.Height);

            level2.TerrainOne = new Vector2(0, -(level2.Width / 8));
            level2.TerrainTwo = new Vector2(level2.terrain.Width, -(level2.Width / 8));
            level2.TerrainThree = new Vector2(level2.TerrainTwo.X + level2.Width, -(level2.Width / 8));
            level2.TerrainFour = new Vector2(level2.TerrainThree.X + level2.Width, -(level2.Width / 8));
            level2.TerrainFive = new Vector2(level2.TerrainFour.X + level2.Width, -(level2.Width / 8));
            level2.TerrainSix = new Vector2(level2.TerrainFive.X + level2.Width, -(level2.Width / 8));
            level2.TerrainSeven = new Vector2(level2.TerrainSix.X + level2.Width, -(level2.Width / 8));
            level2.TerrainEight = new Vector2(level2.TerrainSeven.X + level2.Width, -(level2.Width / 8));
            level2.TerrainNine = new Vector2(level2.TerrainEight.X + level2.Width, -(level2.Width / 8));
            level2.TerrainTen = new Vector2(level2.TerrainNine.X + level2.Width, -(level2.Width / 8));
            level2.TerrainEleven = new Vector2(level2.TerrainTen.X + level2.Width, -(level2.Width / 8));
            level2.TerrainTwelve = new Vector2(level2.TerrainEleven.X + level2.Width, -(level2.Width / 8));
            background.TerrainTwo = new Vector2(level2.TerrainTwo.X, level2.TerrainTwo.Y);
            background.TerrainThree = new Vector2(background.TerrainTwo.X + background.Width, background.TerrainTwo.Y);
            background.TerrainFour = new Vector2(background.TerrainThree.X + background.Width, background.TerrainThree.Y);
            background.TerrainFive = new Vector2(background.TerrainFour.X + background.Width, background.TerrainFour.Y);
            background.TerrainSix = new Vector2(background.TerrainFive.X + background.Width, background.TerrainFive.Y);
            background.TerrainSeven = new Vector2(background.TerrainSix.X + background.Width, background.TerrainSix.Y);
            background.TerrainEight = new Vector2(background.TerrainSeven.X + background.Width, background.TerrainSeven.Y);
            background.TerrainNine = new Vector2(background.TerrainEight.X + background.Width, background.TerrainEight.Y);
            background.TerrainTen = new Vector2(background.TerrainNine.X + background.Width, background.TerrainNine.Y);
            background.TerrainEleven = new Vector2(background.TerrainTen.X + background.Width, background.TerrainTen.Y);

            collides.createBoundingBox(player, level2, background);
            collides.loadTextureData(level2, background);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            KeyboardState currentkeystate = Keyboard.GetState();
            if (currentkeystate.IsKeyDown(Keys.LeftControl) && currentkeystate.IsKeyDown(Keys.Delete))
                this.Exit();
            // Allows the game to exit
            
            if (gameState == GameState.Playing)
            {
                if (level == terrainLevel.Foreground)
                    player.Scale = .07f * (level2.terrain.Height / GraphicsDevice.Viewport.Height);
                else if (level == terrainLevel.Background)
                    player.Scale = .03f * (level2.terrain.Height / GraphicsDevice.Viewport.Height);
                var gravity = .9f;
                if (currentkeystate.IsKeyDown(Keys.A))
                    player.getPosition += new Vector2(-5.0f, 0);
                if (currentkeystate.IsKeyDown(Keys.D))
                    player.getPosition += new Vector2(5.0f, 0);
                if (currentkeystate.IsKeyDown(Keys.W))
                {
                    if (level == terrainLevel.Foreground)
                        if (!isJumping)
                        {
                            isJumping = true;
                            jumpSpeed = -14.5f;
                        }
                    if (level == terrainLevel.Background)
                        if (!isJumping)
                        {
                            isJumping = true;
                            jumpSpeed = -8.0f;
                        }
                }
                if (currentkeystate.IsKeyUp(Keys.E) && previouskeyState.IsKeyDown(Keys.E))
                {
                    if (level == terrainLevel.Foreground)
                    {
                        if (!collides.backgroundCollision(player, background))
                            level = terrainLevel.Background;
                    }
                    else if (level == terrainLevel.Background)
                    {
                        if (!collides.foregroundCollision(player, level2))
                            level = terrainLevel.Foreground;
                    }
                }
                jumpSpeed += gravity;                
                Velocity.Y += jumpSpeed;
                player.getPosition += new Vector2(0, jumpSpeed);
                if (level == terrainLevel.Foreground)
                {
                    if (collides.foregroundCollision(player, level2))
                    {
                        player.getPosition = player.Previous;
                        //commented out due to not working correctly, however, it is the best method I can think of so it's commented out to be revisited later.
                        /*if (jumpSpeed > 0)
                        {
                            player.getPosition += new Vector2(0, -5.0f);
                            if (collides.foregroundCollision(player, level2))
                            {
                                player.getPosition = player.Previous;
                                player.getPosition += new Vector2(0, 5.0f);
                            }
                        }
                        if (jumpSpeed <= 0)
                        {
                            player.getPosition += new Vector2(0, 5.0f);
                            if (collides.foregroundCollision(player, level2))
                            {
                                player.getPosition = player.Previous;
                                player.getPosition += new Vector2(0, -5.0f);
                            }
                        }*/
                        Velocity.Y = 0f;
                        jumpSpeed = 0;
                        isJumping = false;
                    }
                }
                if(level == terrainLevel.Background)
                {
                    if (collides.backgroundCollision(player, background))
                    {
                        player.getPosition = player.Previous;
                        //commented out due to not working correctly, however, it is the best method I can think of so it's commented out to be revisited later.
                        /*if (jumpSpeed > 0)
                        {
                            player.getPosition += new Vector2(0, -5.0f);
                            if (collides.backgroundCollision(player, background))
                            {
                                player.getPosition = player.Previous;
                                player.getPosition += new Vector2(0, 5.0f);
                            }
                        }
                        if (jumpSpeed <= 0)
                        {
                            player.getPosition += new Vector2(0, 5.0f);
                            if (collides.backgroundCollision(player, background))
                            {
                                player.getPosition = player.Previous;
                                player.getPosition += new Vector2(0, -5.0f);
                            }
                        }*/
                        Velocity.Y = 0f;
                        jumpSpeed = 0;
                        isJumping = false;
                    }
                }                    
                Velocity = Vector2.Zero;
                previouskeyState = currentkeystate;
                player.Previous = player.getPosition;
                if (player.getPosition.X < 0)
                    player.getPosition = new Vector2(0, player.getPosition.Y);
                if (player.getPosition.X < GraphicsDevice.Viewport.Width / 2)
                    camera.Pos = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
                else
                {
                    if (player.getPosition.Y + (GraphicsDevice.Viewport.Height / 2) >= level2.TerrainOne.Y + level2.Height)
                        camera.Pos = new Vector2(player.getPosition.X, level2.Height - (level2.Height / 2));
                    else if (player.getPosition.Y - (GraphicsDevice.Viewport.Height / 2) <= level2.TerrainOne.Y)
                        camera.Pos = new Vector2(player.getPosition.X, level2.TerrainOne.Y + (GraphicsDevice.Viewport.Height / 2));
                    else
                        camera.Pos = new Vector2(player.getPosition.X, player.getPosition.Y);
                }
                
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, camera.viewMatrix);
            if (gameState == GameState.Playing)
            {
                spriteBatch.Draw(backlight1, level2.TerrainOne, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight2, level2.TerrainTwo, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainThree, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainFour, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainFive, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainSix, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainSeven, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainEight, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight3, level2.TerrainNine, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight4, level2.TerrainTen, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                spriteBatch.Draw(backlight5, level2.TerrainEleven, null, Color.White, 0, Vector2.Zero, level2.Scale, SpriteEffects.None, 0);
                if (level == terrainLevel.Background)
                    player.Draw(spriteBatch);
                background.Draw(spriteBatch);
                level2.Draw(spriteBatch);
                if (level == terrainLevel.Foreground)
                    player.Draw(spriteBatch);
            }
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
