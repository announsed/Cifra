List<Animal> animals = new List<Animal>();


PredatoryAnimals Tiger = new PredatoryAnimals("Тигр", 34, 32, TypeFood.MeatFood);
OmnivorousAnimals Pig = new OmnivorousAnimals("Свинья", 21, 16, TypeFood.AllFood);
HerbivorousAnimals Rabbit = new HerbivorousAnimals("Кролик", 89, 3, TypeFood.PlantBasedFood);

animals.Add(Tiger);
animals.Add(Pig);
animals.Add(Rabbit);

for (int i = 0; i < animals.Count; i++)
{
    animals[i].Quantity = animals[i].QuantityAndTypeOfFood(animals[i].AnimalWeight, animals[i].typeFood);
}

Console.WriteLine("Без изменений: ");
for (int i = 0; i < animals.Count; i++)
{
    Console.WriteLine("Имя животного: " + animals[i].Name + "  Идентефикатор " + animals[i].ID + "  Потребляемые калории: " + animals[i].QuantityAndTypeOfFood(animals[i].AnimalWeight, animals[i].typeFood));
}

Console.WriteLine("\n\nУпорядоченное по убыванию количества пищи: ");
for (int i = 0; i < animals.Count - 1; i++)
{
    for (int j = 0; j < animals.Count - i - 1; j++)
    {
        if (animals[j].Quantity < animals[j + 1].Quantity)
        {
            int tempQuantity = animals[j].Quantity;
            string tempName = animals[j].Name;
            int tempID = animals[j].ID;
            int tempAnimalWeight = animals[j].AnimalWeight;
            TypeFood tempTypeFood = animals[j].typeFood;

            animals[j].Quantity = animals[j + 1].Quantity;
            animals[j].Name = animals[j + 1].Name;
            animals[j].ID = animals[j + 1].ID;
            animals[j].AnimalWeight = animals[j + 1].AnimalWeight;
            animals[j].typeFood = animals[j + 1].typeFood;

            animals[j + 1].Quantity = tempQuantity;
            animals[j + 1].Name = tempName;
            animals[j + 1].ID = tempID;
            animals[j + 1].AnimalWeight = tempAnimalWeight;
            animals[j + 1].typeFood = tempTypeFood;
        }
    }
}
for (int i = 0; i < animals.Count; i++)
{
    Console.WriteLine("Имя животного: " + animals[i].Name + "  Идентефикатор " + animals[i].ID + "  Потребляемые калории: " + animals[i].QuantityAndTypeOfFood(animals[i].AnimalWeight, animals[i].typeFood));
}

Console.WriteLine("\n\nПервые 5 имён: ");
for (int i = 0; i < animals.Count || i < 5; i++)
{
    Console.Write(animals[i].Name + " ");
}

Console.WriteLine("\n\nПоследние 3 идентификатора: ");
int thee = animals.Count;
for (int i = 0; i < animals.Count || i <= 2; i++)
{
    Console.Write(animals[thee--].ID + " ");
    thee = thee--;
}

enum TypeFood
{
    MeatFood = 1769,
    AllFood = 1342,
    PlantBasedFood = 921
}

abstract class Animal
{
    public string Name { get; set; }
    public int ID { get; set; }
    public int AnimalWeight { get; set; }
    public TypeFood typeFood { get; set; }
    public int Quantity { get; set; }

    public Animal(string Name, int ID, int AnimalWeight, TypeFood typeFood)
    {
        this.Name = Name;
        this.ID = ID;
        this.AnimalWeight = AnimalWeight;
        this.typeFood = typeFood;
    }

    public abstract int QuantityAndTypeOfFood(int AnimalWeight, TypeFood typeFood);
}

class PredatoryAnimals : Animal
{
    internal string Name;
    internal int ID;
    internal int AnimalWeight;
    internal TypeFood TypeFood;
    internal int Quantity;
    public PredatoryAnimals(string AnimalName, int ID, int AnimalWeight, TypeFood TypeFood) : base(AnimalName, ID, AnimalWeight, TypeFood)
    {
        Name = AnimalName;
        this.ID = ID;
        this.AnimalWeight = AnimalWeight;
        this.TypeFood = TypeFood;
    }
    public override int QuantityAndTypeOfFood(int AnimalWeight, TypeFood typeFood)
    {
        return AnimalWeight * (int)typeFood;
    }
}

class OmnivorousAnimals : Animal
{
    internal string Name;
    internal int ID;
    internal int AnimalWeight;
    internal TypeFood TypeFood;
    internal int Quantity;
    public OmnivorousAnimals(string AnimalName, int ID, int AnimalWeight, TypeFood TypeFood) : base(AnimalName, ID, AnimalWeight, TypeFood)
    {
        Name = AnimalName;
        this.ID = ID;
        this.AnimalWeight = AnimalWeight;
        this.TypeFood = TypeFood;
    }
    public override int QuantityAndTypeOfFood(int AnimalWeight, TypeFood typeFood)
    {
        return AnimalWeight * (int)typeFood;
    }
}

class HerbivorousAnimals : Animal
{
    internal string Name;
    internal int ID;
    internal int AnimalWeight;
    internal TypeFood TypeFood;
    internal int Quantity;
    public HerbivorousAnimals(string AnimalName, int ID, int AnimalWeight, TypeFood TypeFood) : base(AnimalName, ID, AnimalWeight, TypeFood)
    {
        Name = AnimalName;
        this.ID = ID;
        this.AnimalWeight = AnimalWeight;
        this.TypeFood = TypeFood;
    }
    public override int QuantityAndTypeOfFood(int AnimalWeight, TypeFood typeFood)
    {
        return AnimalWeight * (int)typeFood;
    }
}

//bool startProgram = true;
//TypeFood f;
//for (int i = 1; startProgram || i == 6; i++)
//{
//    Console.WriteLine(" Чтобы выйти из создания животного введите Выход, что бы продолжить введите что угодно");
//    string userInputMain = Console.ReadLine();
//    if (userInputMain == "Выход" && userInputMain == "выход")
//    {
//        startProgram = false;
//        break;
//    }
//    Console.Write(" Введите имя животного: ");
//    string userInputAnimalName = Console.ReadLine();
//    int id = i;
//    Console.Write(" Введите вес животного: ");
//    int userInputAnimalWeight = int.Parse(Console.ReadLine());
//    Console.Write(" Выберите тип еды: \n 1) Животная пища\n 2) Растительная пища\n 3) Любая пища");
//    string userInputAnimalTypeFood = Console.ReadLine();
//    switch (userInputAnimalTypeFood) 
//    {
//        case "1":

//            break;
//        case "2":
//            break;
//        case "3":
//            break;
//        default:
//            Console.WriteLine(" Ошибка ввода");
//            break;
//    }
//}