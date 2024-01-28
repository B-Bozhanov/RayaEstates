namespace RayaEstates.Data.Models
{
    using RayaEstates.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class Heating : BaseDeletableModel<int>
    {
        public Heating()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}