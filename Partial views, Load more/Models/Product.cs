using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_views__Load_more.Models
{
    public class Product : BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "decimal(14,4)")]
        public decimal Price { get; set; }
    }
}
