using ApplicationTier.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTier.Interfaces
{
    public interface ISaleMethods
    {
        
        Task<SaleDto> AddSale(int customerId, int productId, int storeId, DateTime dateSold);


    }
}
