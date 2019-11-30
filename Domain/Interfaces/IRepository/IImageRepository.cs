using Domain.Entities;
using System.Drawing;

namespace Domain.Interfaces.IRepository
{
    public interface IImageRepository
    {
        void ImageByteHandler(ImageEntity imageEntity);
        void TurnToGrayscale(Bitmap image);
        object CompareTwoImages(ImageEntity imageEntity);
        string CompareResult(Color firstImage, Color secondImage);
    }
}
