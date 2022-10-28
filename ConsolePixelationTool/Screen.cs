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
        public void RGBTest()
        {
            Color rgb;
            Console.ForegroundColor = ConsoleColor.Black;
            rgb = Color.Black;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            rgb = Color.DarkBlue;
            Console.Write("████");
            Console.ForegroundColor= ConsoleColor.DarkGreen;
            rgb = Color.DarkGreen;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            rgb = Color.DarkCyan;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            rgb = Color.DarkRed;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            rgb = Color.DarkMagenta;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            rgb = Color.DarkOrange;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Gray;
            rgb = Color.Gray;
            Console.Write("████\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            rgb = Color.DarkGray;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Blue;
            rgb = Color.MediumBlue;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Green;
            rgb = Color.Green;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Cyan;
            rgb = Color.Cyan;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Red;
            rgb = Color.Red;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Magenta;
            rgb = Color.Magenta;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.Yellow;
            rgb = Color.Yellow;
            Console.Write("████");
            Console.ForegroundColor = ConsoleColor.White;
            rgb = Color.White;
            Console.Write("████");
        }
        private void ChangePixel(int x, int y, Color color)
        {
            this.Frame[x, y].PixelColor = new ColorConverter().ConvertToConsoleColor(color);
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
