using BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackatonVtb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IFileService _fileService;

        public DataController(IFileService fileService)
        {
            _fileService = fileService;
        }
            

       
        [HttpGet("dataset/list")]
        public async Task<IActionResult> GetDatasetList()
        {
            return Ok();
        }


        [HttpPost("dataset")]
        public async Task<IActionResult> SaveAsync([FromForm] IFormFile file)
        {
            var extentions = file.ContentType?.Split('/');
            string fileExtention = extentions.Length > 1 ? extentions[1] : string.Empty;

            await _mediator.Send(new CreateFileCommand
            {
                ContentType = file.ContentType,
                FileExtention = fileExtention,
                Body = await _fileService.ReadDataFromFile(file),
                Name = file.FileName,
                UploadedDate = DateTime.Now
            });

            return Ok();
        }
    }
}
