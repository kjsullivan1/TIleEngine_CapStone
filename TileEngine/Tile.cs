using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileEngine
{
    public class Tile
    {
        public Texture2D texture;

        private Rectangle rectangle;
        public int[] mapPoint;
        public Rectangle Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }
        }


        public void setX(int x)
        {
            rectangle.X = x;
        }
        public void setY(int y)
        {
            rectangle.Y = y;
        }

        private static ContentManager content;
        public static ContentManager Content
        {
            protected get { return content; }
            set { content = value; }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }

    class EmptyTile : Tile
    {
        public EmptyTile(int i, Rectangle newRect, bool isSide, bool isTop)
        {
            if(isSide)
            {
                texture = Content.Load<Texture2D>("SideScroll/Tile" + i);
                this.Rectangle = newRect;
            }
            else if(isTop)
            {
                texture = Content.Load<Texture2D>("TopDown/Tile" + i);
                this.Rectangle = newRect;
            }
           
        }

    }
}
