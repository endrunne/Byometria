using Domain.Interfaces.IRepository;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Infra
{
    public class ImageRepository : IImageRepository
    {
        public void ImageByteHandler(Image img)
        {
            using (var stream = new System.IO.MemoryStream())
            {
                img.Save(stream, ImageFormat.Png);

                for (int pixelsPercorridos = 0; pixelsPercorridos <= img.Width; pixelsPercorridos++)
                {
                    Console.WriteLine(stream.ToArray().GetValue(pixelsPercorridos));
                }
            }
        }
    }
}