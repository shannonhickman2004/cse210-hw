public class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this.weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {weather}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {title}\nDate: {date}";
    }
}
