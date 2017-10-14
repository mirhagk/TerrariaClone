using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TerrariaClone
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        TerrariaClone game;
        public static Game1 Instance { get; } = new Game1();
        public List<KeyListener> KeyListeners = new List<KeyListener>();
        public List<MouseListener> MouseListeners = new List<MouseListener>();
        public List<MouseWheelListener> MouseWheelListeners = new List<MouseWheelListener>();
        public List<MouseMotionListener> MouseMotionListeners = new List<MouseMotionListener>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferHeight = 800;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
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

            game = new TerrariaClone();
            game.init();
            base.Initialize();
            System.Console.WriteLine($"Screen size: {game.getWidth()}x{game.getHeight()}");
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        MouseState lastMouseState;
        KeyState lastKeyState;
        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            var mouseState = Mouse.GetState();

            if (mouseState.LeftButton == ButtonState.Pressed && lastMouseState.LeftButton == ButtonState.Released)
                foreach (var listener in MouseListeners)
                    listener.mousePressed(new MouseEvent(MouseEvent.BUTTON1));
            if (mouseState.RightButton == ButtonState.Pressed && lastMouseState.RightButton == ButtonState.Released)
                foreach (var listener in MouseListeners)
                    listener.mousePressed(new MouseEvent(MouseEvent.BUTTON3));

            if (mouseState.LeftButton == ButtonState.Released && lastMouseState.LeftButton == ButtonState.Pressed)
                foreach (var listener in MouseListeners)
                    listener.mouseReleased(new MouseEvent(MouseEvent.BUTTON1));
            if (mouseState.RightButton == ButtonState.Released && lastMouseState.RightButton == ButtonState.Pressed)
                foreach (var listener in MouseListeners)
                    listener.mouseReleased(new MouseEvent(MouseEvent.BUTTON3));

            if (mouseState.Position != lastMouseState.Position)
                foreach (var listener in MouseMotionListeners)
                    listener.mouseMoved(new MouseEvent(mouseState.Position.X, mouseState.Position.Y));

            // TODO: Add your update logic here
            lastMouseState = mouseState;


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            game.paint(new Graphics2D(game.getWidth(),game.getHeight(),false));
            // TODO: Add your drawing code here
            //System.Console.WriteLine($"FPS: {1000.0f / gameTime.ElapsedGameTime.Milliseconds}");
            base.Draw(gameTime);
        }
    }
}
