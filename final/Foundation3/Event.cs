public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress:\n{GetAddress()}";
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: {GetType().Name} {GetType().Name switch
        {
            "Lecture" => ((Lecture)this).GetDetails(),
            "Reception" => ((Reception)this).GetDetails(),
            "OutdoorGathering" => ((OutdoorGathering)this).GetDetails(),
            _ => ""
        }}";
    }

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {_title} - {_date}";
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}