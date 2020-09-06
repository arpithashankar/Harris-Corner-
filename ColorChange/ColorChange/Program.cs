using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ColorChange
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\temp\rasp.png";
            Bitmap image = new Bitmap(path, true);
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color clr = image.GetPixel(i, j);
                    Color newclr = Color.FromArgb(clr.R, clr.G, 0);
                    image.SetPixel(i, j, newclr);
                    

                }

            }
            image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\temp\new.png");
            Console.WriteLine("process done");
            Console.ReadLine();



        }
    }
}
