using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePixelationTool
{
    internal class ColorConverter
    {
        public ConsoleColor ConvertToConsoleColor(Color color)
        {

            if (ColorIsInRange(color, Color.FromArgb(128, 0, 0), Color.FromArgb(255, 128, 128)))
                return ConsoleColor.Red;

            if (ColorIsInRange(color, Color.FromArgb(0, 128, 0), Color.FromArgb(128, 255, 128)))
                return ConsoleColor.Green;

            if (ColorIsInRange(color, Color.FromArgb(0, 0, 128), Color.FromArgb(128, 128, 255)))
                return ConsoleColor.Blue;


            if (ColorIsInRange(color, Color.FromArgb(128, 128, 0), Color.FromArgb(255, 255, 128)))
                return ConsoleColor.Yellow;

            if (ColorIsInRange(color, Color.FromArgb(0, 128, 128), Color.FromArgb(128, 255, 255)))
                return ConsoleColor.Cyan;

            if (ColorIsInRange(color, Color.FromArgb(128, 0, 128), Color.FromArgb(255, 128, 255)))
                return ConsoleColor.Magenta;

            if (ColorIsInRange(color, Color.Black, Color.FromArgb(128, 128, 128)))
            {
                if (ColorIsInRange(color, Color.FromArgb(64, 64, 64), Color.FromArgb(128, 128, 128)))
                    return ConsoleColor.Gray;
                if (ColorIsInRange(color, Color.FromArgb(64, 0, 0), Color.FromArgb(128, 64, 64)))
                    return ConsoleColor.DarkRed;
                if (ColorIsInRange(color, Color.FromArgb(0, 64, 0), Color.FromArgb(64, 128, 64)))
                    return ConsoleColor.DarkGreen;
                if (ColorIsInRange(color, Color.FromArgb(0, 0, 64), Color.FromArgb(64, 64, 128)))
                    return ConsoleColor.DarkBlue;
                if (ColorIsInRange(color, Color.FromArgb(64, 64, 0), Color.FromArgb(128, 128, 64)))
                    return ConsoleColor.DarkYellow;
                if (ColorIsInRange(color, Color.FromArgb(0, 64, 64), Color.FromArgb(64, 128, 128)))
                    return ConsoleColor.DarkCyan;
                if (ColorIsInRange(color, Color.FromArgb(64, 0, 64), Color.FromArgb(128, 64, 128)))
                    return ConsoleColor.DarkMagenta;
                return ConsoleColor.Black;
            }
            if (ColorIsInRange(color, Color.FromArgb(128, 128, 128), Color.White))
            {
                if (ColorIsInRange(color, Color.FromArgb(128, 128, 128), Color.FromArgb(192, 192, 192)))
                    return ConsoleColor.DarkGray;
                return ConsoleColor.White;
            }
            return ConsoleColor.Black;
        }
        private bool ColorIsInRange(Color InitionalColor, Color MinColor, Color MaxColor)
        {
            if ((InitionalColor.R <= MaxColor.R && InitionalColor.R >= MinColor.R) &&
                (InitionalColor.G <= MaxColor.G && InitionalColor.G >= MinColor.G) &&
                (InitionalColor.B <= MaxColor.B && InitionalColor.B >= MinColor.B))
                return true;
            return false;
        }
    }
}

