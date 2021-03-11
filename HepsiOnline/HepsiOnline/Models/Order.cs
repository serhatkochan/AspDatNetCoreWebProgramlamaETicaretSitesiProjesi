using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HepsiOnline.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; }
        [Required(ErrorMessage = "Lütfen bi isim giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen adresinizi tam yazınız")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        [Required(ErrorMessage = "Lütfen bir şehir giriniz")]
        public string City { get; set; }
        [Required(ErrorMessage = "Lütfen bir ilçe giriniz")]
        public string State { get; set; }
        public string Zip { get; set; }
        [Required(ErrorMessage = "Lütfen bir ülke giriniz")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
        [BindNever]
        public bool Shipped { get; set; }

    }
}
