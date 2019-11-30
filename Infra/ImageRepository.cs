using Domain.Entities;
using Domain.Interfaces.IRepository;
using System.Drawing;

namespace Infra
{
    public class ImageRepository : IImageRepository
    {
        public void ImageByteHandler(ImageEntity imageEntity)
        {
            TurnToGrayscale(imageEntity.FirstImage);
        }

        public void TurnToGrayscale(Bitmap image)
        {            
            for (int posicaoX = 0; posicaoX < image.Width; posicaoX++)
            {
                for(int posicaoY = 0; posicaoY < image.Height; posicaoY++)
                {
                    Color getRGB = image.GetPixel(posicaoX, posicaoY);

                    int grayScale = (int)((getRGB.R * 0.3) + (getRGB.G * 0.59) + (getRGB.B * 0.11));

                    Color turnedToGray = Color.FromArgb(getRGB.A, grayScale, grayScale, grayScale);

                    image.SetPixel(posicaoX, posicaoY, turnedToGray);
                }
            }                        
        }

        public object CompareTwoImages(ImageEntity imageEntity)
        {
            TurnToGrayscale(imageEntity.SecondImage);            

            Color firstImage = Color.Empty;
            Color secondImage = Color.Empty;            
            
            if(imageEntity.FirstImage.Width == imageEntity.SecondImage.Width 
                && imageEntity.FirstImage.Height == imageEntity.SecondImage.Height)
            {
                for (int x = 0; x < imageEntity.FirstImage.Width; x++)
                {
                    for (int y = 0; y < imageEntity.FirstImage.Height; y++)
                    {
                        firstImage = imageEntity.FirstImage.GetPixel(x, y);
                        secondImage = imageEntity.SecondImage.GetPixel(x, y);                       
                    }
                }                
            }

            return CompareResult(firstImage, secondImage);
        }

        public string CompareResult(Color firstImage, Color secondImage)
            => firstImage == Color.Empty || secondImage == Color.Empty || firstImage != secondImage ? "these images aren't equal" : "Both images are equal";            
    }
}