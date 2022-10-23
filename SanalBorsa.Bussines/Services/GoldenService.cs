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
    public class GoldenService : IGoldenService
    {
        private readonly IRepository<Golden> _repository;

        public GoldenService(IRepository<Golden> repository)
        {
            _repository = repository;
        }

        public async Task<Golden> AddGoldenAsync(Golden golden)
        {
            golden.CDate = DateTime.Now;
            await _repository.AddAsync(golden);
            return golden;
        }
        public async Task<IEnumerable<Golden>> ListGolden()
        {
            return await _repository.GetAllAsync();
        }
        public async Task DeleteGolden(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            _repository.Remove(entity);
        }

        public async Task<Golden> GetByIdGolden(int id)
        {
            return await _repository.GetByIdAsync(id);

        }

    }
}
