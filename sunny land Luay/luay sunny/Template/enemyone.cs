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
    class Enemyone : Enemy
    {
        Texture2D enemy1;
        bool left = true;
        bool right = false;
        public Enemyone(Texture2D enemy1)
        {
            this.enemy1 = enemy1;
            position = new Vector2(150, 350);
        }
        public void Update(GameTime gameTime)
        {
            if(left = true)
            {
                position.X--;
                if(position.X == 0)
                {
                    bool left = false;
                    bool right = true;
                }
            }
            if(right = true)
            {
                position.X++;
                if (position.X == 150)
                {
                    bool right = false;
                    bool left = true;
                }
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(enemy1, new Rectangle(position.ToPoint(), new Point(60, 70)), Color.White);
        }
    }
}
