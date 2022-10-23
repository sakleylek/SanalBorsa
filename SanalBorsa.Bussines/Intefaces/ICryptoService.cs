using SanalBorsa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Bussines.Intefaces
{
    public interface ICryptoService
    {
        Task<Crypto> AddCryptoAsync(Crypto crypto);
        Task<IEnumerable<Crypto>> ListCrypto();
        Task DeleteCrypto(int id);
        Task<Crypto> GetByIdCrypto(int id);
    }
}
