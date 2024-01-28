namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class Location : BaseDeletableModel<int>
    {
        public Location()
        {
            this.PopulatedPlaces = new HashSet<PopulatedPlace>();
        }

        [Required]
        public string? Name { get; set; }

        [Required]
        public virtual ICollection<PopulatedPlace> PopulatedPlaces { get; set; }
    }
}