using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    
    public class Game1 : Game 
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D spelaren;
        Texture2D enemy1;
        Texture2D enemy2;
        Texture2D enemy3;
        Spelare spelare;
    
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            


        }

      
        protected override void Initialize()
        {
       

            base.Initialize();
        }

       
        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);
            spelaren = Content.Load<Texture2D>("spelaren");
            enemy1 = Content.Load<Texture2D>("enemy1");
            enemy2 = Content.Load<Texture2D>("enemy2");
            enemy3 = Content.Load<Texture2D>("enemy3");

            spelare = new Spelare(spelaren);
            
        }

        protected override void UnloadContent()
        {
           
        }

       
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            spelare.Update(gameTime);
            base.Update(gameTime);
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Thistle);
            spriteBatch.Begin();
            spelare.Draw(spriteBatch);
            spriteBatch.End();

           

            base.Draw(gameTime);
        }
    }
}
