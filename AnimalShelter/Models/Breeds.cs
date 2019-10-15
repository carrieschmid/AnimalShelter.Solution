namespace AnimalShelter.Models
{
  public class Breeds
  {
    public int BreedsId { get; set; }
    public string AnimalName { get; set; }
    public string Gender {get; set; }
    public string Date {get; set; }

    public int SpeciesId {get; set;}
    public virtual Species Species {get; set;}
  }
}