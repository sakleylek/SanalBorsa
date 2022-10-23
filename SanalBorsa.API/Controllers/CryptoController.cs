using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanalBorsa.Bussines;
using SanalBorsa.Bussines.Intefaces;
using SanalBorsa.Core.Entities;

namespace SanalBorsa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoController : ControllerBase
    {
        private readonly ICryptoService _cryptoService;

        public CryptoController(ICryptoService cryptoService)
        {
            _cryptoService = cryptoService;
        }

        [HttpPost]
        [Route("AddCrypto")]
        public async Task<IActionResult> AddCrypto(Crypto crypto)
        {
            var crypto1 = await _cryptoService.AddCryptoAsync(crypto);
            if (crypto != null)
            {
                return Ok(crypto);
            }
            else
            {
                return BadRequest("!!!!!!!!");
            }
        }

        [HttpGet]
        [Route("GetAllCrypto")]
        public async Task<IActionResult> GetAllCrypto()
        {
            var listCrypto = await _cryptoService.ListCrypto();
            return Ok(listCrypto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var crypto = await _cryptoService.GetByIdCrypto(id);

            if (crypto != null)
            {
                return Ok(crypto);
            }
            else
            {
                return NotFound();
            }

        }


        [HttpDelete]
        [Route("DeleteCrypto/{id:int}")]
        public async Task<IActionResult> DeleteCrypto(int id)
        {
            await _cryptoService.DeleteCrypto(id);
            return Ok();
        }

    }
}
