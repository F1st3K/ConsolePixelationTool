using System;

namespace ConsolePixelationTool
{
    internal class Pixel
    {
        private int PixelSizeX;
        public ConsoleColor PixelColor { private get; set; }
        public char PixelSymbol { get; set; }
        public Pixel(ConsoleColor Color, int pixelSize)
        {
            this.PixelColor = Color;
            this.PixelSizeX = pixelSize;
            this.PixelSymbol = '█';
        }
        public void SetColor()
        {

            Console.ForegroundColor = this.PixelColor;
        }
        public void ResetColor()
        {

            Console.ResetColor();
        }
        public void DrawPixel(int posX, int posY)
        {
            Console.SetCursorPosition(posX, posY);
            for(int i = 0; i < PixelSizeX; i++)
                Console.Write(PixelSymbol);
        }
    }
}
