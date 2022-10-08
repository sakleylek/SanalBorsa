using SanalBorsa.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Core.Entities
{
    public class Crypto : BaseEntity
    {
        
        public string ShortName { get; set; }
        public decimal DollarPrice { get; set; }
        public decimal TlPrice { get; set; }
        public string MarketingValue { get; set; }
        public string MarketingSize { get; set; }
        public string ImgPath { get; set; }
    }
}
