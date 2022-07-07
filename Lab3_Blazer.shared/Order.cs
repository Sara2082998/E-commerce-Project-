using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Blazer.shared
{
    public class Order
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string address { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime date { get; set; }

        public Boolean submitted { get; set; }

        public Boolean deliverd { get; set; }
        //public virtual List<OrderProduct> orderProducts { get; set; }
    }
}
