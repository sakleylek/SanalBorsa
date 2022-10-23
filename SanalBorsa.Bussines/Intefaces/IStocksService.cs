using SanalBorsa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Bussines.Intefaces
{
    public interface IStocksService
    {
        Task<Stocks> AddStocksAsync(Stocks stock);
        Task<IEnumerable<Stocks>> ListStocks();
        Task DeleteStocks(int id);
        Task<Stocks> GetByIdStocks(int id); // stocks diye değiştir sonrasında bunları imlemente et daha sonra controllera ekle sonra build alıp denenecek.daha sonra aynılarını id için yap.
    }
}
