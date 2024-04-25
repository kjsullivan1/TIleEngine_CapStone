using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileEngine;
using Microsoft.Xna.Framework;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

namespace MapEditor
{
    public partial class LevelEditor : Form
    {
        public Game1 game;
        public Vector2 zoomCounts = new Vector2(0,0);
        public LevelEditor()
        {
            InitializeComponent();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Exit();
            Application.Exit();
        }

   

        private void LoadImageList()
        {
            DirectoryInfo dir;

            dir = new DirectoryInfo(game.Content.RootDirectory + "/SideScroll");
            FileInfo[] sideScrollTextures = dir.GetFiles("*.xnb");

            var type = sideScrollTextures[0].GetType();
            //dir = new DirectoryInfo(game.Content.RootDirectory + "/TopDown");
            //FileInfo[] topDownTextures = dir.GetFiles("*.xnb");
            //string filePath = Application.StartupPath + @"\Content\SideScroll\Tile" + 0;
           // int tileCount = 0;
            for (int i = 0; i < sideScrollTextures.Length; i++)
            {
                string filePath = Application.StartupPath + @"/Content/SideScroll/Tile" + i + ".png";
                Bitmap curImg = new Bitmap(filePath);
                
                for(int y = 0; y < 1; y++)
                {
                    for(int x = 0; x < 1; x++)
                    {
                        Bitmap newImg = curImg.Clone(new System.Drawing.Rectangle(x * 64, y * 64, 64, 64), System.Drawing.Imaging.PixelFormat.DontCare);
                        imgListSideScroll.Images.Add(newImg);
                        string itemName;

                        switch (i)
                        {
                            case 0:
                                itemName = "Empty";
                                break;
                            case 1:
                                itemName = "Void";
                                break;
                            default:
                                itemName = "";
                                break;

                        }
                        SideTiles.Items.Add(new ListViewItem(itemName, i));
                    }
                }
                    //Texture2D txture = game.Content.Load<Texture2D>("/SideScroll/Tile" + i);

                    //Image img = Image.FromFile(filePath);
                    //ImagimgConvert.ConvertFromString(txture.ToString());
                    //Size size = image.Size;
                    //image.Height = 64;
                    //imgListSideScroll.Images.Add(img);
            }

            game.isTop = true;
            game.isSide = false;

            dir = new DirectoryInfo(game.Content.RootDirectory + "/TopDown");
            FileInfo[] topDownTextures = dir.GetFiles("*.xnb");

            for (int i = 0; i < topDownTextures.Length; i++)
            {
                string filePath = Application.StartupPath + @"/Content/TopDown/Tile" + i + ".png";
                Bitmap curImg = new Bitmap(filePath);

                for (int y = 0; y != 1; y++)
                {
                    for (int x = 0; x < 1; x++)
                    {
                        Bitmap newImg = curImg.Clone(new System.Drawing.Rectangle(x * 64, y * 64, 64, 64), System.Drawing.Imaging.PixelFormat.DontCare);
                        imageListTopDown.Images.Add(newImg);
                        //Add new names by their numerical index
                        string itemName = "";

                        switch(i)
                        {
                            default:
                                itemName = "";
                                break;
                                
                        }
                        TopTiles.Items.Add(new ListViewItem(itemName, i));
                    }
                }
               
            }
            game.isTop = false;
            game.isSide = true;
            //string filepath = Application.StartupPath + @"\Content\Textures\PlatformTiles.png";
            //Bitmap tileSheet = new Bitmap(filepath);
            //int tilecount = 0;
            //for (int y = 0; y < tileSheet.Height / TileMap.TileHeight;    //pixelSize
            //y++)
            //{
            //    for (int x = 0; x < tileSheet.Width / TileMap.TileWidth; //pixelSize 
            //    x++)
            //    {
            //        Bitmap newBitmap = tileSheet.Clone(new
            //        System.Drawing.Rectangle(
            //        x * TileMap.TileWidth,
            //        y * TileMap.TileHeight,
            //        TileMap.TileWidth,
            //        TileMap.TileHeight),
            //        System.Drawing.Imaging.PixelFormat.DontCare);
            //        imgListTiles.Images.Add(newBitmap);
            //        string itemName = "";
            //        if (tilecount == 0)
            //        {
            //            itemName = "Empty";
            //        }
            //        if (tilecount == 1)
            //        {
            //            itemName = "White";
            //        }
            //        ListViewItem(itemName, tilecount++));
            //    }
            //}

        }
        private void FixScrollBarScales()
        {
            //Camera.ViewPortWidth = pctSurface.Width;
            //Camera.ViewPortHeight = pctSurface.Height;
            //Camera.Move(Vector2.Zero);
            //vScrollBar1.Minimum = 0;
            //vScrollBar1.Maximum =
            //Camera.WorldRectangle.Height -
            //Camera.ViewPortHeight;
            //hScrollBar1.Minimum = 0;
            //hScrollBar1.Maximum =
            //Camera.WorldRectangle.Width -
            //Camera.ViewPortWidth;

            //Move the Game1 Camera 
        }


