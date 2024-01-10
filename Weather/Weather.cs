using System.Security.Principal;

namespace Lab6;

public struct Weather
{
    public string Country { get; set; }
    public string Name { get; set; }
    public double Temp { get; set; }
    public string Description { get; set; }

    public Weather(WeatherResponse weatherResponse)
    {
        this.Country = weatherResponse.Sys.Country;
        this.Name = weatherResponse.Name;
        this.Temp = weatherResponse.Main.Temp;
        this.Description = weatherResponse.Weather[0].Description;
    }

    public void Print()
    {
        Console.Write("country: " + Country + ", ");
        Console.Write("name of place: " + Name + ", ");
        Console.Write("description: " + Description + ", ");
        Console.Write("temperature: " + Temp + "\n");
    }
}