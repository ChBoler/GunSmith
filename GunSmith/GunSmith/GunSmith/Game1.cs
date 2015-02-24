// ============================= Game1.cs =================================
//       Main class of the game; all game logic starts out here.
// ========================================================================
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

namespace GunSmith
{
    // The main game method; logic all starts here
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        // Set the default width and height for the game
        public static int windowWidth = 1920;
        public static int windowHeight = 1080;

        //TODO: Look into checking/changing resolution values
        public static int currentWindowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
        public static int currentWindowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = true;
            graphics.PreferredBackBufferWidth = windowWidth;
            graphics.PreferredBackBufferHeight = windowHeight;

            Content.RootDirectory = "Content";
        }

        // Allows the game to perform any initialization it needs to before starting to run.
        // This is where it can query for any required services and load any non-graphic
        // related content.  Calling base.Initialize will enumerate through any components
        // and initialize them as well.
        protected override void Initialize()
        {
            base.Initialize();
        }

        // Publically declare various 'textures' so they can be accessed outside
        // of this class by various rendering classes.
        public static Texture2D TitleGraphic;

        protected override void LoadContent()
        {
            // Create a new SpriteBatch for each class that needs to render images.
            //spriteBatch = new SpriteBatch(GraphicsDevice);
            MainMenu.spriteBatch = new SpriteBatch(GraphicsDevice);


            // TODO: Figure out if this can be loaded and unloaded in a seperate class

            // Initiate Menu Graphics
            TitleGraphic = Content.Load<Texture2D>("DebugTitleImage");
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
            // Grab the state of the keys being used
            KeyboardState currentKeyboardState = Keyboard.GetState();

            // Allows the game to exit
            if (currentKeyboardState.IsKeyDown(Keys.Escape))
                this.Exit();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Display the main menu
            MainMenu.RenderMenu();

            base.Draw(gameTime);
        }
    }
}
