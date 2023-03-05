using ImageMagick;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MagickClickOnce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing...");
            try
            {
                var dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                using (var img = new MagickImage(Path.Combine(dir, "iconmonstr-redo-3-16.png")))
                {
                    var w = img.Width;
                    Console.WriteLine(img.Width);
                    Console.WriteLine(img.Height);
                }
                Console.WriteLine("Done!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
