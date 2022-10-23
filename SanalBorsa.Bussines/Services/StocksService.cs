using SanalBorsa.Bussines.Intefaces;
using SanalBorsa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Bussines.Services
{
    public class StocksService : IStocksService
    {
        public Task<Stocks> AddStocksAsync(Stocks stock)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStocks(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Stocks> GetByIdStocks(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Stocks>> ListStocks()
        {
            throw new NotImplementedException();
        }
    }
}
