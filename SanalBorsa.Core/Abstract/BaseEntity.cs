using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalBorsa.Core.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CDate { get; set; }
        public DateTime? UDate{ get; set; }
        public bool IsDeleted { get; set; }
        public decimal Change { get; set; }
    }
}
