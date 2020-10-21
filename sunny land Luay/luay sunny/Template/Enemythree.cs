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
    class Enemythree : Enemy
    {
        Texture2D enemy3;
        public Enemythree(Texture2D enemy3)
        {
            this.enemy3 = enemy3;
            position = new Vector2(350, 350);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(enemy3, new Rectangle(position.ToPoint(), new Point(60, 70)), Color.White);
        }

    }
}
