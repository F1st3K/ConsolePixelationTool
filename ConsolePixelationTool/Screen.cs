using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePixelationTool
{
    internal class Screen
    {
        private int Height;
        private int Width;
        private int PixelSizeX;
        private Pixel[,] Frame; 
        public Screen(int Height, int Width, int PixelSize)
        {
            this.Height = Height;
            this.Width = Width;
            this.Frame = new Pixel[Width,Height];
            this.PixelSizeX = PixelSize;
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y] = new Pixel(ConsoleColor.White, PixelSize);
                }
            }
        }
        private void ChangePixel(int x, int y, Color color)
        {
            this.Frame[x, y].ChangeColor(color);
        }
        public void ChangeScreen(Bitmap img)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    ChangePixel(x, y, img.GetPixel(x, y));
                }
            }
        }
        public void DrawScreen(int posX,int posY)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].DrawPixel(posX+x*PixelSizeX, posY+y);
                }
            }
        }
    }
}
