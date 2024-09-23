using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Portfolio
    {
        [Key]
        public int PortfolioId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
