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
            System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Open);
            System.Drawing.Image png = System.Drawing.Image.FromStream(fs);
            fs.Close();
            Bitmap img = new Bitmap(png);
            Screen screen = new Screen(img.Height, img.Width, 2);
            screen.ChangeScreen(img);
            screen.DrawScreen(0, 0);
            //screen.RGBTest();
            Console.ResetColor();
        }
    }
}
