using Domain.Entities;
using Domain.Interfaces.IRepository;
using Domain.Interfaces.IServices;

namespace Services
{
    public class ConvertImageToByteArray : IConvertImageToByteArray
    {
        private static IImageRepository _imageRepository;

        public ConvertImageToByteArray(IImageRepository convertImageToByteArray)
        {
            _imageRepository = convertImageToByteArray;
        }

        public object ConvertImage(ImageEntity imageEntity)
        {            
            _imageRepository.ImageByteHandler(imageEntity);

            return _imageRepository.CompareTwoImages(imageEntity);
        }
    }
}
