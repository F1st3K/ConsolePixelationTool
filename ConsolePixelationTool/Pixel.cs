using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePixelationTool
{
    internal class Pixel
    {
        private int PixelSizeX;
        private ConsoleColor Color;
        public Pixel(ConsoleColor Color, int pixelSize)
        {
            this.Color = Color;
            this.PixelSizeX = pixelSize;
        }
        public void DrawPixel(int posX, int posY)
        {
            Console.ForegroundColor = this.Color;
            Console.SetCursorPosition(posX, posY);
            for(int i = 0; i < PixelSizeX; i++)
                Console.Write("█");
            Console.ResetColor();
        }
    }
}
