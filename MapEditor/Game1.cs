using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using TileEngine;

namespace MapEditor
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        
        public int width = 25;
        public int height = 15;
        public int pixelSize = 64;

        public float scrollSpeed = 16f;
        public int[,] map;
        float scrollMod = 2;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        float numRateZoomIn = 1.275f;
        KeyboardState previousKb;
        MouseState ogMouseState = Mouse.GetState();
        int scrollVal;
        Vector2 mousePos;
        Vector2 scrollModify = Vector2.Zero;
        IntPtr drawSurface;
        System.Windows.Forms.Form parentForm;
        System.Windows.Forms.PictureBox pictureBox;
        System.Windows.Forms.Control gameForm;

        System.Windows.Forms.VScrollBar vscroll;
        System.Windows.Forms.HScrollBar hscroll;

        public bool isSide = true;
        public bool isTop = false;

        public int DrawTile = -1;

        public Game1(IntPtr drawSurface,
   System.Windows.Forms.Form parentForm,
   System.Windows.Forms.PictureBox surfacePictureBox)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.drawSurface = drawSurface;
            this.parentForm = parentForm;
            this.pictureBox = surfacePictureBox;

            //graphics.PreparingDeviceSettings +=
            //new EventHandler<PreparingDeviceSettingsEventArgs>(
            //graphics_PreparingDeviceSettings);

            Mouse.WindowHandle = drawSurface;

            vscroll =
               (System.Windows.Forms.VScrollBar)parentForm.Controls[
               "vScrollBar1"];
            hscroll =
           (System.Windows.Forms.HScrollBar)parentForm.Controls[
           "hScrollBar1"];
        }

        void graphics_PreparingDeviceSettings(object sender,
 PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.
            DeviceWindowHandle = drawSurface;
        }

        private void gameForm_VisibleChanged(object sender, EventArgs e)
        {
            if (gameForm.Visible == true)
                gameForm.Visible = false;
        }
        void pictureBox_SizeChanged(object sender, EventArgs e)
        {
            if (parentForm.WindowState !=
            System.Windows.Forms.FormWindowState.Minimized)
            {
                graphics.PreferredBackBufferWidth = pixelSize * width;//pictureBox.Width;
                graphics.PreferredBackBufferHeight = pixelSize * height;//pictureBox.Height;
                Camera.ViewPortWidth = pictureBox.Width;
                Camera.ViewPortHeight = pictureBox.Height;
                graphics.ApplyChanges();
            }
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
            //graphics.PreferredBackBufferWidth = pixelSize * width;
            //graphics.PreferredBackBufferHeight = pixelSize * height;
            //graphics.ApplyChanges();
            scrollVal = ogMouseState.ScrollWheelValue;
            this.IsMouseVisible = true;
            base.Initialize();
        }

        public void UpdateShowNums(bool showNum)
        {
            TileMap.SetShowNum(showNum);
        }
        public void AddRows(int rows, bool isUp)
        {
            int[,] tempMap = map;
            map = new int[height, width];

            if(isUp)
            {
                for(int y = 0; y < tempMap.GetLength(0); y++)
                {
                    for(int x = 0; x < tempMap.GetLength(1); x++)
                    {
                        try
                        {
                            map[y + rows, x] = tempMap[y, x];
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else
            {
                for (int y = 0; y < tempMap.GetLength(0); y++)
                {
                    for (int x = 0; x < tempMap.GetLength(1); x++)
                    {
                        try
                        {
                            map[y, x] = tempMap[y, x];
                        }
                        catch
                        {

                        }
                    }
                }
            }
            TileMap.Generate(map, pixelSize, isSide, isTop);
            Camera.WorldRectangle = new Rectangle(0, 0, TileMap.tileMap.mapWidth, TileMap.tileMap.mapHeight);
        }

        public void AddCols(int cols, bool isLeft)
        {
            int[,] tempMap = map;
            map = new int[height, width];

            if(isLeft)
            {
                //for (int y = 0; y < height; y++)
                //{
                //    for(int x = 0; x < cols; x++)
                //    {
                //        map[y, x] = 0;
                //    }
                //}
                for (int y = 0; y < tempMap.GetLength(0); y++)
                {
                    for (int x = 0; x < tempMap.GetLength(1); x++)
                    {
                        try
                        {
                            map[y, x + cols] = tempMap[y, x];
                        }
                        catch
                        {

                        }
                    }
                }
            }
            else
            {
                for (int y = 0; y < tempMap.GetLength(0); y++)
                {
                    for (int x = 0; x < tempMap.GetLength(1); x++)
                    {
                        try
                        {
                            map[y, x] = tempMap[y, x];
                        }
                        catch
                        {

                        }

                    }
                }
            }
            TileMap.Generate(map, pixelSize, isSide, isTop);
            Camera.WorldRectangle = new Rectangle(0, 0, TileMap.tileMap.mapWidth, TileMap.tileMap.mapHeight);
        }

        public void UpdateMap()
        {
            int[,] tempMap = map;
            map = new int[height, width];
            for(int y = 0; y < tempMap.GetLength(0); y++)
            {
                for(int x = 0; x < tempMap.GetLength(1); x++)
                {
                    try
                    {
                        map[y, x] = tempMap[y, x];
                    }
                    catch
                    {

                    }
                    
                }
            }
            TileMap.Generate(map, pixelSize, isSide, isTop);
            Camera.WorldRectangle = new Rectangle(0, 0, TileMap.tileMap.mapWidth, TileMap.tileMap.mapHeight);
            //graphics.PreferredBackBufferWidth = pixelSize * width;
            //graphics.PreferredBackBufferHeight = pixelSize * height;
            //graphics.ApplyChanges();
        }

        public void ClearMap()
        {
            map = new int[height, width];
            TileMap.Generate(map, pixelSize, isSide, isTop);
        }


        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            map = new int[height, width];
            Tile.Content = Content;
            TileMap.Generate(map, pixelSize, isSide, isTop);
            Camera.ViewPortWidth = width * pixelSize;
            Camera.ViewPortHeight = height * pixelSize;
            Camera.WorldRectangle = new Rectangle(
            0,
            0,
            TileMap.tileMap.mapWidth,
            TileMap.tileMap.mapHeight);
            
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

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState kb = Keyboard.GetState();
            if(kb.IsKeyDown(Keys.Right))// && previousKb != kb)
            {
                ScrollRight();

            }
            else if(kb.IsKeyDown(Keys.Left))// && previousKb != kb)
            {
                ScrollLeft();
            }
            if (kb.IsKeyDown(Keys.Up))// && previousKb != kb)
            {
                ScrollUp();
            }
            else if(kb.IsKeyDown(Keys.Down)) //&& previousKb != kb)
            {
                ScrollDown();
            }

            previousKb = kb;

            Camera.Update();
            //Camera.Position = new Vector2(hscroll.Value, vscroll.Value);
            float tempZoom = Camera.Zoom;
            MouseState ms = Mouse.GetState();
            //if (ms.ScrollWheelValue > scrollVal)
            //{
            //    ZoomIn(tempZoom);

            //}
            //else if (ms.ScrollWheelValue < scrollVal)
            //{
            //    ZoomOut(tempZoom);

            //}
            //scrollVal = ms.ScrollWheelValue;
            if ((ms.X > 0) && (ms.Y > 0) &&
            (ms.X < Camera.ViewPortWidth) &&
            (ms.Y < Camera.ViewPortHeight))
            {
                double modifier = Math.Round((double)scrollMod);
                mousePos = new Vector2((scrollMod * ms.X) + scrollModify.X, (scrollMod * ms.Y) + scrollModify.Y);
                if (Camera.WorldRectangle.Contains((int)mousePos.X, (int)mousePos.Y))
                {
                    try
                    {
                         if (ms.LeftButton == ButtonState.Pressed)
                         {
                                 map[TileMap.GetCellByPixelY((int)mousePos.Y), TileMap.GetCellByPixelX((int)mousePos.X)] = DrawTile;
                        
                        
                         }
                    }
                    catch
                    {

                    }
                   
                }
            }



            TileMap.Generate(map, pixelSize, isSide, isTop);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        public void ScrollRight()
        {
            Camera.Move(new Vector2(-scrollSpeed, 0));
            scrollModify += new Vector2(scrollSpeed, 0);
        }

        public void ScrollLeft()
        {
            Camera.Move(new Vector2(scrollSpeed, 0));
            scrollModify += new Vector2(-scrollSpeed, 0);
        }

        public void ScrollDown()
        {
            Camera.Move(new Vector2(0, scrollSpeed));
            scrollModify += new Vector2(0, scrollSpeed);
        }

        public void ScrollUp()
        {
            Camera.Move(new Vector2(0, -scrollSpeed));
            scrollModify += new Vector2(0, -scrollSpeed);
        }

        public void ZoomOut(float tempZoom)
        {
            Camera.Zoom -= .25f;

            scrollMod += tempZoom / 1.17125f;
        }

        public void ZoomIn(float tempZoom)
        {
            Camera.Zoom += .25f;

            scrollMod -= tempZoom * numRateZoomIn;
            //numRateZoomIn += .10f;
            if (scrollMod <= 0)
                scrollMod = 0;
        }

        public void Reset()
        {
            Camera.Zoom = .5f;
            //Full Reset
            //scrollModify = new Vector2(0, 0);
            //Camera.Position = Vector2.Zero;
            scrollMod = 2f;
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.TransparentBlack);
            Window.Title = scrollMod.ToString() + "   " + mousePos.ToString();
            // TODO: Add your drawing code here
        
            TileMap.Draw(spriteBatch);
            base.Draw(gameTime);
        }
    }
}
