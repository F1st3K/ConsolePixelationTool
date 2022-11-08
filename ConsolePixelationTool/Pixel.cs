using System;

namespace ConsolePixelationTool
{
    internal class Pixel
    {
        private int PixelSizeX;
        public ConsoleColor PixelColor { get; set; }
        public char PixelSymbol { get; set; }
        public const char BlockSymbol = '█';
        public Pixel(ConsoleColor Color, int pixelSize)
        {
            this.PixelColor = Color;
            this.PixelSizeX = pixelSize;
            this.PixelSymbol = BlockSymbol;
        }
    }
}
