using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePixelationTool
{
    internal class Pixel
    {
        private int PixelSizeX;
        public ConsoleColor PixelColor { private get; set; }
        public Pixel(ConsoleColor Color, int pixelSize)
        {
            this.PixelColor = Color;
            this.PixelSizeX = pixelSize;
        }
        public void DrawPixel(int posX, int posY)
        {
            Console.ForegroundColor = this.PixelColor;
            Console.SetCursorPosition(posX, posY);
            for(int i = 0; i < PixelSizeX; i++)
                Console.Write("█");
        }
    }
}
