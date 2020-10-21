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
    class Enemytwo : Enemy
    {  
        Texture2D enemy2;
        public Enemytwo(Texture2D enemy2)
        {
            this.enemy2 = enemy2;
            position = new Vector2(250, 350);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(enemy2, new Rectangle(position.ToPoint(), new Point(60, 70)), Color.White);
        }
    }
}
