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
        private ConsoleColor cColor;
        public Pixel(ConsoleColor Color, int pixelSize)
        {
            this.cColor = Color;
            this.PixelSizeX = pixelSize;
        }
        public void ChangeColor(Color color)
        {
            if (color == Color.White)
            {
                this.cColor = ConsoleColor.White;
                return;
            }
            if (color == Color.Black)
            {
                this.cColor = ConsoleColor.Black;
                return;
            }
            this.cColor = ConsoleColor.DarkGray;
        }
        public void DrawPixel(int posX, int posY)
        {
            Console.ForegroundColor = this.cColor;
            Console.SetCursorPosition(posX, posY);
            for(int i = 0; i < PixelSizeX; i++)
                Console.Write("█");
        }
    }
}
