namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class PopulatedPlace : BaseDeletableModel<int>
    {
        public PopulatedPlace()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int LocationId { get; set; }

        [Required]
        public virtual Location? Location { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}