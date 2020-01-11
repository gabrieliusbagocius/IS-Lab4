using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Tesseract;

namespace Test
{
    static class Program
    {
        static void Main()
        {
            var img = Pix.LoadFromFile(@"C:\Users\navi\source\repos\Laboratory4\tst2.png");
            TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
            Page page = engine.Process(img, PageSegMode.Auto);
            string result = page.GetText();
            Console.WriteLine(result);
        }
    }
}