using SanalBorsa.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Bussines
{
    public interface IGoldenService
    {
        Task<Golden> AddGoldenAsync(Golden golden);
        Task<IEnumerable<Golden>> ListGolden();
        Task DeleteGolden(int id);
    }
}
