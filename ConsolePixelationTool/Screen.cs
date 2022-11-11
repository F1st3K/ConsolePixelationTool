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
        public void ChangeScreen(Bitmap img, Size resolution)
        {
            img = new Bitmap(img, resolution);
            
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].PixelColor = new ColorConverter().ConvertToConsoleColor(img.GetPixel(x, y));
                    this.Frame[x, y].PixelSymbol = new ColorConverter().ConvertToConsoleSymbol(img.GetPixel(x, y));
                }
            }
        }
        public void SymbolOutput(int startX, int startY)
        {
            Console.SetCursorPosition(startX * PixelSizeX, startY);
            for (int y = 0; y < Frame.GetLength(1); y++)
            {
                for (int x = 0; x < Frame.GetLength(0); x++)
                {
                    for (int i = 0; i < PixelSizeX; i++)
                        Console.Write(Frame[x, y].PixelSymbol);
                }
                Console.WriteLine();
            };
        }
        public void ColorOutput(int startX, int startY)
        {
            for (int y = 0; y < Frame.GetLength(1); y++)
            {
                for (int x = 0; x < Frame.GetLength(0); x++)
                {
                    Console.ForegroundColor = Frame[x, y].PixelColor;
                    Console.SetCursorPosition((x + startX) * PixelSizeX, y + startY);
                    for (int i = 0; i < PixelSizeX; i++)
                        Console.Write(Pixel.BlockSymbol);
                }
            }
            Console.ResetColor();
        }
        public void SymbolColorOutput(int startX, int startY)
        {
            for (int y = 0; y < Frame.GetLength(1); y++)
            {
                for (int x = 0; x < Frame.GetLength(0); x++)
                {
                    Console.ForegroundColor = Frame[x, y].PixelColor;
                    Console.SetCursorPosition((x + startX) * PixelSizeX, y + startY);
                    for (int i = 0; i < PixelSizeX; i++)
                        Console.Write(Frame[x, y].PixelSymbol);
                }
            }
            Console.ResetColor();
        }
    }
}
