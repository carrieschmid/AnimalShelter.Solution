using System.Collections.Generic;

namespace AnimalShelter.Models
{
  public class Species
    {
        public Species()
        {
            this.Breeds = new HashSet<Breeds>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Breeds> Breeds { get; set; }
    }
}