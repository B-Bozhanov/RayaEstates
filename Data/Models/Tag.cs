namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class Tag : BaseDeletableModel<int>
    {
        public Tag()
        {
            this.Properties = new HashSet<Property>();
        }

        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
    }
}