using System.ComponentModel.DataAnnotations;

namespace ParksApi.Models
{
  public class Park : IValidatableObject
  {
    public int ParkId { get; set; }

    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
    [Required]
    public string Authority { get; set; }

    public readonly string[] availableLocations = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MS", "MO", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY" };

    public readonly string[] availableAuthorities = { "National", "State" };

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (Array.IndexOf(availableLocations, Location) == -1)
      {
        yield return new ValidationResult(
          "Invalid location. You must use two-letter USPS state abbreviations (e.g. 'AL' for 'Alabama')."
        );
      }

      if (Array.IndexOf(availableAuthorities, Authority) == -1)
      {
        yield return new ValidationResult(
          "Only 'National' or 'State' accepted as an authority."
        );
      }
    }


  }
  
}