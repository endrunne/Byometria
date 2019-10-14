using Domain.Interfaces.IRepository;
using Domain.Interfaces.IServices;
using System.Drawing;

namespace Services
{
    public class ConvertImageToByteArray : IConvertImageToByteArray
    {
        private static IImageRepository _convertImageToByteArray;

        public ConvertImageToByteArray(IImageRepository convertImageToByteArray)
        {
            _convertImageToByteArray = convertImageToByteArray;
        }

        public void ConvertImage(Image img)
        {            
            _convertImageToByteArray.ImageByteHandler(img);
        }
    }
}
