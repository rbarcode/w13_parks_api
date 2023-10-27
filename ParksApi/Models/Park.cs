namespace ParksApi.Models
{
  public class ParksApi
  {
    public int ParkId { get; set; }

    public string Name { get; set; }

    public string Location { get; set; }

    public string Authority { get; set; }

    public readonly string[] availableLocations = { "AK", "CA" };

    public readonly string[] availableAuthorities = { "National", "State" };
  }
  
}