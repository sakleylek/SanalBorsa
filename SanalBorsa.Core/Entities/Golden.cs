using SanalBorsa.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Core.Entities
{
    public class Golden : BaseEntity
    {
        public decimal BuyPrice { get; set; }
        public decimal SalePrice { get; set; }
    }
}
