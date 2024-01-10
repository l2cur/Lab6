namespace Lab6;

public class WeatherResponse
{
    public TemperatureInfo Main { get; set; }
    public CountryInfo Sys { get; set; }
    public string Name { get; set; }
    public DescriptionInfo[] Weather { get; set; }

    public void Print()
    {
        Console.Write("country: " + Sys.Country + ", ");
        Console.Write("name of place: " + Name + ", ");
        Console.Write("description: " + Weather[0].Description + ", ");
        Console.Write("temperature: " + Main.Temp + "\n");
    }
}

public class TemperatureInfo
{
    public float Temp { get; set; }
}

public class DescriptionInfo
{
    public string Description { get; set; }
}

public class CountryInfo
{
    public string Country { get; set; }
}