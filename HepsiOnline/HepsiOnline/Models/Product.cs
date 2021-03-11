using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HepsiOnline.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        [Required(ErrorMessage = "Lütfen bir ürün adı giriniz")] 
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen bir açıklama giriniz")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage = "Lütfen geçerli bir fiyat giriniz")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Lütfen kategori giriniz")]
        public string Category { get; set; }
        public string ImageAdress { get; set; }
    }

}
