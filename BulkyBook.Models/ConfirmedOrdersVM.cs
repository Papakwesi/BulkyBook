using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class ConfirmedOrdersVM
    {
        public IEnumerable<OrderHeader> ConfirmedOrders { get; set; }
    }

}
