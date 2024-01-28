namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class Condition : BaseDeletableModel<int>
    {
        public Condition()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}