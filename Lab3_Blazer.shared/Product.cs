using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Blazer.shared
{
    public class Product
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        [MaxLength(25)]
        [MinLength(3, ErrorMessage = "Name Must Be More Than 5 Char")]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Column(TypeName = "varchar(200)")]
        [Required]
        [MaxLength(25)]
        [MinLength(3, ErrorMessage = "Name Must Be More Than 2 Char")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(50)")]

        [Required]
        [RegularExpression(@"\w+\.(jpg|png)")]
        public string img { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //public virtual List<OrderProduct> orderProducts { get; set; }
    }
}
