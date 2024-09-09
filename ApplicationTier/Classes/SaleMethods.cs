using ApplicationTier.Dtos;
using ApplicationTier.Interfaces;
using IndustryConnect_Week_Microservices.Models;
using Microsoft.EntityFrameworkCore;

namespace ApplicationTier.Classes
{
    public class SaleMethods : ISaleMethods
    {
        public async Task<SaleDto> AddSale(int customerId, int productId, int storeId, DateTime dateSold)
        {
            var context = new IndustryConnectWeek2Context();

            var sale = new Sale
            {
                CustomerId = customerId,
                ProductId = productId,
                StoreId = storeId,
                DateSold = dateSold
                
            };
           
            context.Add(sale);
            await context.SaveChangesAsync();         
            return Mapper(sale);

        }
        private static SaleDto? Mapper(Sale? sale)
        {
            if (sale != null)
            {
                var saleDto = new SaleDto
                {
                    Id = sale.Id,
                    CustomerId = Convert.ToInt32(sale?.CustomerId),
                    ProductId = Convert.ToInt32(sale?.ProductId),
                    StoreId = Convert.ToInt32(sale?.StoreId),
                    DateSold = sale?.DateSold  
                };

                return saleDto;
            }
            else
            {
                return null;
            }
        }
    }
}
