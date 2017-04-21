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
        Texture2D terrain, terrain2;
        Player player;
        Camera camera;

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
            Midground,
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
            camera = new Camera(new Rectangle (GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height, GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height));
            player.getPosition = new Vector2(10, 600);
            camera.Pos = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
            gameState = GameState.Playing;
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
            terrain = Content.Load<Texture2D>("SampleWorld2");
            terrain2 = Content.Load<Texture2D>("SampleWorld2_4");
            player.getTexture = Content.Load<Texture2D>("PlayerModel");
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
                if (currentkeystate.IsKeyDown(Keys.A))
                    Velocity.X = -5.0f;
                if (currentkeystate.IsKeyDown(Keys.D))
                    Velocity.X = 5.0f;
                if (currentkeystate.IsKeyDown(Keys.W))
                {
                    Velocity.Y = -5.0f;
                }
                if (currentkeystate.IsKeyDown(Keys.S))
                    Velocity.Y = 5.0f;
                if (player.getPosition.X < 0)
                    player.getPosition = new Vector2(0, player.getPosition.Y);
                player.getPosition += Velocity;
                if (player.getPosition.X < GraphicsDevice.Viewport.Width / 2)
                    camera.Pos = new Vector2(GraphicsDevice.Viewport.Width / 2, GraphicsDevice.Viewport.Height / 2);
                else
                    camera.Pos = player.getPosition;
                Velocity = Vector2.Zero;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(new Color(68, 69, 72));
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin(SpriteSortMode.Deferred, null, null, null, null, null, camera.viewMatrix);
            //spriteBatch.Draw(terrain, new Vector2(0, -500), Color.White);
            spriteBatch.Draw(terrain, new Vector2(0, -600), null, Color.White, 0, Vector2.Zero, terrain.Width / 800f, SpriteEffects.None, 0);
            spriteBatch.Draw(terrain2, new Vector2((terrain.Width * (terrain.Width / 800f)), -365), null, Color.White, 0, Vector2.Zero, terrain.Width / 800f, SpriteEffects.None, 0);            
            spriteBatch.Draw(player.getTexture, player.getPosition, null, Color.White, 0, Vector2.Zero, .07f * (GraphicsDevice.Viewport.Width/ 800f), SpriteEffects.None, 0);
            spriteBatch.End();
            

            base.Draw(gameTime);
        }
    }
}
