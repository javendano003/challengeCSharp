using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeLeanTechJA.Modelo
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public string Unit { get; set; }
        public decimal PercentageIva { get; set; }
        public string Status { get; set; }

    }
}
