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
        private Texture2D vegeta2;
        private Texture2D vegeta3;
        private Texture2D vegeta4; 
        private Texture2D vegeta5;
        private Texture2D vegeta6;
        private Texture2D vegeta7;
        private Texture2D vegeta8;
        private Texture2D vegeta9;
        private Texture2D backgroundInicio;
        private Vector2 posicionVegeta = new Vector2();
        private Vector2 movimiento = new Vector2();
        
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            //System.Console.WriteLine(graphics.GraphicsDevice.Indices);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Esto viene por defecto
            base.Initialize();

            // Posicion inicial vegeta
            //Fijar posicion del elemento al final de la pantalla
            // A la izquierda del todo
            posicionVegeta.X = 0;
            // La altura de la pantalla menos el tamaño del sprite
            posicionVegeta.Y = GraphicsDevice.PresentationParameters.BackBufferHeight - vegeta.Height;
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Cargar sprite de los personajes
            vegeta = Content.Load<Texture2D>("Animacion/1");
            vegeta2 = Content.Load<Texture2D>("Animacion/2");
            vegeta3 = Content.Load<Texture2D>("Animacion/3");
            backgroundInicio = Content.Load<Texture2D>("Background/fondo");
        }

        protected override void Update(GameTime gameTime)
        {
            // Esto viene por defecto para usar el mando o el teclado
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            
            // Mi lógica para el movimiento
            movimiento = Vector2.Zero;
            // Si aprietas boton derecha
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                System.Diagnostics.Debug.WriteLine("estoy aqui");
                //Posicion eje x++
                movimiento.X += 1;
            }
            // Si aprietas boton izquierda
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                System.Diagnostics.Debug.WriteLine("estoy aqui 2");
                //Posicion eje x++
                movimiento.X -= 1;
            }

            posicionVegeta += movimiento;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            

            
            spriteBatch.Begin();
            // Dibujar background
            //spriteBatch.Draw(backgroundInicio, Vector2.Zero, Color.White);
            //System.Console.WriteLine("Tamaño pantalla X:" + GraphicsDevice.PresentationParameters.BackBufferHeight + " Tamañoo pantalla Y:" + GraphicsDevice.PresentationParameters.BackBufferWidth);
            spriteBatch.Draw(backgroundInicio,
               new Rectangle(0, 0, GraphicsDevice.PresentationParameters.BackBufferWidth, GraphicsDevice.PresentationParameters.BackBufferHeight),
               new Rectangle(0, 0, backgroundInicio.Width, backgroundInicio.Height),
               Color.White);
            // Dibujar sprite del personaje
            spriteBatch.Draw(vegeta, posicionVegeta, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
