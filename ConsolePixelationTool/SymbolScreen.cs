using System.Drawing;
using System;

namespace ConsolePixelationTool
{
    internal class SymbolScreen : Screen
    {
        public SymbolScreen(int Height, int Width, int PixelSize) : base(Height, Width, PixelSize)
        {
        }
        public override void ChangeScreen(Bitmap img)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].PixelSymbol = new ColorConverter().ConvertToConsoleSymbol(img.GetPixel(x, y));
                }
            }
        }
        public override void DrawScreen(int posX, int posY)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Console.Write(this.Frame[x, y].PixelSymbol);
                }
                Console.WriteLine();
            }
        }
    }
}
