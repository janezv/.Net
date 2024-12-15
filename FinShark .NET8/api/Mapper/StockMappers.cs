using api.Models;
using api.Dtos;
using api.Dtos.Stock;

namespace api.Mapper
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock sotckModel) 
        {
            return new StockDto 
            { 
                Id = sotckModel.Id,
                Symbol = sotckModel.Symbol,
                CompanyName = sotckModel.CompanyName,
                Purchase= sotckModel.Purchase,
                LastDiv= sotckModel.LastDiv,
                Industry= sotckModel.Industry,
                MarketCap= sotckModel.MarketCap,
            };
        }
    }
}
