using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces.IServices;
using System.Drawing;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BioController : ControllerBase
    {
        private readonly IConvertImageToByteArray _convertImageToByteArray;

        public BioController(IConvertImageToByteArray convertImageToByteArray)
        {
            _convertImageToByteArray = convertImageToByteArray;
        }

        // POST api/Bio
        [HttpPost]
        public void Post(IFormFile file)
        {
            Image img = Image.FromStream(file.OpenReadStream());

            _convertImageToByteArray.ConvertImage(img);
        }

    }
}
