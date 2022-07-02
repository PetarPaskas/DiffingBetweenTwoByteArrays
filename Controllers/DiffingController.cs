using Descartes.Domain.DTOs;
using Descartes.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Descartes.Controllers
{
    [Route("/v1/diff")]
    [ApiController]
    public class DiffingController : ControllerBase
    {
        private readonly IDiffingHelper _diffingHelper;
        public DiffingController(IDiffingHelper diffingHelper)
        {
            _diffingHelper = diffingHelper;
        }

        [HttpGet("{pairId}")]
        public async Task<IActionResult> GetDiffResult(int pairId) 
        {
            return Ok();
        }

        [HttpPost("{pairId}/left")]
        public async Task<IActionResult> SubmitLeft(int pairId, [FromBody] PostDataDto data)
        {
            return Ok();
        }

        [HttpPost("{pairId}/right")]
        public async Task<IActionResult> SubmitRight(int pairId, [FromBody] PostDataDto data)
        {
            return Ok();
        }
        
    }
}
