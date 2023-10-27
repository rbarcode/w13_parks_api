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

    public readonly string[] availableLocations = { "AK", "CA" };

    public readonly string[] availableAuthorities = { "National", "State" };

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      if (Array.IndexOf(availableLocations, Location) == -1)
      {
        yield return new ValidationResult(
          "You must use two-letter USPS state abbreviations. Currently only Alaska ('AK') and California ('CA') supported."
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