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
            //if (color == Color.FromArgb(255, Color.White))
            //{
            //    this.cColor = ConsoleColor.White;
            //    return;
            //}
            //if (color == Color.FromArgb(255, Color.Black))
            //{
            //    this.cColor = ConsoleColor.Black;
            //    return;
            //}
            
            this.cColor = ConvertColor(color);
        }
        private ConsoleColor ConvertColor(Color color)
        {
            Color BlackDarkGray = Color.FromArgb(
                Color.Black.R - 1 + Color.DarkGray.R / 2, 
                Color.Black.G - 1 + Color.DarkGray.G / 2, 
                Color.Black.B - 1 + Color.DarkGray.B / 2
                );
            Color DarkGrayGray = Color.FromArgb(
                Color.DarkGray.R - 1 + Color.Gray.R / 2,
                Color.DarkGray.G - 1 + Color.Gray.G / 2,
                Color.DarkGray.B - 1 + Color.Gray.B / 2
                );
            Color GrayWhite = Color.FromArgb(
                Color.Gray.R - 1 + Color.White.R / 2,
                Color.Gray.G - 1 + Color.White.G / 2,
                Color.Gray.B - 1 + Color.White.B / 2
                );
            Color WhiteWhite = Color.FromArgb(
                Color.White.R - 1,
                Color.White.G - 1,
                Color.White.B - 1
                );
            if (ColorIsRange(color, Color.Black, BlackDarkGray))
                return ConsoleColor.Black;
            if (ColorIsRange(color, BlackDarkGray, DarkGrayGray))
                return ConsoleColor.DarkGray;
            if (ColorIsRange(color, DarkGrayGray, GrayWhite))
                return ConsoleColor.Gray;
            if (ColorIsRange(color, GrayWhite, WhiteWhite))
                return ConsoleColor.White;
            if (ColorIsRange(color, WhiteWhite, Color.White))
                return ConsoleColor.White;
            return ConsoleColor.Red;
        }
        private bool ColorIsRange(Color InitionalColor, Color MinColor, Color MaxColor)
        {
            if ((InitionalColor.R <= MaxColor.R && InitionalColor.R >= MinColor.R) &&
                (InitionalColor.G <= MaxColor.G && InitionalColor.G >= MinColor.G) &&
                (InitionalColor.B <= MaxColor.B && InitionalColor.B >= MinColor.B))
                return true;
            return false;
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
