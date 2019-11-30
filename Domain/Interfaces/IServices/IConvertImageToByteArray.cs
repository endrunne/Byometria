using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IConvertImageToByteArray
    {
        object ConvertImage(ImageEntity imageEntity);
    }
}
