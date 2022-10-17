using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePixelationTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen(10, 10, 2);
            screen.DrawScreen(0, 0);
        }
    }
}
