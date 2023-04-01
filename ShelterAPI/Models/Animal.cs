using System.ComponentModel.DataAnnotations;

namespace ShelterAPI.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }

    [Required]
    [StringLength(25)]
    public string Name { get; set; }

    [Required]
    public string Species { get; set; }

    public string Gender {get; set;}

    [Required]
    [Range(0, 30, ErrorMessage = "I've never heard of a dog or cat that age.")]
    public int Age { get; set; } 
  }
}