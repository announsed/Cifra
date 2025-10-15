using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Тема_34._Урок_2._Домашнее_задание_.Entities
{
    internal class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ИмяПродукта", TypeName = "NVARCHAR(40)")]
        public string NameProduct { get; set; }
        [Column("ОписаниеПродукта", TypeName = "NVARCHAR")]
        public string DescriptionProduct { get; set; }
        [Column("ЦенаПродукта")]
        public decimal PriceProduct { get; set; }
        [Column("КатегорияПродукта")]
        public Categories Categories { get; set; }

        public Products() 
        {

        }

        public Products(string nameProduct, string descriptionProduct, decimal priceProduct, Categories categories)
        {
            NameProduct = nameProduct;
            DescriptionProduct = descriptionProduct;
            PriceProduct = priceProduct;
            Categories = categories;
        }
    }
}
