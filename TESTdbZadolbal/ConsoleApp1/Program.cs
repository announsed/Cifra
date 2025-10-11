using Bogus;
using ConsoleApp1;

public class Programm
{
    public static void Main(string[] args)
    {
        using (TestDbContext dbContext = new TestDbContext())
        {
            dbContext.Database.EnsureCreated();
            var contecst = dbContext.Inventories.ToList();

            foreach (var item in contecst)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Quantity}");
            }
        }
        ;

        using (AppUserContext context = new AppUserContext())
        {
            var fa = new Faker<User>()

                .RuleFor(c => c.Name, f => f.Name.FullName())
    // Email на основе имени (для согласованности)
    .RuleFor(c => c.Email, (f, c) => f.Internet.Email(c.Name.ToLower()))
    // Дата рождения в прошлом (18-65 лет назад)
    .RuleFor(c => c.Age, f => f.Random.Int(0, 150))

            ;

            for (int i = 0; i < 6; i++)
            {
                var user = fa.Generate();
                context.Add(user);
            }
            context.SaveChanges();
        }
    }
}