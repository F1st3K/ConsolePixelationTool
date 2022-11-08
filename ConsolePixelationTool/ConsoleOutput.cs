using System;

namespace ConsolePixelationTool
{
    internal class ConsoleOutput
    {
        private int PixelSizeX;
        private char ColorSymbol;
        private Pixel[,] Frame;
        public ConsoleOutput(int pixelSizeX, Pixel[,] frame, char colorSymbol)
        {
            PixelSizeX = pixelSizeX;
            ColorSymbol = colorSymbol;
            Frame = frame;
        }

        public void SymbolOutput()
        {
            for (int y = 0; y < Frame.GetLength(1); y++)
            {
                for (int x = 0; x < Frame.GetLength(2); x++)
                {
                    Console.SetCursorPosition(x, y);
                    for (int i = 0; i < PixelSizeX; i++)
                        Console.Write(Frame[x, y].PixelSymbol);
                }
            }
        }
        public void ColorOutput ()
        {
            for (int y = 0; y < Frame.GetLength(1); y++)
            {
                for (int x = 0; x < Frame.GetLength(2); x++)
                {
                    Console.ForegroundColor = Frame[x, y].PixelColor;
                    Console.SetCursorPosition(x, y);
                    for (int i = 0; i < PixelSizeX; i++)
                        Console.Write(ColorSymbol);
                }
            }
            Console.ResetColor();
        }
        public void SymbolColorOutput()
        {
            for (int y = 0; y < Frame.GetLength(1); y++)
            {
                for (int x = 0; x < Frame.GetLength(2); x++)
                {
                    Console.ForegroundColor = Frame[x, y].PixelColor;
                    Console.SetCursorPosition(x, y);
                    for (int i = 0; i < PixelSizeX; i++)
                        Console.Write(Frame[x, y].PixelSymbol);
                }
            }
            Console.ResetColor();
        }
    }
}
