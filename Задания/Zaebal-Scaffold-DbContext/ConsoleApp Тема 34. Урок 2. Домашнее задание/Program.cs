using System;
using ConsoleApp_Тема_34._Урок_2._Домашнее_задание_;
using ConsoleApp_Тема_34._Урок_2._Домашнее_задание_.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var новыйОбьектВКатегорииОдинИнструменты = new Categories("Инструменты", "Различные строительные инструменты");
var новыйОбьектВКатегорииДваЕда = new Categories("Еда", "Различные вариации вкусной и не очень еды");

var СписокТоваровОдин = new List<Products>
{
    new Products("Молоток", "Молоток универсальный, металлический", 1279.99m, новыйОбьектВКатегорииОдинИнструменты),
    new Products("Пила", "Очень прочная, очень острая пила", 4999.99m, новыйОбьектВКатегорииОдинИнструменты),
    new Products("Отвертка", "Качественная отвертка с приятной ручкой", 987.21m, новыйОбьектВКатегорииОдинИнструменты),
    new Products("Пассатижи", "Не очень хорошие, но цена низкая", 200.30m, новыйОбьектВКатегорииОдинИнструменты),
    new Products("Кусачки", "Кусачки титановые, острые", 8909.89m, новыйОбьектВКатегорииОдинИнструменты),
};

var СписокТоваровДва = new List<Products>
{
    new Products("Хлеб ржаной", "Сормовский хлеб - очевидный выбор для Нижегородцев!", 43, новыйОбьектВКатегорииДваЕда),
    new Products("Молоко", "Пейте люди молоко, будете здоровы", 89, новыйОбьектВКатегорииДваЕда)
};

var listOrderOne = new List<Orders>();
var UserOne = new Users("Маша", "masyhka2009@gmail.com", "VALIotsyda", listOrderOne);

var listOrderTwo = new List<Orders>();
var UserTwo = new Users("Саша", "syhkane18@gmail.com", "SyperSlogniParolYMenia", listOrderTwo);

var ОдинОбьектЗаказа = new Orders() { UserOrder = UserOne, OrderProduct = СписокТоваровОдин };
var ВторойОбьектЗаказа = new Orders() { UserOrder = UserTwo, OrderProduct = СписокТоваровДва };

listOrderOne.Add(ОдинОбьектЗаказа);
UserOne.OrdersUser = listOrderOne;

listOrderTwo.Add(ВторойОбьектЗаказа);
UserTwo.OrdersUser = listOrderTwo;


using (DataBaseCategories DbCategories = new DataBaseCategories())
{
    DbCategories.Add(новыйОбьектВКатегорииОдинИнструменты);
    DbCategories.Add(новыйОбьектВКатегорииДваЕда);
    DbCategories.SaveChanges();
}

using (DataBaseOrders DbOrders = new DataBaseOrders())
{
    DbOrders.Add(ОдинОбьектЗаказа);
    DbOrders.Add(ВторойОбьектЗаказа);
    DbOrders.SaveChanges();
}

using (DataBaseProducts DbProducts = new DataBaseProducts())
{
    for (int i = 0; i < СписокТоваровОдин.Count; i++)
    {
        DbProducts.Add(СписокТоваровОдин[i]);
    }
    for (int i = 0; i < СписокТоваровДва.Count; i++)
    {
        DbProducts.Add(СписокТоваровДва[i]);
    }

    DbProducts.SaveChanges();
}

using (DataBaseUsers DbUsers = new DataBaseUsers()) 
{
    DbUsers.Add(UserOne);
    DbUsers.Add(UserTwo);
    DbUsers.SaveChanges();
}


// Тема 34. Урок 3. Домашнее задание. Конфигурирование строки подключения.

// В файле myConfigurationFileFromDateBase.json добавить строку подключения (локально через Data Source=) или (к сереверу используя MS SQL Server  "Server=;Database=;User Id=;Password=;TrustServerCertificate=True;")


// Установлен пакет установите пакет Microso.Extensions.Configuraешon.Json, он предоставляет базовые классы для дальнейшей работы.

// Как пример буду использовать users для DbContext

var builder = new ConfigurationBuilder();
// установка пути к текущему каталогу 
builder.SetBasePath(Directory.GetCurrentDirectory());

// получаем конфигурацию из файла myConfigurationFileFromDataBase.json 
builder.AddJsonFile("myConfigurationFileFromDataBase.json");

// создаем конфигурацию 
var config = builder.Build();

// получаем строку подключения 
var connectionString = config.GetConnectionString("DefaultConnection");

var optionsBuilder = new DbContextOptionsBuilder<DataBaseUsers>();
var options = optionsBuilder.UseSqlite(connectionString).Options;

using (DataBaseUsers db = new DataBaseUsers(options))
{
    db.Add(UserOne);
    db.Add(UserTwo);
    db.SaveChanges();
}