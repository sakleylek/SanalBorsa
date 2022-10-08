using SanalBorsa.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Core.Entities
{
    public class ExChangeRates :BaseEntity
    {
        public string ShortName { get; set; }
        public decimal LastPrice { get; set; }
        public decimal HighestPrice { get; set; }
        public decimal LowestPrice { get; set; }
        public string MarketingSize { get; set; }
    }
}
