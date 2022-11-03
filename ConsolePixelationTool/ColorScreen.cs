using System.Drawing;

namespace ConsolePixelationTool
{
    internal class ColorScreen : Screen
    {
        public ColorScreen(int Height, int Width, int PixelSize) : base(Height, Width, PixelSize)
        {
        }
        public override void ChangeScreen(Bitmap img)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].PixelColor = new ColorConverter().ConvertToConsoleColor(img.GetPixel(x, y));
                }
            }
        }
        public override void DrawScreen(int posX, int posY)
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    this.Frame[x, y].SetColor();
                    this.Frame[x, y].DrawPixel(posX + x * PixelSizeX, posY + y);
                }
            }
            this.Frame[0 , 0].ResetColor();
        }
    }
}
