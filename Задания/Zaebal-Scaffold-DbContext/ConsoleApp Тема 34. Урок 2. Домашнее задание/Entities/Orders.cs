using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Тема_34._Урок_2._Домашнее_задание_.Entities
{
    internal class Orders
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ДатаЗаказа", TypeName = "DATETIME")]
        public DateTime TimeOrder { get; set; }
        [Column("СтатусЗаказа", TypeName = "NVARCHAR(25)")]
        public string? Status { get; set; }
        [Column("ЗаказПользователя")]
        public Users UserOrder { get; set; }
        [Column("ПродуктыПользователя")]
        public List<Products> OrderProduct { get; set; }

        public Orders() 
        {

        }

        public Orders(DateTime timeOrder, string status, Users userOrder, List<Products> orderProduct)
        {
            TimeOrder = timeOrder;
            Status = status;
            UserOrder = userOrder;
            OrderProduct = orderProduct;
        }
    }
}
