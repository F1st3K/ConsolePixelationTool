using System;
using System.Collections.Generic;
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
                    this.Frame[x, y] = new Pixel(ConsoleColor.Green, PixelSize);
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
