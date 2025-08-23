Dictionary<string, int> visits = new Dictionary<string, int>();

bool startProg = true;

while (startProg) 
{
    Console.Write("Введите имя посетитель: ");
    string userInput = Console.ReadLine();
    if (userInput == "выход") 
    {
        startProg = Stop();
    }
    Counter(VisitsName(userInput), userInput);
}




bool VisitsName(string Name) 
{
    bool Visits = false;
    if (visits.ContainsKey(Name)) 
    {
        Visits = true;
    }
    return Visits;
}

void Counter(bool VisitsName, string name) 
{
    if (VisitsName)
    {
        visits[name]++;
    }
    else 
    {
        visits.Add(name, 1);
    }
}

bool Stop() 
{
    string[] keyArrey = visits.Keys.ToArray();
    for (int i = 0; i < visits.Count; i++)
    {
        Console.WriteLine($"Имя клиента: {keyArrey[i]}  количество посещений: {visits[keyArrey[i]]}");
    }

    return false;
}