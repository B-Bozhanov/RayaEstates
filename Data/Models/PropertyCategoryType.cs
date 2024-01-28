namespace RayaEstates.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using RayaEstates.Data.Common;

    public class PropertyCategoryType : BaseDeletableModel<int>
    {
        public PropertyCategoryType()
        {
            this.PropertyTypes = new HashSet<PropertyType>();
        }

        [Required]
        public string? Name { get; set; }

        public virtual ICollection<PropertyType> PropertyTypes { get; set; }
    }
}