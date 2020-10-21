using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Enemyone enemyone;
        Enemytwo enemytwo;
        Enemythree enemythree;
    
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
            enemyone = new Enemyone(enemy1);
            enemytwo = new Enemytwo(enemy2);
            enemythree = new Enemythree(enemy3);

        }

        protected override void UnloadContent()
        {
           
        }

       
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            spelare.Update(gameTime);
            enemyone.Update(gameTime);
            base.Update(gameTime);
            
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Thistle);
            spriteBatch.Begin();
            spelare.Draw(spriteBatch);
            enemyone.Draw(spriteBatch);
            enemytwo.Draw(spriteBatch);
            enemythree.Draw(spriteBatch);
            spriteBatch.End();

           

            base.Draw(gameTime);
        }
    }
}
