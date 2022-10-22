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

            if (ColorIsRange(color, Color.FromArgb(128, 0, 0), Color.FromArgb(255, 128, 128)))
            {
                return ConsoleColor.Red;
            }
            if (color == Color.FromArgb(255, 0, 0))
                return ConsoleColor.Red;

            if (ColorIsRange(color, Color.FromArgb(0, 128, 0), Color.FromArgb(128, 255, 128)))
                return ConsoleColor.Green;
            if (color == Color.FromArgb(0, 255, 0))
                return ConsoleColor.Green;

            if (ColorIsRange(color, Color.FromArgb(0, 0, 128), Color.FromArgb(128, 128, 255)))
                return ConsoleColor.Blue;
            if (color == Color.FromArgb(0, 0, 255))
                return ConsoleColor.Blue;


            if (ColorIsRange(color, Color.FromArgb(128, 128, 0), Color.FromArgb(255, 255, 128)))
                return ConsoleColor.Yellow;
            if (color == Color.FromArgb(255, 255, 0))
                return ConsoleColor.Yellow;

            if (ColorIsRange(color, Color.FromArgb(0, 128, 128), Color.FromArgb(128, 255, 255)))
                return ConsoleColor.Cyan;
            if (color == Color.FromArgb(0, 255, 255))
                return ConsoleColor.Cyan;

            if (ColorIsRange(color, Color.FromArgb(128, 0, 128), Color.FromArgb(255, 128, 255)))
                return ConsoleColor.Magenta;
            if (color == Color.FromArgb(255, 0, 255))
                return ConsoleColor.Magenta;

            if (ColorIsRange(color, Color.Black, Color.FromArgb(128, 128, 128)))
            {
                if (ColorIsRange(color, Color.FromArgb(64, 64, 64), Color.FromArgb(128, 128, 128)))
                    return ConsoleColor.Gray;
                if (ColorIsRange(color, Color.FromArgb(64, 0, 0), Color.FromArgb(128, 64, 64)))
                    return ConsoleColor.DarkRed;
                if (ColorIsRange(color, Color.FromArgb(0, 64, 0), Color.FromArgb(64, 128, 64)))
                    return ConsoleColor.DarkGreen;
                if (ColorIsRange(color, Color.FromArgb(0, 0, 64), Color.FromArgb(64, 64, 128)))
                    return ConsoleColor.DarkBlue;
                if (ColorIsRange(color, Color.FromArgb(64, 64, 0), Color.FromArgb(128, 128, 64)))
                    return ConsoleColor.DarkYellow;
                if (ColorIsRange(color, Color.FromArgb(0, 64, 64), Color.FromArgb(64, 128, 128)))
                    return ConsoleColor.DarkCyan;
                if (ColorIsRange(color, Color.FromArgb(64, 0, 64), Color.FromArgb(128, 64, 128)))
                    return ConsoleColor.DarkMagenta;
                return ConsoleColor.Black;
            }
            if (ColorIsRange(color, Color.FromArgb(128, 128, 128), Color.White))
                if (ColorIsRange(color, Color.FromArgb(128, 128, 128), Color.FromArgb(192, 192, 192)))
                    return ConsoleColor.DarkGray;
            return ConsoleColor.White;
            if (color == Color.FromArgb(255, 255, 255))
                return ConsoleColor.White;



            //if (ColorIsRange(color, Color.FromArgb(64, 0, 64), Color.FromArgb(192, 64, 192)))
            //    return ConsoleColor.DarkMagenta;
            //if (ColorIsRange(color, Color.FromArgb(192, 64, 192), Color.FromArgb(255, 160, 255)))
            //    return ConsoleColor.Magenta;
            //if (ColorIsRange(color, Color.FromArgb(64, 64, 0), Color.FromArgb(192, 192, 64)))
            //    return ConsoleColor.DarkYellow;
            //if (ColorIsRange(color, Color.FromArgb(192, 192, 0), Color.FromArgb(255, 255, 160)))
            //    return ConsoleColor.Yellow;
            //if (ColorIsRange(color, Color.FromArgb(0, 64, 64), Color.FromArgb(64, 192, 192)))
            //    return ConsoleColor.DarkCyan;
            //if (ColorIsRange(color, Color.FromArgb(64, 192, 192), Color.FromArgb(160, 255, 255)))
            //    return ConsoleColor.Cyan;

            //if (ColorIsRange(color, Color.FromArgb(64, 0, 0), Color.FromArgb(192, 64, 64)))
            //    return ConsoleColor.DarkRed;
            //if (ColorIsRange(color, Color.FromArgb(192, 64, 64), Color.FromArgb(255, 160, 160)))
            //    return ConsoleColor.Red;
            //if (ColorIsRange(color, Color.FromArgb(0, 64, 0), Color.FromArgb(64, 192, 64)))
            //    return ConsoleColor.DarkGreen;
            //if (ColorIsRange(color, Color.FromArgb(64, 192, 64), Color.FromArgb(160, 255, 160)))
            //    return ConsoleColor.Green;
            //if (ColorIsRange(color, Color.FromArgb(0, 0, 64), Color.FromArgb(64, 64, 192)))
            //    return ConsoleColor.DarkBlue;
            //if (ColorIsRange(color, Color.FromArgb(64, 64, 192), Color.FromArgb(160, 160, 255)))
            //    return ConsoleColor.Blue;

            return ConsoleColor.Black;
        }
        private bool ColorIsRange(Color InitionalColor, Color MinColor, Color MaxColor)
        {
            if ((InitionalColor.R < MaxColor.R && InitionalColor.R >= MinColor.R) &&
                (InitionalColor.G < MaxColor.G && InitionalColor.G >= MinColor.G) &&
                (InitionalColor.B < MaxColor.B && InitionalColor.B >= MinColor.B))
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
