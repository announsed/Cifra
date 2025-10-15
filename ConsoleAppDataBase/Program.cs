using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;


using (DB myDataBase = new DB()) 
{
    myDataBase.person.Add(new Person() {Age = 12, Description = "Хлопает в ладоши", Name = "Ангелина" });

    myDataBase.SaveChanges();
}


public class Person 
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("User_Id")]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public int Age { get; set; }

    public string Parrents { get; set; }

}

public class DB : DbContext
{
    public DB()
    {

    }

   public DbSet<Person> person { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Student\\source\\repos\\Sergey\\Cifra\\ConsoleAppDataBase\\DB.db");
    }
}