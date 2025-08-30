using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using VideoUpload.Infra;

namespace VideoSite.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VideosController : ControllerBase
    {
        private readonly IVideosRepository _repo;
        private readonly IWebHostEnvironment _env;

        public VideosController(IVideosRepository repo, IWebHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }

        [HttpPost("upload")]
        public IActionResult Upload([FromForm] IFormFile file, [FromForm] string title, [FromForm] string description, [FromForm] string[] categories)
        {
            var uploadsFolder = Path.Combine(_env.ContentRootPath, "Uploads");

            if (!Directory.Exists(uploadsFolder))
                Directory.CreateDirectory(uploadsFolder);

            //to be continue

            return Ok(new { Message = "Upload successful!" });
        }
    }
}
