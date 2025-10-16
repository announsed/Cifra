using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Тема_34._Урок_2._Домашнее_задание_.Entities
{
    internal class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("ИмяПользователя", TypeName = "NVARCHAR(25)")]
        public string NameUser { get; set; }
        [Column("ПочтаПользователя", TypeName = "NVARCHAR(25)")]
        public string EMailUser { get; set; }
        [Column("ПарольПользователя", TypeName = "NVARCHAR(25)")]
        public string PasswordUser { get; set; }
        [Column("ЗаказыПользователя")]
        public List<Orders> OrdersUser { get; set; }

        public Users() 
        {

        }

        public Users(string nameUser, string eMailUser, string passwordUser, List<Orders> ordersUser)
        {
            NameUser = nameUser;
            EMailUser = eMailUser;
            PasswordUser = passwordUser;
            OrdersUser = ordersUser;
        }

    }
}
