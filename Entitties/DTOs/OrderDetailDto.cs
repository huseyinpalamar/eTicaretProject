using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderDetailDto:IDto
    {
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public float Discount { get; set; }
    }
}
