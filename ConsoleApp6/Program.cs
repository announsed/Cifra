abstract class People<T, TDouble> 
{
    public abstract TDouble Рост { get; set; }
    public abstract TDouble Вес { get; set; }
    public abstract T Пол { get; set; }
    public abstract T Раcса { get; set; }
    public abstract T ЦветГлаз { get; set; }
}

class Person : People<string, double> 
{
    public override double Рост { get; set; }
    public override double Вес { get; set; }

    public string Имя { get; set; }
    public int Возраст { get; set; }
    public enum Пол 
    {
        Мужчина = 0,
        Женщина = 1
    }

    public Пол ПолЧеловека;
    public string Адрес { get; set; }
    public string НомерТелефона { get; set; }

    public Person(string Имя, int Возраст, Пол Пол, string Адрес, string НомерТелефона)
    {
        this.Имя = Имя;
        this.Возраст = Возраст;
        this.ПолЧеловека = Пол;
        this.Адрес = Адрес;
        this.НомерТелефона = НомерТелефона;
    }

}