using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Models
{
    public class Product
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen isim giriniz!")]
        [Display(Name ="Ürün adı")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama giriniz")]
        [Display(Name = "Ürün açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Ürün oylaması")]
        public double Rating { get; set; }
        [Display(Name = "Ürün fiyatı")]
        public decimal Price { get; set; }
        [Display(Name = "İndirim miktarı")]
        public double Discount { get; set; }
        public string ImageURL { get; set; }
        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
