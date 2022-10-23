using SanalBorsa.Bussines.Intefaces;
using SanalBorsa.Core.Entities;
using SanalBorsa.Data.Repostories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Bussines.Services
{
    public class CryptoService : ICryptoService
    {
        private readonly IRepository<Crypto> _cryptoRepository;
        public CryptoService(IRepository<Crypto> cryptoRepository)
        {
            _cryptoRepository = cryptoRepository;
        }

        public async Task<Crypto> AddCryptoAsync(Crypto crypto)
        {
            crypto.CDate = DateTime.Now;
            await _cryptoRepository.AddAsync(crypto);
            return crypto;
        }

        public async Task DeleteCrypto(int id)
        {
            var entity = await _cryptoRepository.GetByIdAsync(id);
            _cryptoRepository.Remove(entity);
        }

        public async Task<IEnumerable<Crypto>> ListCrypto()
        {
            return await _cryptoRepository.GetAllAsync();
        }

        public async Task<Crypto> GetByIdCrypto(int id)
        {
            return await _cryptoRepository.GetByIdAsync(id);
        }
    }
}
