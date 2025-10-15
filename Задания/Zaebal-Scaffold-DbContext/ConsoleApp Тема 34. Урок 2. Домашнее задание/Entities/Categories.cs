using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Тема_34._Урок_2._Домашнее_задание_.Entities
{
    internal class Categories
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ИмяКатегории", TypeName = "NVARCHAR(25)") ]
        public string NameCategories { get; set; }
        [Column("ОписаниеКатегории")]
        public string DescriptionsCategoties { get; set; }

        public Categories() 
        {

        }

        public Categories(string nameCategories, string descriptionsCategoties)
        {
            NameCategories = nameCategories;
            DescriptionsCategoties = descriptionsCategoties;
        }
    }
}
