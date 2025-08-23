//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using var client = new HttpClient();
        string url = "https://wttr.in/Nizhny+Novgorod?format=j1";

        try
        {
            string response = await client.GetStringAsync(url);
            Console.WriteLine(response);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка запроса: {ex.Message}");
        }


    }
}


class T 
{
    

}


