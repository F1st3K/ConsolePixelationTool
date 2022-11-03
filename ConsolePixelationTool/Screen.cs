using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePixelationTool
{
    internal class Screen
    {
        public int Height { get; private set; }
        public int Width {get; private set;}
        public int PixelSizeX {get; private set;}
        public Pixel[,] Frame {get; private set;} 
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
        public virtual void ChangeScreen(Bitmap img)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].PixelColor = new ColorConverter().ConvertToConsoleColor(img.GetPixel(x, y));
                    this.Frame[x, y].PixelSymbol = new ColorConverter().ConvertToConsoleSymbol(img.GetPixel(x, y));
                }
            }
        }
        public virtual void DrawScreen(int posX, int posY)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].SetColor();
                    this.Frame[x, y].DrawPixel(posX + x * PixelSizeX, posY + y);
                    this.Frame[x, y].ResetColor();
                }
            }
        }
    }
}
