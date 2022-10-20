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
            //вспомогательные цвета для округление красного
            Color BlackDarkRed = Color.FromArgb(
               Color.Black.G + (Color.DarkRed.G - Color.Black.G ) / 2,
               Color.Black.R + (Color.DarkRed.R - Color.Black.R) / 2,
               Color.Black.B + (Color.DarkRed.B - Color.Black.B) / 2
               );
            Color DarkRedRed = Color.FromArgb(
                Color.DarkRed.R + (Color.Red.R - Color.DarkRed.R) / 2,
                Color.DarkRed.G + (Color.Red.G - Color.DarkRed.G) / 2,
                Color.DarkRed.B + (Color.Red.B - Color.DarkRed.B) / 2
                );
            Color RedWhite = Color.FromArgb(
                Color.Red.R + (Color.White.R - Color.Red.R) / 2,
                Color.Red.G + (Color.White.G - Color.Red.G) / 2,
                Color.Red.B + (Color.White.B - Color.Red.B) / 2
                );
            //вспомогательные цвета для округление зеленого
            Color BlackDarkGreen = Color.FromArgb(
               Color.Black.G + (Color.DarkGreen.G - Color.Black.G) / 2,
               Color.Black.R + (Color.DarkGreen.R - Color.Black.R) / 2,
               Color.Black.B + (Color.DarkGreen.B - Color.Black.B) / 2
               );
            Color DarkGreenGreen = Color.FromArgb(
                Color.DarkGreen.R + (Color.Green.R - Color.DarkGreen.R) / 2,
                Color.DarkGreen.G + (Color.Green.G - Color.DarkGreen.G) / 2,
                Color.DarkGreen.B + (Color.Green.B - Color.DarkGreen.B) / 2
                );
            Color GreenWhite = Color.FromArgb(
                Color.Green.R + (Color.White.R - Color.Green.R) / 2,
                Color.Green.G + (Color.White.G - Color.Green.G) / 2,
                Color.Green.B + (Color.White.B - Color.Green.B) / 2
                );
            //вспомогательные цвета для округление синего
            Color BlackDarkBlue = Color.FromArgb(
               Color.Black.G + (Color.DarkBlue.G - Color.Black.G) / 2,
               Color.Black.R + (Color.DarkBlue.R - Color.Black.R) / 2,
               Color.Black.B + (Color.DarkBlue.B - Color.Black.B) / 2
               );
            Color DarkBlueBlue = Color.FromArgb(
                Color.DarkBlue.R + (Color.Blue.R - Color.DarkBlue.R) / 2,
                Color.DarkBlue.G + (Color.Blue.G - Color.DarkBlue.G) / 2,
                Color.DarkBlue.B + (Color.Blue.B - Color.DarkBlue.B) / 2
                );
            Color BlueWhite = Color.FromArgb(
                Color.Blue.R + (Color.White.R - Color.Blue.R) / 2,
                Color.Blue.G + (Color.White.G - Color.Blue.G) / 2,
                Color.Blue.B + (Color.White.B - Color.Blue.B) / 2
                );
            //вспомогательные цвета для окрукления диапозона в 4 отенка ЧБ:
            Color BlackDarkGray = Color.FromArgb(
                Color.Black.R + (Color.DarkGray.R - Color.Black.R) / 2,
                Color.Black.G + (Color.DarkGray.G - Color.Black.G) / 2,
                Color.Black.B + (Color.DarkGray.B - Color.Black.B) / 2
                );
            Color DarkGrayGray = Color.FromArgb(
                Color.DarkGray.R + (Color.Gray.R - Color.DarkGray.R) / 2,
                Color.DarkGray.G + (Color.Gray.G - Color.DarkGray.G) / 2,
                Color.DarkGray.B + (Color.Gray.B - Color.DarkGray.B) / 2
                );
            Color GrayWhite = Color.FromArgb(
                Color.Gray.R + (Color.White.R - Color.Gray.R) / 2,
                Color.Gray.G + (Color.White.G - Color.Gray.G) / 2,
                Color.Gray.B + (Color.White.B - Color.Gray.B) / 2
                );
            Color White = Color.FromArgb(255, 255, 255);
            ////Округление оттенков в красного
            //if (ColorIsRange(color, Color.Black, BlackDarkRed))
            //    return ConsoleColor.Black;
            //if (ColorIsRange(color, BlackDarkRed, DarkRedRed))
            //    return ConsoleColor.DarkGray;
            //if (ColorIsRange(color, DarkRedRed, RedWhite))
            //    return ConsoleColor.Gray;
            //if (ColorIsRange(color, GrayWhite, White))
            //    return ConsoleColor.White;
            //Округление оттенков в чб            
            if (ColorIsRange(color, Color.Black, BlackDarkGray))
                return ConsoleColor.Black;
            if (ColorIsRange(color, BlackDarkGray, DarkGrayGray))
                return ConsoleColor.DarkGray;
            if (ColorIsRange(color, DarkGrayGray, GrayWhite))
                return ConsoleColor.Gray;
            if (ColorIsRange(color, GrayWhite, White))
                return ConsoleColor.White;
            if (color == White)
                return ConsoleColor.White;
            return ConsoleColor.Red;
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
