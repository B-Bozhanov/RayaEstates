namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class BuildingType : BaseDeletableModel<int>
    {
        public BuildingType()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}