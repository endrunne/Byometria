using Microsoft.AspNetCore.Mvc;
using Domain.Interfaces.IServices;

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
        public void Post()
        {   
        }

    }
}
