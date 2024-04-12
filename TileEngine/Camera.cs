using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace TileEngine
{
    public static class Camera
    {
   
        private static Vector2 position = Vector2.Zero;
        private static float zoom = .5f;
        private static Vector2 viewPortSize = Vector2.Zero;
        private static Rectangle worldRectangle = new Rectangle
         (0, 0, 0, 0);

        public static Matrix transform;

        public static Vector2 Position
        {
            get { return position; }
            set
            {
                position = value;
            }
        }
        public static float Zoom
        {
            get { return zoom; }
            set
            {
                zoom = value;
                
            }
        }
        public static Rectangle WorldRectangle
        {
            get { return worldRectangle; }
            set { worldRectangle = value; }
        }
        public static int ViewPortWidth
        {
            get { return (int)viewPortSize.X; }
            set { viewPortSize.X = value; }
        }
        public static int ViewPortHeight
        {
            get { return (int)viewPortSize.Y; }
            set { viewPortSize.Y = value; }
        }
        public static Rectangle ViewPort
        {
            get
            {
                return new Rectangle((int)Position.X, (int)Position.Y,
                ViewPortWidth, ViewPortHeight);
            }
        }

        public static Vector2 ScreenToWorld(Vector2 screenLocation)
        {
            return screenLocation + position;
        }

        public static void Move(Vector2 offset)
        {
            Position += offset;
        }

        public static void Update()
        {
           
            transform = Matrix.CreateTranslation(new Vector3(Position.X, -Position.Y, 0)) * Matrix.CreateScale(new Vector3(zoom, zoom, 0));
        }
    }
}
