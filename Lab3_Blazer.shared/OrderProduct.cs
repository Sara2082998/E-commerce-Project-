using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Blazer.shared
{
    public class OrderProduct
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public int quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }

    }
}
