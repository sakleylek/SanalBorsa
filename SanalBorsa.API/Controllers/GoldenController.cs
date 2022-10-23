using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanalBorsa.Bussines.Intefaces;
using SanalBorsa.Core.Entities;

namespace SanalBorsa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoldenController : ControllerBase
    {
        private readonly IGoldenService _goldenService;

        public GoldenController(IGoldenService goldenService)
        {
            _goldenService = goldenService;
        }


        [HttpPost]
        [Route("AddGolden")]
        public async Task<IActionResult> AddGolden(Golden golden)
        {
            var gold = await _goldenService.AddGoldenAsync(golden);
            if (gold!=null)
            {
                return Ok(gold);
            }
            else
            {
                return BadRequest("!!!!!!!!");
            }
        }

        [HttpGet]
        [Route("GetAllGolden")]
        public async Task<IActionResult> GetAllGolden()
        {
            var listGolden = await _goldenService.ListGolden();
            return Ok(listGolden);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var golden = await _goldenService.GetByIdGolden(id);
            
            if (golden != null)
            {
                return Ok(golden);
            }
            else
            {
                return NotFound();
            }
            
        }


        [HttpDelete]
        [Route("DeleteGolden/{id:int}")]
        public async Task<IActionResult> DeleteGolden(int id)
        {
            await _goldenService.DeleteGolden(id);
            return Ok();
        }

    }
}
