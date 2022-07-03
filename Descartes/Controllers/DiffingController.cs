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

        [HttpPut("{pairId}/left")]
        public async Task<IActionResult> SubmitLeft(int pairId, [FromBody] PutDataDto data)
        {
            return Ok();
        }

        [HttpPut("{pairId}/right")]
        public async Task<IActionResult> SubmitRight(int pairId, [FromBody] PutDataDto data)
        {
            return Ok();
        }

        [HttpGet("{pairId}/{position}")]
        public async Task<IActionResult> Get(int pairId, string position)
        {
            return Ok();
        }
    }
}