        private void LevelEditor_Load(object sender, EventArgs e)
        {
            LoadImageList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pxlTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                //game.pixelSize = int.Parse(pxlTxt.Text);
                //game.UpdateMap();
            }
            catch
            {

            }
           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void colTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                game.width = int.Parse(colTxt.Text);
                if(game.width >= 99)
                {
                    game.width = 99;
                    colTxt.Text = "99";
                }
                game.UpdateMap();
            }
            catch
            {

            }
            
        }

        private void rowTxt_Leave(object sender, EventArgs e)
        {
            try
            {
                game.height = int.Parse(rowTxt.Text);
                if (game.height >= 99)
                {
                    game.height = 99;
                    rowTxt.Text = "99";
                }
                game.UpdateMap();
            }
            catch
            {

            }
           
        }

        private void rowTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    game.height = int.Parse(rowTxt.Text);
                    game.UpdateMap();
                }
                catch
                {

                }
            }
        }

        private void rowTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void colTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                try
                {
                    game.width = int.Parse(colTxt.Text);
                    game.UpdateMap();
                }
                catch
                {

                }
            }
        }

        private void pxlTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter))
            {
                try
                {
                    //game.pixelSize = int.Parse(pxlTxt.Text);
                    //game.UpdateMap();
                }
                catch
                {

                }
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void hScrollBar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Right))
            {
                Camera.ViewPortWidth = pctSurface.Width;
                //Camera.ViewPortHeight = pctSurface.Height;
                Camera.Move(new Vector2(64,0));
                //vScrollBar1.Minimum = 0;
                //vScrollBar1.Maximum =
                //Camera.WorldRectangle.Height -
                //Camera.ViewPortHeight;
                //hScrollBar1.Minimum = 0;
                //hScrollBar1.Maximum =
                //Camera.WorldRectangle.Width -
                //Camera.ViewPortWidth;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(zoomCounts.X < 1)
            {
                game.ZoomIn(Camera.Zoom);
                zoomCounts.X++;
                zoomCounts.Y--;
            }
            else if(zoomCounts.X == 1)
            {
                game.ZoomIn(.3f);
                zoomCounts.X++;
                zoomCounts.Y--;
            }
            
        }

        private void ZoomOutBtn_Click(object sender, EventArgs e)
        {
            if(zoomCounts.Y < - 1)
            {
                game.ZoomOut(Camera.Zoom/2.275f);
                zoomCounts.X--;
                zoomCounts.Y++;
            }
            else if(zoomCounts.Y < 0)
            {
                game.ZoomOut(Camera.Zoom);
                zoomCounts.X--;
                zoomCounts.Y++;
            }
            
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            game.Reset();
            zoomCounts = new Vector2(0, 0);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
            if(e.OldValue > e.NewValue)
            {
                game.ScrollUp();
            }
            else
            {
                game.ScrollDown();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SideTiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SideTiles.SelectedIndices.Count > 0)
            {
                game.DrawTile =
                SideTiles.SelectedIndices[0];
            }
        }
        private void TopTiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TopTiles.SelectedIndices.Count > 0)
            {
                game.DrawTile =
                TopTiles.SelectedIndices[0];
            }
        }

        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.UpdateMap();

            if(isSideScroll.Checked)
            {
                string filePath = Application.StartupPath + @"/Content/Maps/SideScroll/Map" + (int)mapLevel.Value + ".txt";
           
                using (var sw = new StreamWriter(System.IO.File.Create(filePath)))
                {
                    for (int y = 0; y < game.map.GetLength(0); y++)
                    {
                        for (int x = 0; x < game.map.GetLength(1); x++)
                        {
                            sw.Write(game.map[y, x]);
                        }
                        //sw.Write("\n");
                    }

                    sw.Write("Height:"+rowTxt.Text+"Width:"+colTxt.Text);
                    sw.Flush();

                    sw.Close();
                }
            }
           

           
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSideScroll.Checked)
            {
                string filePath = Application.StartupPath + @"/Content/Maps/SideScroll/Map" + (int)mapLevel.Value + ".txt";
               

                if(System.IO.File.Exists(filePath))
                {
                    string mapInfo = File.ReadAllText(filePath);
                    int lenghtTilDims = 0;
                    int StartWidthIndex = 0;
                    int StartHeightIndex = 0;
                    int width = 25;
                    int height = 1;
                    for(int k = 0; k < mapInfo.Length - 6; k++) //Lets run through the file :)
                    {
                        if (mapInfo.Substring(k, 6).Contains("Width:"))//Search for Width: containing 6 characters
                        {
                            width = int.Parse(mapInfo.Substring(k + 6, (mapInfo.Length - (k + 6))));
                            StartWidthIndex = k + 6;

                        }
                    }
                    for(int l = 0; l < mapInfo.Length; l++)
                    {
                        if (mapInfo.Substring(l, 7).Contains("Height:"))//Search for Height: containing, 7 characters
                        {
                            height = int.Parse(mapInfo.Substring(l + 7, (mapInfo.Length - StartWidthIndex)));
                            StartHeightIndex = l;
                            break;
                        }
                    }
                    //int width = int.Parse(mapInfo.Substring(mapInfo.Length -2, 2));
                    //int height = int.Parse(mapInfo.Substring(mapInfo.Length - 4, 2));
                    int[,] map = new int[height, width];
                    int i = 0;
                    int x = 0;
                    int y = 0;
                    int length = mapInfo.Length - StartHeightIndex;
                   
                    while(i < mapInfo.Length - length)
                    {
                        
                        int num = int.Parse(mapInfo.Substring(i, 1));
                        map[y, x] = num;

                        x++;
                        if(x >= width)
                        {
                            x = 0;
                            y += 1;
                        }
                        if(y >= height)
                        {
                            break;
                        }
                        i++;
                    }

                    game.width = width;
                    game.height = height;
                    game.map = map;
                    game.UpdateMap();

                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (isSideScroll.Checked)
            {
                isTopDown.Checked = false;
                game.isSide = true;
                game.isTop = false;

            }
        }

        private void isTopDown_CheckedChanged(object sender, EventArgs e)
        {

            if (isTopDown.Checked)
            {
                isSideScroll.Checked = false;
                game.isSide = false;
                game.isTop = true;

            }
        }

        private void mapLevel_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void clearMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.ClearMap();
        }
    }
}
