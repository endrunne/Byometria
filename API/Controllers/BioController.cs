using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces.IServices;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using Domain.Entities;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BioController : ControllerBase
    {
        private readonly IConvertImageToByteArray _convertImageToByteArray;
        private ImageEntity imageEntity = new ImageEntity();

        public BioController(IConvertImageToByteArray convertImageToByteArray)
        {
            _convertImageToByteArray = convertImageToByteArray;
        }

        // POST api/Bio
        [HttpPost]
        public IActionResult PostImage(IFormFile firstImage, IFormFile secondImage)
        {
            return Ok(GetImage(firstImage, secondImage));

        }

        private object GetImage(IFormFile firstImage, IFormFile secondImage)
        {
            Bitmap imageOne = new Bitmap(Image.FromStream(firstImage.OpenReadStream()));
            Bitmap imageTwo = new Bitmap(Image.FromStream(secondImage.OpenReadStream()));

            imageEntity.FirstImage = imageOne;
            imageEntity.SecondImage = imageTwo;

            return _convertImageToByteArray.ConvertImage(imageEntity);
        }
    }
}
