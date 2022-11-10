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
        const char BLACK = '.';             
        const char GRAPHITE_BLACK = ':';    
        const char SIGNAL_BLACK = '!';
        const char GRAY_BROWN = '/';
        const char WETASPHALT_GRAY = 'r';
        const char DIM_GRAY = '(';
        const char DULL_GRAY = 'l';
        const char GRAY = '1';
        const char PEARLDARK_GRAY = 'Z';
        const char PEARLLIGHT_GRAY = '4';
        const char WHITE_ALUMINUM = 'H';
        const char LIGHT_GRAY = '9';
        const char LIGHT_TELEGRAY = 'W';
        const char BRIGHT_GRAY = '8';
        const char GAINSBOROUGH_GRAY = '$';
        const char WHITE = '@';
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
        public char ConvertToConsoleSymbol(Color color)
        {
            if (color.GetBrightness() >= 0.0 && color.GetBrightness() < 0.0625)
                return BLACK;
            if (color.GetBrightness() >= 0.0625 && color.GetBrightness() < 0.125)
                return GRAPHITE_BLACK;
            if (color.GetBrightness() >= 0.125 && color.GetBrightness() < 0.1875)
                return SIGNAL_BLACK;
            if (color.GetBrightness() >= 0.1875 && color.GetBrightness() < 0.25)
                return GRAY_BROWN;

            if (color.GetBrightness() >= 0.25 && color.GetBrightness() <= 0.3125)
                return WETASPHALT_GRAY;
            if (color.GetBrightness() >= 0.3125 && color.GetBrightness() <= 0.375)
                return DIM_GRAY;
            if (color.GetBrightness() >= 0.375 && color.GetBrightness() <= 0.4375)
                return DULL_GRAY;
            if (color.GetBrightness() >= 0.4375 && color.GetBrightness() <= 0.5)
                return GRAY;

            if (color.GetBrightness() >= 0.5 && color.GetBrightness() <= 0.5625)
                return PEARLDARK_GRAY;
            if (color.GetBrightness() >= 0.5625 && color.GetBrightness() <= 0.625)
                return PEARLLIGHT_GRAY;
            if (color.GetBrightness() >= 0.625 && color.GetBrightness() <= 0.6875)
                return WHITE_ALUMINUM;
            if (color.GetBrightness() >= 0.6875 && color.GetBrightness() <= 0.75)
                return LIGHT_GRAY;

            if (color.GetBrightness() >= 0.75 && color.GetBrightness() <= 0.8125)
                return LIGHT_TELEGRAY;
            if (color.GetBrightness() >= 0.8125 && color.GetBrightness() <= 0.875)
                return BRIGHT_GRAY;
            if (color.GetBrightness() >= 0.875 && color.GetBrightness() <= 0.9375)
                return GAINSBOROUGH_GRAY;
            if (color.GetBrightness() >= 0.9375 && color.GetBrightness() <= 1.0)
                return WHITE;
            return BLACK;
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

