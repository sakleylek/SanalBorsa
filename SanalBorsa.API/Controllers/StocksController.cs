using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanalBorsa.Bussines.Intefaces;

namespace SanalBorsa.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        private readonly IStocksService _stocksService;

        public StocksController(IStocksService stocksService)
        {
            _stocksService = stocksService;
        }
    }
}
