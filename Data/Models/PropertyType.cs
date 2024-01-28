namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class PropertyType : BaseDeletableModel<int>
    {
        public PropertyType()
        {
            this.Properties = new HashSet<Property>();
        }

        [Required]
        public string? Name { get; set; }

        [Required]
        public int PropertyCategoryTypeId { get; set; }

        [Required]
        public virtual PropertyCategoryType? PropertyCategoryType { get; set; } = null!;

        public virtual ICollection<Property> Properties { get; set; }
    }
}