using api.Models;
using api.Dtos;
using api.Dtos.Stock;
using System.ComponentModel.DataAnnotations.Schema;

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

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockDto) 
        {
            return new Stock
            {
                 Symbol = stockDto.Symbol,
                 CompanyName= stockDto.CompanyName,
                 Purchase=stockDto.Purchase,
                 LastDiv=stockDto.LastDiv,
                 Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }

        public static Stock ToStockFromUpdateStockRequestDto(this UpdateStockRequestDto stockDto) 
        {
            return new Stock
            {
                Symbol = stockDto.Symbol,
                CompanyName = stockDto.CompanyName,
                Purchase = stockDto.Purchase,
                LastDiv = stockDto.LastDiv,
                Industry = stockDto.Industry,
                MarketCap = stockDto.MarketCap
            };
        }
    }
}
