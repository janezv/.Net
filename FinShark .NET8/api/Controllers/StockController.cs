using api.Data;
using Microsoft.AspNetCore.Mvc;
using api.Dtos;
using api.Mapper;

namespace api.Controllers
{
    [Route("api/stock")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public StockController(ApplicationDBContext context)
        {
            _context=context;
        }

        [HttpGet]
        public IActionResult GetAll() 
        { 
            var stocks=_context.stocks.ToList()
                .Select(s => s.ToStockDto());
            return Ok(stocks);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var stock = _context.stocks.Find(id);
            if (stock == null) { 
                return NotFound();
            }
            return Ok(stock.ToStockDto());
        }
    }
}
