using Domain.Interfaces.IRepository;
using Domain.Interfaces.IServices;
using System.Drawing;

namespace Services
{
    public class ConvertImageToByteArray : IConvertImageToByteArray
    {
        private static IImageRepository _imageRepository;

        public ConvertImageToByteArray(IImageRepository convertImageToByteArray)
        {
            _imageRepository = convertImageToByteArray;
        }

        public void ConvertImage(Image img)
        {
            _imageRepository.ImageByteHandler(img);
        }
    }
}
