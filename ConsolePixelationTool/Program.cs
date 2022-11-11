using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Net.WebRequestMethods;
using System;

namespace ConsolePixelationTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = "gamma.png";
            Bitmap img = new Bitmap(file);
            Screen screen = new Screen(img.Height, img.Width, 2);
            screen.ChangeScreen(img, new Size(500, 500));
            screen.SymbolOutput(0 , 0);
            //screen.RGBTest();
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
