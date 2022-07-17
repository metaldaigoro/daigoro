using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DeadMoon
{
    public class Game1 : Game
    {
        // Declaraciones por defecto
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        // Declarando los sprites de los personajes
        private Texture2D vegeta;
        private Texture2D vegetaSayan;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Cargar sprite de los personajes
            vegeta = Content.Load<Texture2D>("Personajes/vegeta");
            vegetaSayan = Content.Load<Texture2D>("Personajes/vegeta_sayan");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Dibujar sprite del personaje
            spriteBatch.Begin();
            spriteBatch.Draw(vegeta, Vector2.Zero, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
